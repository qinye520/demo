// -----------------------------------------------------------------------
// <copyright file="UpdateProductInventoryRequest.cs" company="Microsoft">
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
    /// 更新产品库存请求
    /// </summary>
    [Serializable]
    public class UpdateProductInventoryRequest : RequestBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public UpdateProductInventoryRequest()
        {
            this.InventoryList = new List<Inventory>();
        }

        /// <summary>
        /// 供应商产品编号,业务唯一编号
        /// </summary>
        public string VendorProductCode { get; set; }

        /// <summary>
        /// 产品库存列表
        /// </summary>
        public List<Inventory> InventoryList { get; set; }
    }
}
