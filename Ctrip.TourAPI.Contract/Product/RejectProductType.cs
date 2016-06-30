// -----------------------------------------------------------------------
// <copyright file="RejectProductType.cs" company="Microsoft">
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
    /// 产品审核信息
    /// </summary>
    public class RejectProductType
    {
        /// <summary>
        /// 供应商产品编号,业务唯一编号
        /// </summary>
        public string VendorProductCode { get; set; }

        /// <summary>
        /// 审核类型
        /// </summary>
        public AuditType AuditType { get; set; }

        /// <summary>
        /// 被拒绝的日期，用半角逗号(,)隔开
        /// </summary>
        public string Days { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        public string RejectReason { get; set; }
    }

    /// <summary>
    /// 审核类型
    /// </summary>
    public enum AuditType
    {
        /// <summary>
        /// 产品
        /// </summary>
        Product,

        /// <summary>
        /// 产品价格
        /// </summary>
        Price,

        /// <summary>
        /// 产品库存
        /// </summary>
        Inventory,
    }
}
