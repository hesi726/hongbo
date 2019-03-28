namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanCrmCustomerPointsChangelogGetResult : APIResult
    {

        /// <summary>
        /// 记录条数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_results")]//) private String totalResults;
        private string totalResults;
        /// <summary>
        /// 积分数值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_points")]//) private String totalPoints;
        private string totalPoints;

        /// <summary>
        /// 记录描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("details")]//) private CrmPointUserChangeLog[] details;
        private CrmPointUserChangeLog[] details;

        public virtual string TotalResults
        {
            set
            {
                this.totalResults = value;
            }
            get
            {
                return this.totalResults;
            }
        }

        public virtual string TotalPoints
        {
            set
            {
                this.totalPoints = value;
            }
            get
            {
                return this.totalPoints;
            }
        }

        public virtual CrmPointUserChangeLog[] Details
        {
            set
            {
                this.details = value;
            }
            get
            {
                return this.details;
            }
        }


        public class CrmPointUserChangeLog
        {

            /// <summary>
            /// 积分值（负数为扣积分）
            /// </summary>
            [Newtonsoft.Json.JsonProperty("amount")]//) private String amount;
            internal string amount;

            /// <summary>
            /// 操作之后的最新积分数值
            /// </summary>
            [Newtonsoft.Json.JsonProperty("total")]//) private String total;
            internal string total;


            /// <summary>
            /// 接口调用的附言（附加后缀表示第三方应用操作）
            /// </summary>
            [Newtonsoft.Json.JsonProperty("description")]//) private String description;
            internal string description;


            /// <summary>
            /// 创建时间
            /// </summary>
            [Newtonsoft.Json.JsonProperty("created_time")]//) private String createdTime;
            internal string createdTime;

            public virtual string Amount
            {
                set
                {
                    this.amount = value;
                }
                get
                {
                    return this.amount;
                }
            }


            public virtual string Total
            {
                set
                {
                    this.total = value;
                }
                get
                {
                    return this.total;
                }
            }


            public virtual string Description
            {
                set
                {
                    this.description = value;
                }
                get
                {
                    return this.description;
                }
            }


            public virtual string CreatedTime
            {
                set
                {
                    this.createdTime = value;
                }
                get
                {
                    return this.createdTime;
                }
            }


        }


    }
}