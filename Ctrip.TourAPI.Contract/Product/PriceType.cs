// -----------------------------------------------------------------------
// <copyright file="PriceType.cs" company="Microsoft">
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
    /// 价格类型
    /// </summary>
    [Serializable]
    public class Price
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Price()
        {
            this.PackagePriceInfoList = new List<PackagePriceInfo>();
            this.OptionPriceInfoList = new List<OptionPriceInfo>();
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
        /// 套餐价格信息列表
        /// </summary>
        public List<PackagePriceInfo> PackagePriceInfoList { get; set; }

        /// <summary>
        /// 附加服务价格信息列表
        /// </summary>
        public List<OptionPriceInfo> OptionPriceInfoList { get; set; }
    }

    /// <summary>
    /// 套餐价格信息类型
    /// </summary>
    [Serializable]
    public class PackagePriceInfo
    {
        /// <summary>
        /// 供应商套餐编码
        /// </summary>
        public string VendorPackageCode { get; set; }

        /// <summary>
        /// 成人底价
        /// </summary>
        public decimal AdultCostPrice { get; set; }

        /// <summary>
        /// 成人卖价
        /// </summary>
        public decimal AdultSalePrice { get; set; }

        /// <summary>
        /// 儿童底价
        /// </summary>
        public decimal ChildCostPrice { get; set; }

        /// <summary>
        /// 儿童卖价
        /// </summary>
        public decimal ChildSalePrice { get; set; }

        /// <summary>
        /// 单房差底价
        /// </summary>
        public decimal SinglePersonCostPrice { get; set; }

        /// <summary>
        /// 单房差卖价
        /// </summary>
        public decimal SinglePersonSalePrice { get; set; }
    }

    /// <summary>
    /// 附加服务价格信息类型
    /// </summary>
    [Serializable]
    public class OptionPriceInfo
    {
        /// <summary>
        /// 供应商附加服务编码
        /// </summary>
        public string VendorOptionCode { get; set; }

        /// <summary>
        /// 底价
        /// </summary>
        public decimal CostPrice { get; set; }

        /// <summary>
        /// 卖价(业务可能协商供应商指定卖价)
        /// </summary>
        public decimal SalePrice { get; set; }

    }
}
