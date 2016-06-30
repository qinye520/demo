using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ctrip.TourAPI
{
    /// <summary>
    /// 套餐信息类型
    /// </summary>
    public class PackageInfo
    {
        /// <summary>
        /// 供应商套餐编号
        /// </summary>
        public string VendorPackageCode { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        public decimal ExchangeRate { get; set; }

        /// <summary>
        /// 成人份数
        /// </summary>
        public int AdultQuantity { get; set; }

        /// <summary>
        /// 成人底价
        /// </summary>
        public decimal AdultCostPrice { get; set; }

        /// <summary>
        /// 儿童份数
        /// </summary>
        public int ChildQuantity { get; set; }

        /// <summary>
        /// 儿童底价
        /// </summary>
        public decimal ChildCostPrice { get; set; }

        /// <summary>
        /// 单房差份额
        /// </summary>
        public int SinglePersonQuantity { get; set; }

        /// <summary>
        /// 单房差底价
        /// </summary>
        public decimal SinglePersonCostPrice { get; set; }

        /// <summary>
        /// 婴儿份数
        /// </summary>
        public int InfantQuantity { get; set; }
    }
}
