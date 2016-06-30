// -----------------------------------------------------------------------
// <copyright file="OptionType.cs" company="Microsoft">
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
    /// 附加服务类型
    /// </summary>
    public class Option
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Option()
        {
            this.MinPersonCount = 1;
            this.MaxPersonCount = 999;
        }

        /// <summary>
        /// 附加服务名称
        /// </summary>
        public string OptionName { get; set; }

        /// <summary>
        /// 供应商附加服务编号
        /// </summary>
        public string VendorOptionCode { get; set; }

        /// <summary>
        /// 附加服务介绍
        /// </summary>
        public string OptionDescription { get; set; }

        /// <summary>
        /// 限定人档的最少人数，默认1
        /// </summary>
        public int MinPersonCount { get; set; }

        /// <summary>
        /// 限定人档的最大人数，默认999
        /// </summary>
        public int MaxPersonCount { get; set; }
    }
}
