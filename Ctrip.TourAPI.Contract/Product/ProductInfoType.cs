// -----------------------------------------------------------------------
// <copyright file="ProductInfoType.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Ctrip.TourAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    /// <summary>
    /// 供应商产品信息类型
    /// </summary>
    [Serializable]
    public class ProductInfoType
    {
        public string ProductType { get; set; }
        /// <summary>
        /// 携程产品类型
        /// </summary>
        public TourType TourType { get; set; }

        /// <summary>
        /// 产品形态
        /// </summary>
        public string ProductPattern { get; set; }

        /// <summary>
        /// 供应商产品名称
        /// </summary>
        public string VendorProductName { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        public string SubHeadName { get; set; }

        /// <summary>
        /// 用户组名称
        /// </summary>
        public string UserGroupName { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// 产品推荐
        /// </summary>
        public string ProductRecommend { get; set; }

        /// <summary>
        /// 携程OP注意事项
        /// </summary>
        public string DescriptionToCtripOperator { get; set; }

        /// <summary>
        /// 行程天数
        /// </summary>
        public int TravelDays { get; set; }

        /// <summary>
        /// 行程晚数
        /// </summary>
        public int TravelNights { get; set; }

        /// <summary>
        /// 出发城市
        /// </summary>
        public string DepartureCityName { get; set; }

        /// <summary>
        /// 目的地城市(第一天行程）
        /// </summary>
        public string ArrivalCityName { get; set; }

        /// <summary>
        /// 携程定义的交通工具类型
        /// </summary>
        public TransportationType TransportationType { get; set; }

        /// <summary>
        /// 是否需要证件号预定
        /// </summary>
        public bool IsNeedIDCard { get; set; }
    }

    /// <summary>
    /// 产品条款信息类型
    /// </summary>
    public class ProductDescription
    {
        /// <summary>
        /// 条款类型
        /// </summary>
        public DescriptionType DescriptionType { get; set; }

        /// <summary>
        /// 内容描述
        /// </summary>
        public string Content { get; set; }
    }

    /// <summary>
    /// 每日行程类型
    /// </summary>
    public class ItineraryDay
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ItineraryDay()
        {
            this.POIList = new List<POI>();
        }

        /// <summary>
        /// 第几天行程，1~20，不得重复，1起步顺序增长
        /// </summary>
        public int Day { get; set; }

        /// <summary>
        /// 行程段标题(北京-上海)
        /// </summary>
        public string ItineraryName { get; set; }

        /// <summary>
        /// 行程描述
        /// </summary>
        public string ItineraryDescription { get; set; }

        /// <summary>
        /// 住宿描述
        /// </summary>
        public string AccommdationDescription { get; set; }

        /// <summary>
        /// 餐饮描述
        /// </summary>
        public string MealDescription { get; set; }

        /// <summary>
        /// 兴趣点列表
        /// </summary>
        public List<POI> POIList { get; set; }
    }

    /// <summary>
    /// 兴趣点类型
    /// </summary>
    public class POI
    {
        /// <summary>
        /// 兴趣点名称
        /// </summary>
        public string POIName { get; set; }
    }

    /// <summary>
    /// 退订条款集
    /// </summary>
    public class BreachClause
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public BreachClause()
        {
            this.TravelerBreachClauseList = new List<BreachClauseType>();
            this.AgencyBreachClauseList = new List<BreachClauseType>();
        }

        /// <summary>
        /// 游客退订条款列表
        /// </summary>
        public List<BreachClauseType> TravelerBreachClauseList { get; set; }

        /// <summary>
        /// 供应商退订条款列表
        /// </summary>
        public List<BreachClauseType> AgencyBreachClauseList { get; set; }
    }

    /// <summary>
    /// 退订条款类型
    /// </summary>
    public class BreachClauseType
    {
        /// <summary>
        /// 最大提前天数
        /// </summary>
        public int FromDaysBeforeDeparture { get; set; }

        /// <summary>
        /// 最小提前天数
        /// </summary>
        public int ToDaysBeforeDeparture { get; set; }

        /// <summary>
        /// 损失比例，取值【0-1】，两位小数
        /// </summary>
        public decimal LossPercent { get; set; }
    }

    /// <summary>
    /// 携程产品类型
    /// </summary>
    public enum TourType
    {
        /// <summary>
        /// 国内周边N日游
        /// </summary>
        [XmlEnum(Name = "AroundTour")]
        AroundTour = 9,

        /// <summary>
        /// 国内游
        /// </summary>
        [XmlEnum(Name = "DomesticTour")]
        DomesticTour = 10,

        /// <summary>
        /// 出境游
        /// </summary>
        [XmlEnum(Name = "OutboundTour")]
        OutboundTour = 11,

        /// <summary>
        /// 境外N日游
        /// </summary>
        [XmlEnum(Name = "OverSeasLocalTour")]
        OverSeasLocalTour = 26,
    }

    /// <summary>
    /// 携程定义的交通工具类型
    /// </summary>
    public enum TransportationType
    {
        /// <summary>
        /// 飞机
        /// </summary>
        Airplane = 1,

        /// <summary>
        /// 火车
        /// </summary>
        Train = 2,

        /// <summary>
        /// 自驾
        /// </summary>
        Car = 4,

        /// <summary>
        /// 巴士
        /// </summary>
        Bus = 8,

        /// <summary>
        /// 轮船
        /// </summary>
        Ship = 16,

        /// <summary>
        /// 邮轮
        /// </summary>
        Cruises = 32,

        /// <summary>
        /// 快船
        /// </summary>
        Speedboat = 64,

        /// <summary>
        /// 飞机+火车
        /// </summary>
        AirplaneTrain = 3,

        /// <summary>
        /// 飞机+巴士
        /// </summary>
        AirplaneBus = 9,

        /// <summary>
        /// 巴士+火车
        /// </summary>
        BusTrain = 10,
    }

    /// <summary>
    /// 条款类型
    /// </summary>
    public enum DescriptionType
    {
        /// <summary>
        /// 产品经理推荐
        /// </summary>
        Recommend = 8, 

        /// <summary>
        /// 预定须知
        /// </summary>
        BookingInfo = 10, 

        /// <summary>
        /// 费用包含
        /// </summary>
        IncludeExpense = 15, 

        /// <summary>
        /// 签证须知
        /// </summary>
        VisaInfo = 20, 

        /// <summary>
        /// 自理费用说明
        /// </summary>
        ExcludeExpense = 71, 

        /// <summary>
        /// 儿童价定义
        /// </summary>
        ChildPriceDefination = 9, 
    }


}
