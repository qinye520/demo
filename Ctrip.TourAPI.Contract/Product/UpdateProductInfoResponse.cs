// -----------------------------------------------------------------------
// <copyright file="UpdateProductInfoResponse.cs" company="Microsoft">
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
    /// 更新产品基本信息响应(暂不支持更新）
    /// </summary>
    [Serializable]
    public class UpdateProductInfoResponse : ResponseBase
    {
        /// <summary>
        /// 携程产品编号
        /// </summary>
        public string CtripProductCode { get; set; }
    }
}
