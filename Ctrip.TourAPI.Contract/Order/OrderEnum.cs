using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ctrip.TourAPI
{
    /// <summary>
    /// 订单 处理类型
    /// </summary>
    public enum OrderAction
    {
        /// <summary>
        /// 新建订单
        /// </summary>
        Create,

        /// <summary>
        /// 修改订单
        /// </summary>
        Modify,

        /// <summary>
        /// 订单付款
        /// </summary>
        Pay,

        /// <summary>
        /// 删除订单，在确认前的删除。
        /// </summary>
        Delete,

        /// <summary>
        /// 取消订单，在确认后的删除。
        /// </summary>
        Cancel,
    }

    /// <summary>
    /// 年龄段类型
    /// </summary>
    public enum AgeCategory
    {
        /// <summary>
        /// 未知
        /// </summary>
        Unknown,

        /// <summary>
        /// 成人
        /// </summary>
        Adult,

        /// <summary>
        /// 儿童
        /// </summary>
        Child,

        /// <summary>
        /// 婴儿
        /// </summary>
        Infant,
    }

    /// <summary>
    /// 证件类型
    /// </summary>
    public enum IDType
    {
        /// <summary>
        /// 身份证
        /// </summary>
        IDCard,

        /// <summary>
        /// 护照
        /// </summary>
        Passport,

        /// <summary>
        /// 户口簿
        /// </summary>
        HouseholdRegister,

        /// <summary>
        /// 港澳通行证
        /// </summary>
        PermitToHongKongAndMacau,

        /// <summary>
        /// 入台证
        /// </summary>
        TaiwanEntryPermits,

        /// <summary>
        /// 军官证
        /// </summary>
        MilitaryOfficer,

        /// <summary>
        /// 台胞证
        /// </summary>
        TaiwanCompatriotPermit,

        /// <summary>
        /// 香港居民往来内地通行证
        /// </summary>
        HomeReturnPermit,

        /// <summary>
        /// 警官证
        /// </summary>
        PoliceBadge,

        /// <summary>
        /// 驾驶证
        /// </summary>
        DrivingLicense,

        /// <summary>
        /// 学生证
        /// </summary>
        StudentIdentity,

        /// <summary>
        /// 海员证
        /// </summary>
        SeafarerPassport,

        /// <summary>
        /// 外国人在中国永久居留证
        /// </summary>
        ForeignerPermanent,

        /// <summary>
        /// 其他
        /// </summary>
        Other,
    }

    /// <summary>
    /// 性别
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// 男性
        /// </summary>
        Male,

        /// <summary>
        /// 女性
        /// </summary>
        Female,
    }
}
