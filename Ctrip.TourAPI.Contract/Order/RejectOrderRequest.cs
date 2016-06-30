namespace Ctrip.TourAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 拒绝新订单请求
    /// </summary>
    public class RejectOrderRequest : RequestBase
    {
        /// <summary>
        /// 携程订单编号
        /// </summary>
        public long OrderId { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string MessageId { get; set; }
    }

}
