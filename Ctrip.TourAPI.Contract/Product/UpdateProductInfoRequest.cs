// -----------------------------------------------------------------------
// <copyright file="UpdateProductInfoRequest.cs" company="Microsoft">
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
    /// 更新产品基本信息请求(暂时不支持更新）
    /// </summary>
    [Serializable]
    public class UpdateProductInfoRequest : RequestBase
    {
        /// <summary>
        /// 供应商产品编号,业务唯一编号
        /// </summary>
        public string VendorProductCode { get; set; }

        /// <summary>
        /// 供应商产品信息
        /// </summary>
        public UpdateProductInfoType ProductInfo { get; set; }

        /// <summary>
        /// 预定控制
        /// </summary>
        public BookingInfoType BookingInfo { get; set; }

        /// <summary>
        /// 签证信息
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
        /// 退订条款
        /// </summary>
        public BreachClause BreachClause { get; set; }
    }
}
