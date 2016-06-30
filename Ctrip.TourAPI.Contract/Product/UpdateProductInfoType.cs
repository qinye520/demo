// -----------------------------------------------------------------------
// <copyright file="UpdateProductInfoType.cs" company="Microsoft">
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
    /// 更新供应商产品信息类型
    /// </summary>
    public class UpdateProductInfoType
    {
        /// <summary>
        /// 供应商产品名称
        /// </summary>
        public string VendorProductName { get; set; }

        /// <summary>
        /// 供应商产品品牌名称
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// 产品推荐
        /// </summary>
        public string ProductRecommend { get; set; }

        /// <summary>
        /// 携程OP注意事项
        /// </summary>
        public string DescriptionToCtripOperator { get; set; }

        /// <summary>
        /// 携程定义的交通工具类型，参看接口文档对类型的定义
        /// </summary>
        public string TransportationType { get; set; }

        /// <summary>
        /// 是否需要证件号预定
        /// </summary>
        public bool IsNeedIDCard { get; set; }
    }
}
