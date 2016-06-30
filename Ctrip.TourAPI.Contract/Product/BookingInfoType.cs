// -----------------------------------------------------------------------
// <copyright file="BookingInfoType.cs" company="Microsoft">
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
    /// 预定控制类型
    /// </summary>
    [Serializable]
    public class BookingInfoType
    {
        /// <summary>
        /// 产品咨询联系人
        /// </summary>
        public string ProductContact { get; set; }

        /// <summary>
        /// 产品咨询联系人电话
        /// </summary>
        public string ProductContactMobile { get; set; }

        /// <summary>
        /// 新订单是否短信通知
        /// </summary>
        public bool IsSMSNotify { get; set; }

        /// <summary>
        /// 紧急联系人名称
        /// </summary>
        public string EmergencyContact { get; set; }

        /// <summary>
        /// 紧急联系人电话
        /// </summary>
        public string EmergencyContactMobile { get; set; }

        /// <summary>
        /// 是否公布紧急联系人
        /// </summary>
        public bool IsPublishEmergencyContact { get; set; }

        /// <summary>
        /// 提前几天停止售卖
        /// </summary>
        public int AdvancedCloseDays { get; set; }

        /// <summary>
        /// 停止售卖的时间（格式 - HH:mm，必须为整点)
        /// </summary>
        public string AdvancedCloseTime { get; set; }

        /// <summary>
        /// 底价币种，默认CNY
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// 是否周末工作
        /// </summary>
        public bool IsWeekendWork { get; set; }

        /// <summary>
        /// 节假日是否工作
        /// </summary>
        public bool IsHolidayWork { get; set; }
    }
}
