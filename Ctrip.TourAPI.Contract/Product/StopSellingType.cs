// -----------------------------------------------------------------------
// <copyright file="StopSellingType.cs" company="Microsoft">
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
    /// 关闭产品班期类型
    /// </summary>
    public class StopSelling
    {
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
        /// 关团原因
        /// </summary>
        public string Reason { get; set; }
    }
}
