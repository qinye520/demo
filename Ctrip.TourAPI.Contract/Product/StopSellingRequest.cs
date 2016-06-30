// -----------------------------------------------------------------------
// <copyright file="StopSellingRequest.cs" company="Microsoft">
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
    /// 关闭产品班期请求
    /// </summary>
    [Serializable]
    public class StopSellingRequest : RequestBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public StopSellingRequest()
        {
            this.SellingList = new List<StopSelling>();
        }

        /// <summary>
        /// 供应商产品编号,业务唯一编号
        /// </summary>
        public string VendorProductCode { get; set; }

        /// <summary>
        /// 关闭产品班期列表
        /// </summary>
        public List<StopSelling> SellingList { get; set; }
    }
}
