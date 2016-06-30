using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ctrip.TourAPI
{
    /// <summary>
    /// 订单类型
    /// </summary>
    [Serializable()]
    public class Order
    {
        public Order()
        {
            this.OrderInfo = new OrderInfo();
            this.ChangeList = new List<Change>();
        }

        /// <summary>
        /// 携程订单编号
        /// </summary>
        public long OrderId { get; set; }

        /// <summary>
        /// 订单操作状态
        /// </summary>
        public OrderAction Action { get; set; }

        /// <summary>
        /// 供应商产品编号,业务唯一编号
        /// </summary>
        public string VendorProductCode { get; set; }

        /// <summary>
        /// 出发日期
        /// </summary>
        public DateTime DepartureDate { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        public OrderInfo OrderInfo { get; set; }

        /// <summary>
        /// 更新内容列表
        /// </summary>
        public List<Change> ChangeList { get; set; }

        /// <summary>
        /// 消息编号
        /// </summary>
        public string MessageId { get; set; }
    }
}
