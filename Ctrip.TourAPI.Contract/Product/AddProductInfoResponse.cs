// -----------------------------------------------------------------------
// <copyright file="AddProductInfoResponse.cs" company="Microsoft">
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
    /// 添加产品基本信息响应
    /// </summary>
    public class AddProductInfoResponse : ResponseBase
    {
        /// <summary>
        /// 携程产品编号
        /// </summary>
        public string CtripProductCode { get; set; }
    }
}
