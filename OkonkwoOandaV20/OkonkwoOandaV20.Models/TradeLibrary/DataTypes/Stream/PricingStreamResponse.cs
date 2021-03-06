﻿using Newtonsoft.Json;
using OkonkwoOandaV20.Framework.JsonConverters;
using OkonkwoOandaV20.TradeLibrary.DataTypes.Pricing;

namespace OkonkwoOandaV20.TradeLibrary.DataTypes.Stream
{
    /// <summary>
    /// Events are authorized transactions posted to the subject account.
    /// For more information, visit: http://developer.oanda.com/rest-live-v20/transaction-ep/
    /// </summary>
    [JsonConverter(typeof(PricingStreamResponseConverter))]
    public class PricingStreamResponse : IHeartbeat
    {
        public PricingHeartbeat heartbeat { get; set; }
        public Price price { get; set; }

        public bool IsHeartbeat()
        {
            return (heartbeat != null);
        }
    }
}
