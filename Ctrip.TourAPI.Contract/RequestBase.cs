// -----------------------------------------------------------------------
// <copyright file="RequestBase.cs" company="Microsoft">
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
    /// 请求基本类型
    /// </summary>
    public class RequestBase
    {
        private RequestHeaderType requestHeader = new RequestHeaderType( );

        /// <summary>
        /// 请求头类型
        /// </summary>
        public RequestHeaderType RequestHeader { get { return requestHeader; } set { this.requestHeader = value; } }
    }
}
