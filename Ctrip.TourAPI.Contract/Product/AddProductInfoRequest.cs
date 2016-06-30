// -----------------------------------------------------------------------
// <copyright file="AddProductInfoRequest.cs" company="Microsoft">
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
    /// 添加产品基本信息请求
    /// </summary>
    [Serializable]
    public class AddProductInfoRequest : RequestBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public AddProductInfoRequest()
        { 
            this.ProductInfo = new ProductInfoType();
            this.BookingInfo = new BookingInfoType();
            this.ProductDescriptionList = new List<ProductDescription>();
            this.ItineraryList = new List<ItineraryDay>();
        }

        /// <summary>
        /// 供应商产品编号
        /// </summary>
        public string VendorProductCode { get; set; }

        /// <summary>
        /// 供应商产品信息
        /// </summary>
        public ProductInfoType ProductInfo { get; set; }

        /// <summary>
        /// 预定控制
        /// </summary>
        public BookingInfoType BookingInfo { get; set; }

        /// <summary>
        /// 签证信息(默认为null)
        /// </summary>
        public VisaInfoType VisaInfo { get; set; }

        /// <summary>
        /// 产品条款信息
        /// </summary>
        public List<ProductDescription> ProductDescriptionList { get; set; }

        /// <summary>
        /// 每日行程
        /// </summary>
        public List<ItineraryDay> ItineraryList { get; set; }

        /// <summary>
        /// 退订条款(默认为null)
        /// </summary>
        public BreachClause BreachClause { get; set; }
    }
}
