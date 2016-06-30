
using Ctrip.TourAPI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ctrip.TourAPI.ClientDemo
{
    /// <summary>
    /// 携程直连平台客户端样例
    /// </summary>
    class Program
    {
        /// <summary>
        /// 主函数
        /// </summary>
        static void Main(string[] args)
        {
            // 获取供应商令牌
            string token = ConfigurationManager.AppSettings["Token"].ToString().Trim();

            // 获取供应商编号
            long id = Convert.ToInt32(ConfigurationManager.AppSettings["Id"].ToString().Trim());

            #region 添加产品基本信息接口调用样例

            // 构造请求对象
            AddProductInfoRequest productRequest = new AddProductInfoRequest();

            // 生成请求对象
            productRequest = GetProductDemoRequest(id, token);

            // 调用携程供应商平台SDK，获取相应对象
            AddProductInfoResponse productResponse = CtripOpenAPI.Instance.AddProductInfo(productRequest);

            // 返回信息样例显示
            Console.WriteLine("Add Product Basic Info By Ctrip API, Done!");
               if (!string.IsNullOrEmpty(productResponse.ErrorCode))
            {
                Console.WriteLine("新增产品基本信息出错：{0}", productResponse.ErrorMsg);
            }
            else
            {
                Console.WriteLine("新增产品基本信息成功，携程产品编号：{0}。", productResponse.CtripProductCode);
            }
            Console.WriteLine();

            #endregion

            #region 订单行为获取接口调用样例

            // 构造请求对象
            GetTodoOrderListRequest orderRequest = new GetTodoOrderListRequest();

            // 生成请求对象
            orderRequest = GetOrderDemoRequest(id, token);

            // 调用携程供应商平台SDK，获取相应对象
            GetTodoOrderListResponse orderResponse = CtripOpenAPI.Instance.GetTodoOrderList(orderRequest);

            // 返回信息样例显示
            Console.WriteLine("Get Todo Order List By Ctrip API, Done!");
            foreach (var order in orderResponse.TodoOrderList)
            {
                Console.WriteLine("Ctrip OrderId ： {0}", order.OrderId);

            }
            Console.WriteLine();

            #endregion

            // 业务处理 ...

            Console.WriteLine("...");
            Console.ReadKey();
        }

        /// <summary>
        /// 生成添加产品基本信息接口请求对象方法样例
        /// </summary>
        /// <param name="id">供应商编号，由携程分配</param>
        /// <param name="token">供应商令牌，由携程分配</param>
        /// <returns>生成添加产品基本信息接口请求对象</returns>
        public static AddProductInfoRequest GetProductDemoRequest(long id, string token)
        {
            Random rnd = new Random();

            AddProductInfoRequest request = new AddProductInfoRequest()
            {
                RequestHeader = new RequestHeaderType()
                {
                    VendorId = id,
                    VendorToken = token,
                },
                VendorProductCode = "供应商对接编号" + rnd.Next().ToString(),
                ProductInfo = new ProductInfoType()
                {
                    TourType = TourType.AroundTour,
                    ArrivalCityName = "String",
                    BrandName = "String",
                    DepartureCityName = "String",
                    DescriptionToCtripOperator = "String",
                    IsNeedIDCard = true,
                    ProductRecommend = "String",
                    TransportationType = TransportationType.Airplane,
                    TravelDays = 1,
                    VendorProductName = "String",
                },
                BookingInfo = new BookingInfoType()
                {
                    AdvancedCloseDays = 4,
                    AdvancedCloseTime = "String",
                    Currency = "String",
                    EmergencyContact = "String",
                    EmergencyContactMobile = "String",
                    IsHolidayWork = false,
                    IsPublishEmergencyContact = false,
                    IsSMSNotify = false,
                    IsWeekendWork = false,
                    ProductContact = "String",
                    ProductContactMobile = "String",
                },
                VisaInfo = new VisaInfoType()
                {
                    IsNeedDeposit = false,
                    VisaDeliveryAddress = new VisaDeliveryAddressType()
                    {
                        Address = "String",
                        CityName = "String",
                        CompanyName = "String",
                        Contact = "String",
                        Email = "String",
                        Mobile = "String",
                        Phone = "String",
                        PostCode = "String",
                        Remark = "String",
                        WorkingHours = "String",
                    },
                    VisaList = new List<Visa>()
                     {
                         new Visa()
                         {
                             VendorVisaCode = "String",
                             VisaName = "String",
                         }
                     },
                },
                ProductDescriptionList = new List<ProductDescription>()
                {
                    new ProductDescription()
                    {
                         Content = "String",
                         DescriptionType =  DescriptionType.Recommend,
                    },
                },
                ItineraryList = new List<ItineraryDay>()
                {
                    new ItineraryDay()
                    {
                         AccommdationDescription = "String",
                         Day = 1,
                         ItineraryDescription  = "String",
                         ItineraryName  = "String",
                         MealDescription  = "String",
                         POIList = new List<POI>()
                         {
                            new POI()
                            {
                                POIName = "String",
                            },
                         },
                    },
                },
                BreachClause = new BreachClause()
                {
                    AgencyBreachClauseList = new List<BreachClauseType>()
                    {
                        new BreachClauseType()
                        {
                             FromDaysBeforeDeparture = 1,
                             LossPercent = 0.01M,
                             ToDaysBeforeDeparture = 10,
                        },
                    },
                    TravelerBreachClauseList = new List<BreachClauseType>()
                    {
                         new BreachClauseType()
                         {
                              FromDaysBeforeDeparture = 1,
                              LossPercent = 0.01M,
                              ToDaysBeforeDeparture = 10,
                         },
                    },
                },
            };

            return request;
        }

        /// <summary>
        /// 生成订单行为获取接口请求对象方法样例
        /// </summary>
        /// <param name="id">供应商编号，由携程分配</param>
        /// <param name="token">供应商令牌，由携程分配</param>
        /// <returns>生成订单行为获取接口请求对象</returns>
        public static GetTodoOrderListRequest GetOrderDemoRequest(long id, string token)
        {
            var result = new GetTodoOrderListRequest()
            {
                RequestHeader = new RequestHeaderType()
                {
                    VendorId = id,
                    VendorToken = token,
                },
                StartDateTime = new DateTime(2014, 12, 3, 0, 0, 0),
                EndDateTime = new DateTime(2014, 12, 3, 23, 59, 59),
            };

            return result;
        }
    }
}
