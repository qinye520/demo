using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ctrip.TourAPI
{
    /// <summary>
    /// 订单信息类型
    /// </summary>
    public class OrderInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public OrderInfo()
        {
            this.PackageInfo = new PackageInfo();
            this.OptionInfoList = new List<OptionInfo>();
            this.TravelerList = new List<Traveler>();
        }

        /// <summary>
        /// 预订时间
        /// </summary>
        public DateTime BookingTime { get; set; }

        /// <summary>
        /// 套餐信息
        /// </summary>
        public PackageInfo PackageInfo { get; set; }

        /// <summary>
        /// 可选项列表
        /// </summary>
        public List<OptionInfo> OptionInfoList { get; set; }

        /// <summary>
        /// 出行人列表
        /// </summary>
        public List<Traveler> TravelerList { get; set; }

        /// <summary>
        /// 付款状态 ： 已付 true/未付 false
        /// </summary>
        public bool IsPaid { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
