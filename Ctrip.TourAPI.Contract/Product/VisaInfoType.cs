// -----------------------------------------------------------------------
// <copyright file="VisaInfo.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Ctrip.TourAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 签证信息类型
    /// </summary>
    [Serializable]
    public class VisaInfoType
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public VisaInfoType()
        {
            this.VisaDeliveryAddress = new VisaDeliveryAddressType();
            this.VisaList = new List<Visa>();
        }

        /// <summary>
        /// 是否需要押金
        /// </summary>
        public bool IsNeedDeposit { get; set; }

        /// <summary>
        /// 送签地址
        /// </summary>
        public VisaDeliveryAddressType VisaDeliveryAddress { get; set; }

        /// <summary>
        /// 签证信息列表
        /// </summary>
        public List<Visa> VisaList { get; set; }
    }

    /// <summary>
    /// 送签地址类型
    /// </summary>
    public class VisaDeliveryAddressType
    {
        /// <summary>
        /// 接收城市名称
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 接收地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 办公电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 电子邮件
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 工作时间
        /// </summary>
        public string WorkingHours { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }

    /// <summary>
    /// 签证信息类型
    /// </summary>
    public class Visa
    {
        /// <summary>
        /// 供应商签证编号
        /// </summary>
        public string VendorVisaCode { get; set; }

        /// <summary>
        /// 签证名称
        /// </summary>
        public string VisaName { get; set; }

    }
}
