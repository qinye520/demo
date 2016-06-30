
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctrip.TourAPI
{
    /// <summary>
    /// 携程供应商平台开放接口
    /// </summary>
    public class CtripOpenAPI
    {
        /// <summary>
        /// 私有化构造方法
        /// </summary>
        private CtripOpenAPI() { }

        /// <summary>
        /// 静态初始化
        /// </summary>
        public static readonly CtripOpenAPI Instance = new CtripOpenAPI();


        /// <summary>
        /// 订单行为获取请求接口
        /// </summary>
        /// <param name="request">订单行为获取请求请求</param>
        /// <returns>订单行为获取请求响应</returns>
        public GetTodoOrderListResponse GetTodoOrderList(GetTodoOrderListRequest request)
        {
            return SDKCore.PostMessage<GetTodoOrderListResponse, GetTodoOrderListRequest>(request, "GetTodoOrderList");
        }

        /// <summary>
        /// 确认新订单请求接口
        /// </summary>
        /// <param name="request">确认新订单请求请求</param>
        /// <returns>确认新订单请求响应</returns>
        public ConfirmOrderResponse ConfirmOrder(ConfirmOrderRequest request)
        {
            return SDKCore.PostMessage<ConfirmOrderResponse, ConfirmOrderRequest>(request, "ConfirmOrder");
        }

        /// <summary>
        /// 拒绝新订单接口
        /// </summary>
        /// <param name="request">拒绝新订单请求</param>
        /// <returns>拒绝新订单响应</returns>
        public RejectOrderResponse RejectOrder(RejectOrderRequest request)
        {
            return SDKCore.PostMessage<RejectOrderResponse, RejectOrderRequest>(request, "RejectOrder");
        }

        /// <summary>
        /// 添加产品基本信息接口
        /// </summary>
        /// <param name="request">添加产品基本信息请求</param>
        /// <returns>添加产品基本信息响应</returns>
        public AddProductInfoResponse AddProductInfo(AddProductInfoRequest request)
        {
            return SDKCore.PostMessage<AddProductInfoResponse, AddProductInfoRequest>(request, "AddProductInfo");
        }

        /// <summary>
        /// 更新产品基本信息接口
        /// </summary>
        /// <param name="request">更新产品基本信息请求</param>
        /// <returns>更新产品基本信息响应</returns>
        public UpdateProductInfoResponse UpdateProductInfo(UpdateProductInfoRequest request)
        {
            return SDKCore.PostMessage<UpdateProductInfoResponse, UpdateProductInfoRequest>(request, "UpdateProductInfo");
        }

        /// <summary>
        /// 保存升级套餐接口
        /// </summary>
        /// <param name="request">保存升级套餐请求</param>
        /// <returns>保存升级套餐响应</returns>
        public UpdateProductUpgradePackageResponse UpdateProductUpgradePackage(UpdateProductUpgradePackageRequest request)
        {
            return SDKCore.PostMessage<UpdateProductUpgradePackageResponse, UpdateProductUpgradePackageRequest>(request, "UpdateProductUpgradePackage");
        }

        /// <summary>
        /// 保存附加服务接口
        /// </summary>
        /// <param name="request">保存附加服务请求</param>
        /// <returns>保存附加服务响应</returns>
        public UpdateProductOptionResponse UpdateProductOption(UpdateProductOptionRequest request)
        {
            return SDKCore.PostMessage<UpdateProductOptionResponse, UpdateProductOptionRequest>(request, "UpdateProductOption");
        }

        /// <summary>
        /// 更新产品价格接口
        /// </summary>
        /// <param name="request">更新产品价格请求</param>
        /// <returns>更新产品价格响应</returns>
        public UpdateProductPriceResponse UpdateProductPrice(UpdateProductPriceRequest request)
        {
            return SDKCore.PostMessage<UpdateProductPriceResponse, UpdateProductPriceRequest>(request, "UpdateProductPrice");
        }

        /// <summary>
        /// 更新产品库存接口
        /// </summary>
        /// <param name="request">更新产品库存请求</param>
        /// <returns>更新产品库存响应</returns>
        public UpdateProductInventoryResponse UpdateProductInventory(UpdateProductInventoryRequest request)
        {
            return SDKCore.PostMessage<UpdateProductInventoryResponse, UpdateProductInventoryRequest>(request, "UpdateProductInventory");
        }

        /// <summary>
        /// 打开产品班期接口
        /// </summary>
        /// <param name="request">打开产品班期请求</param>
        /// <returns>打开产品班期响应</returns>
        public BeginSellingResponse BeginSelling(BeginSellingRequest request)
        {
            return SDKCore.PostMessage<BeginSellingResponse, BeginSellingRequest>(request, "BeginSelling");
        }

        /// <summary>
        /// 关闭产品班期接口
        /// </summary>
        /// <param name="request">关闭产品班期请求</param>
        /// <returns>关闭产品班期响应</returns>
        public StopSellingResponse StopSelling(StopSellingRequest request)
        {
            return SDKCore.PostMessage<StopSellingResponse, StopSellingRequest>(request, "StopSelling");
        }

        /// <summary>
        /// 获得产品审核信息接口
        /// </summary>
        /// <param name="request">获得产品审核信息请求</param>
        /// <returns>获得产品审核信息响应</returns>
        public GetTodoRejectProductListResponse GetTodoRejectProductList(GetTodoRejectProductListRequest request)
        {
            return SDKCore.PostMessage<GetTodoRejectProductListResponse, GetTodoRejectProductListRequest>(request, "GetTodoRejectProductList");
        }

        /// <summary>
        /// 宣布成团接口
        /// </summary>
        /// <param name="request">宣布成团请求</param>
        /// <returns>宣布成团响应</returns>
        public AnnounceGroupResponse AnnounceGroup(AnnounceGroupRequest request)
        {
            return SDKCore.PostMessage<AnnounceGroupResponse, AnnounceGroupRequest>(request, "AnnounceGroup");
        }


    }
}
