// -----------------------------------------------------------------------
// <copyright file="RequestHeader.cs" company="Microsoft">
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
    /// 请求头类型
    /// </summary>
    public class RequestHeaderType
    {
        /// <summary>
        /// 供应商编号
        /// </summary>
        public long VendorId { get; set; }

        /// <summary>
        /// 供应商令牌
        /// </summary>
        public string VendorToken { get; set; }
    }
}
