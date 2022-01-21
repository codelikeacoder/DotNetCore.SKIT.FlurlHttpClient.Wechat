﻿using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant-service/complaints-v2 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class QueryMerchantServiceComplaintsResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Complaint
            {
                public static class Types
                {
                    public class ComplaintOrder : GetMerchantServiceComplaintByComplaintIdResponse.Types.ComplaintOrder
                    {
                    }

                    public class ComplaintMedia : GetMerchantServiceComplaintByComplaintIdResponse.Types.ComplaintMedia
                    {
                    }
                }

                /// <summary>
                /// 获取或设置投诉单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaint_id")]
                [System.Text.Json.Serialization.JsonPropertyName("complaint_id")]
                public string ComplaintId { get; set; } = default!;

                /// <summary>
                /// 获取或设置门店 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaint_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("complaint_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset ComplaintTime { get; set; }

                /// <summary>
                /// 获取或设置投诉详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaint_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("complaint_detail")]
                public string ComplaintDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置投诉单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaint_state")]
                [System.Text.Json.Serialization.JsonPropertyName("complaint_state")]
                public string ComplaintState { get; set; } = default!;

                /// <summary>
                /// 获取或设置投诉人联系方式（需使用商户私钥解密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_phone")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
                public string? PayerPhone { get; set; }

                /// <summary>
                /// 获取或设置投诉人 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_openid")]
                public string? PayerOpenId { get; set; }

                /// <summary>
                /// 获取或设置投诉单关联订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaint_order_info")]
                [System.Text.Json.Serialization.JsonPropertyName("complaint_order_info")]
                public Types.ComplaintOrder[] ComplaintOrderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置投诉资料列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaint_media_list")]
                [System.Text.Json.Serialization.JsonPropertyName("complaint_media_list")]
                public Types.ComplaintMedia[] ComplaintMediaList { get; set; } = default!;

                /// <summary>
                /// 获取或设置问题描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("problem_description")]
                [System.Text.Json.Serialization.JsonPropertyName("problem_description")]
                public string ProblemDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置投诉单是否已全额退款。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaint_full_refunded")]
                [System.Text.Json.Serialization.JsonPropertyName("complaint_full_refunded")]
                public bool IsFullRefunded { get; set; }

                /// <summary>
                /// 获取或设置是否有待回复的用户留言。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("incoming_user_response")]
                [System.Text.Json.Serialization.JsonPropertyName("incoming_user_response")]
                public bool HasIncomingUserResponse { get; set; }

                /// <summary>
                /// 获取或设置用户投诉次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_complaint_times")]
                [System.Text.Json.Serialization.JsonPropertyName("user_complaint_times")]
                public int UserComplaintTimes { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户投诉列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Complaint[] ComplaintList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置投诉总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }
    }
}
