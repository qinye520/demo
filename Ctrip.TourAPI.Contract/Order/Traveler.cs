using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ctrip.TourAPI
{
    /// <summary>
    /// 出行人类型
    /// </summary>
    public class Traveler
    {
        /// <summary>
        /// 出行人编号
        /// </summary>
        public long TravelerId { get; set; }

        /// <summary>
        /// 中文姓名
        /// </summary>
        public string ChineseName { get; set; }

        /// <summary>
        /// 英文姓名
        /// </summary>
        public string EnglishName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public string BirthDate { get; set; }

        /// <summary>
        /// 出生城市
        /// </summary>
        public string BirthCity { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 年龄段
        /// </summary>
        public AgeCategory AgeCategory { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        public IDType IDType { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        public string IDNumber { get; set; }

        /// <summary>
        /// 证件签发日期
        /// </summary>
        public string IssuedDate { get; set; }

        /// <summary>
        /// 证件过期日期
        /// </summary>
        public string ExpiredDate { get; set; }

        /// <summary>
        /// 签发地
        /// </summary>
        public string IssuedPlace { get; set; }

        /// <summary>
        /// 是否愿意拼房
        /// </summary>
        public bool IsRoomShare { get; set; }
    }
}
