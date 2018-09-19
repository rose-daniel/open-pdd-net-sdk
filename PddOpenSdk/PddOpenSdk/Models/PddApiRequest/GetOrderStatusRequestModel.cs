using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class GetOrderStatusRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.order.status.get
        /// </summary>
        [JsonProperty("type")]
        public object Type { get; set; }
        /// <summary>
        /// 20150909-452750051,20150909-452750134 用逗号分开
        /// </summary>
        [JsonProperty("order_sns")]
        public object OrderSns { get; set; }

    }
}