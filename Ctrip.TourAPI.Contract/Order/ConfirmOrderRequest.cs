namespace Ctrip.TourAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 确认订单请求
    /// </summary>
    public class ConfirmOrderRequest : RequestBase
    {
        /// <summary>
        /// 携程订单编号
        /// </summary>
        public long OrderId { get; set; }

        /// <summary>
        /// 供应商订单号
        /// </summary>
        public string VendorOrderId { get; set; }

        /// <summary>
        /// 消息编号
        /// </summary>
        public string MessageId { get; set; }
    }

}
