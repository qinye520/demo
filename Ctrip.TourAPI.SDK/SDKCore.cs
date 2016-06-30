using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ctrip.TourAPI
{
    /// <summary>
    /// 携程直连SDK
    /// </summary>
    internal class SDKCore
    {
        /// <summary>
        /// 携程直连API接口地址URL
        /// </summary>
        private static string url = ConfigurationManager.AppSettings["CtripAddress"] != null ? ConfigurationManager.AppSettings["CtripAddress"].ToString().Trim() : "http://58.221.127.200/api/";

        /// <summary>
        /// 以POST方式，访问直连接口并获取返回报文
        /// </summary>
        /// <param name="request">请求报文字符串</param>
        /// <param name="method">请求的方法名称</param>
        /// <returns>返回报文字符串</returns>
        public static string PostRequest(string request, string method)
        {
            string response = string.Empty;

            var webClient = new WebClient();

            //采取POST方式必须加的header，如果改为GET方式的话就去掉这句话即可
            webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            byte[] data = Encoding.UTF8.GetBytes(request);

            //得到返回字符流
            byte[] responseData = webClient.UploadData(url + method, "POST", data);

            //解码
            response = Encoding.UTF8.GetString(responseData);

            return response;
        }

        /// <summary>
        /// 以POST方式访问携程直连接口泛型方法
        /// </summary>
        /// <typeparam name="U">返回实体类型</typeparam>
        /// <typeparam name="V">请问实体类型</typeparam>
        /// <param name="v">接口请求实体</param>
        /// <param name="method">请求的方法名称</param>
        /// <returns>接口返回实体</returns>
        public static U PostMessage<U, V>(V v, string method)
        {
            // 请求实体序列化为字符串
            var request = ObjToXMLString(v);

            // 调用请问方法
            var response = PostRequest(request, method);

            // 因时间样式问题，现以字符串匹配方式进行样式转换
            response = FormatDateTime(response);

            // 反序列化返回报文字符串
            return XMLStringToObj<U>(response);
        }

        /// <summary>
        /// 反序列化实体
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="str">字符串</param>
        /// <returns>对象实体</returns>
        private static T XMLStringToObj<T>(string str)
        {
            using (var memoryStream = new MemoryStream())
            {
                StreamWriter writer = new StreamWriter(memoryStream);
                writer.Write(str);
                writer.Flush();
                memoryStream.Position = 0;

                var request = Encoding.UTF8.GetString(memoryStream.ToArray());
                  
                var xmlStream = new StringReader(request);
                return (T)(new XmlSerializer(typeof(T)).Deserialize(xmlStream));
            }
        }

        /// <summary>
        /// 序列化实体
        /// </summary>
        /// <param name="obj">对象实体</param>
        /// <returns>字符串</returns>
        private static string ObjToXMLString(object obj)
        {
            string result = string.Empty;

            using (var memoryStream = new MemoryStream())
            {
                new XmlSerializer(obj.GetType()).Serialize(memoryStream, obj);
                result = Encoding.UTF8.GetString(memoryStream.ToArray());
            }

            return result;
        }

        /// <summary>
        /// 转换日期时间字段格式
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string FormatDateTime(string input)
        {
            string pattern = @"(?<prefix>>)(?<date>[0-9]{4}(-[0-9]{1,2}){2})\s(?<time>[0-9]{1,2}(:[0-9]{1,2}){2})(?<postfix><)";
            string replacement = ">${date}T${time}.00000000<";

            Regex rgx = new Regex(pattern);

            var result = rgx.Replace(input, replacement);

            return result;
        }
    }
}
