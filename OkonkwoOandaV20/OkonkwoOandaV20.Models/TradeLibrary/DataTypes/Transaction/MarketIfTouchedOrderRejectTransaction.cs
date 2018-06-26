﻿namespace OkonkwoOandaV20.TradeLibrary.DataTypes.Transaction
{
    public class MarketIfTouchedOrderRejectTransaction : EntryOrderRejectTransaction
    {
        public decimal price { get; set; }
        public decimal? priceBound { get; set; }
        public string gtdTime { get; set; }
        public string triggerCondition { get; set; }
        public long? intendedReplacesOrderID { get; set; }
        public long? cancellingTransactionID { get; set; }
    }
}
