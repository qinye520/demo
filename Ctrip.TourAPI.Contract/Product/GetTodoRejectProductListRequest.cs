// -----------------------------------------------------------------------
// <copyright file="GetTodoRejectProductListRequest.cs" company="Microsoft">
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
    /// 获得产品审核信息请求
    /// </summary>
    public class GetTodoRejectProductListRequest : RequestBase
    {
        /// <summary>
        /// 审核开始时间
        /// </summary>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// 审核结束时间
        /// </summary>
        public DateTime EndDateTime { get; set; }
    }
}
