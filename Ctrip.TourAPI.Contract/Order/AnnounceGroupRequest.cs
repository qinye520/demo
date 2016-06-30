using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ctrip.TourAPI
{
    /// <summary>
    /// 宣布成团请求
    /// </summary>
    public class AnnounceGroupRequest : RequestBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public AnnounceGroupRequest()
        {
            this.AnnounceGroupList = new List<AnnounceGroup>();
        }

        /// <summary>
        /// 供应商产品编号
        /// </summary>
        public string VendorProductCode { get; set; }

        /// <summary>
        /// 宣布成团列表
        /// </summary>
        public List<AnnounceGroup> AnnounceGroupList { get; set; }
        
    }
}
