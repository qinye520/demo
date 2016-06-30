// -----------------------------------------------------------------------
// <copyright file="UpdateProductOptionRequest.cs" company="Microsoft">
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
    /// 保存附加服务请求
    /// </summary>
    public class UpdateProductOptionRequest : RequestBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public UpdateProductOptionRequest()
        {
            this.OptionList = new List<Option>();
        }

        /// <summary>
        /// 供应商产品编号,业务唯一编号
        /// </summary>
        public string VendorProductCode { get; set; }

        /// <summary>
        /// 附加服务列表
        /// </summary>
        public List<Option> OptionList { get; set; }

    }
}
