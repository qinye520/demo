// -----------------------------------------------------------------------
// <copyright file="BeginSellingRequest.cs" company="Microsoft">
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
    /// 打开产品班期请求
    /// </summary>
    [Serializable]
    public class BeginSellingRequest : RequestBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public BeginSellingRequest()
        {
            this.SellingList = new List<BeginSelling>();
        }

        /// <summary>
        /// 供应商产品编号,业务唯一编号
        /// </summary>
        public string VendorProductCode { get; set; }

        /// <summary>
        /// 打开产品班期请求列表
        /// </summary>
        public List<BeginSelling> SellingList { get; set; }

    }
}
