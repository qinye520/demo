// -----------------------------------------------------------------------
// <copyright file="ResponseBase.cs" company="Microsoft">
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
    /// 响应基本类型
    /// </summary>
    public class ResponseBase
    {
        /// <summary>
        /// 故障编码
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// 故障信息
        /// </summary>
        public string ErrorMsg { get; set; }
    }
}
