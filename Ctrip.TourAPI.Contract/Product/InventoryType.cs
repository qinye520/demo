// -----------------------------------------------------------------------
// <copyright file="Inventory.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Ctrip.TourAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    /// <summary>
    /// 产品库存类型
    /// </summary>
    [Serializable]
    public class Inventory
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Inventory()
        {
            this.PackageInventoryInfoList = new List<PackageInventoryInfo>();
        }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 每周的有效班期。若每天都有班期则为1234567, 124则为周一、二、四开班
        /// </summary>
        public string DayOfWeek { get; set; }

        /// <summary>
        /// 套餐库存信息列表
        /// </summary>
        public List<PackageInventoryInfo> PackageInventoryInfoList { get; set; }
    }

    /// <summary>
    /// 套餐库存信息类型
    /// </summary>
    [Serializable]
    public class PackageInventoryInfo
    {
        /// <summary>
        /// 供应商套餐编码
        /// </summary>
        public string VendorPackageCode { get; set; }

        /// <summary>
        /// 库存类型
        /// Inventory: 库存，NeedComfirn:每单确认
        /// </summary>
        public string InventoryType { get; set; }

        /// <summary>
        /// 切位库存数
        /// </summary>
        public int ReservedInventoryQuantity { get; set; }

        /// <summary>
        /// 共享库存数
        /// </summary>
        public int SharedInventoryQuantity { get; set; }

        /// <summary>
        /// 库存清位时刻，如：XX点
        /// </summary>
        public int ReservedInventoryCleanUpHour { get; set; }

        /// <summary>
        /// 库存清位提前天数
        /// </summary>
        public int ReservedInventoryCleanUpDays { get; set; }
    }


}
