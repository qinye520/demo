// -----------------------------------------------------------------------
// <copyright file="UpdateProductUpgradePackageRequest.cs" company="Microsoft">
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
    /// 保存升级套餐请求
    /// </summary>
    [Serializable]
    public class UpdateProductUpgradePackageRequest : RequestBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public UpdateProductUpgradePackageRequest()
        {
            this.UpgradePackageList = new List<UpgradePackage>();
        }

        /// <summary>
        /// 供应商产品编号,业务唯一编号
        /// </summary>
        public string VendorProductCode { get; set; }

        /// <summary>
        /// 升级套餐列表
        /// </summary>
        public List<UpgradePackage> UpgradePackageList { get; set; }
    }
}
