﻿namespace OkonkwoOandaV20.TradeLibrary.DataTypes.Transaction
{
    public class ClientConfigureTransaction : Transaction
    {
        public string alias { get; set; }
        public decimal marginRate { get; set; }
    }
}