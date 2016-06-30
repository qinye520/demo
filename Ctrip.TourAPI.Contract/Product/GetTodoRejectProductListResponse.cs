// -----------------------------------------------------------------------
// <copyright file="GetTodoRejectProductListResponse.cs" company="Microsoft">
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
    /// 获得产品审核信息响应
    /// </summary>
    public class GetTodoRejectProductListResponse : ResponseBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public GetTodoRejectProductListResponse()
        {
            this.RejectProductList = new List<RejectProductType>();
        }

        /// <summary>
        /// 产品审核信息列表
        /// </summary>
        public List<RejectProductType> RejectProductList { get; set; }
    }
}
