using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ctrip.TourAPI
{
    /// <summary>
    /// 订单行为获取请求
    /// </summary>
    public class GetTodoOrderListRequest : RequestBase
    {
        /// <summary>
        /// 起始时间
        /// </summary>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        public DateTime EndDateTime { get; set; }
    }
}
