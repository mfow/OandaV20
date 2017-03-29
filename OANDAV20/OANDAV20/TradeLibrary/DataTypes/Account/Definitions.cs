﻿/// <summary>
/// http://developer.oanda.com/rest-live-v20/account-df/
/// </summary>
namespace OANDAV20.REST20.TradeLibrary.DataTypes.Account
{
   public class AccountFinancingMode
   {
      public const string Daily = "DAILY";
      public const string NoFinancing = "NO_FINANCING";
      public const string SecondBySecond = "SECOND_BY_SECOND";
   }

   public class PositionAggregationMode
   {
      public const string AbsoluteSum = "ABSOLUTE_SUM";
      public const string MaximalSide = "MAXIMAL_SIDE";
      public const string NetSum = "NET_SUM";
   }
}
