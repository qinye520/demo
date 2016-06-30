// -----------------------------------------------------------------------
// <copyright file="PackageType.cs" company="Microsoft">
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
    /// 升级套餐类型
    /// </summary>
    [Serializable]
    public class UpgradePackage
    {
        /// <summary>
        /// 套餐名称
        /// </summary>
        public string PackageName { get; set; }

        /// <summary>
        /// 供应商套餐编号
        /// </summary>
        public string VendorPackageCode { get; set; }

        /// <summary>
        /// 套餐介绍
        /// </summary>
        public string PackageDescription { get; set; }
    }
}
