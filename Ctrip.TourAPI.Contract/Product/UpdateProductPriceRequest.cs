// -----------------------------------------------------------------------
// <copyright file="UpdateProductPriceRequest.cs" company="Microsoft">
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
    /// 更新产品价格请求
    /// </summary>
    [Serializable]
    public class UpdateProductPriceRequest : RequestBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public UpdateProductPriceRequest()
        {
            this.PriceList =  new List<Price>();
        }

        /// <summary>
        /// 供应商产品编号,业务唯一编号
        /// </summary>
        public string VendorProductCode { get; set; }

        /// <summary>
        /// 价格列表
        /// </summary>
        public List<Price> PriceList { get; set; }
    }
}
