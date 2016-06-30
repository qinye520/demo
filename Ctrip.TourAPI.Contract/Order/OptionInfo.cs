using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ctrip.TourAPI
{
    /// <summary>
    /// 可选项类型
    /// </summary>
    public class OptionInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public OptionInfo()
        {
           this.TravelerIdList = new List<long>();
        }

        /// <summary>
        /// 供应商附加服务类型
        /// </summary>
        public string VendorOptionCode { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        public decimal ExchangeRate { get; set; }

        /// <summary>
        /// 底价
        /// </summary>
        public decimal CostPrice { get; set; }

        /// <summary>
        /// 份额
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 出行人编号列表
        /// </summary>
        public List<long> TravelerIdList { get; set; }
       
    }
}
