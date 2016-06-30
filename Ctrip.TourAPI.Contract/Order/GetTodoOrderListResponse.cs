using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ctrip.TourAPI
{
    /// <summary>
    /// 订单行为获取响应
    /// </summary>
    public class GetTodoOrderListResponse : ResponseBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public GetTodoOrderListResponse()
        {
            this.TodoOrderList = new List<Order>();
        }

        /// <summary>
        /// 订单列表
        /// </summary>
        public List<Order> TodoOrderList { get; set; }
    }
}
