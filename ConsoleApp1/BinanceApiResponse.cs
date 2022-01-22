namespace BinanceBestExchange;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class TradeMethod
    {
        public object payId { get; set; }
        public string payMethodId { get; set; }
        public string payType { get; set; }
        public object payAccount { get; set; }
        public object payBank { get; set; }
        public object paySubBank { get; set; }
        public string identifier { get; set; }
        public string iconUrlColor { get; set; }
        public string tradeMethodName { get; set; }
        public string tradeMethodShortName { get; set; }
        public string tradeMethodBgColor { get; set; }
    }

    public class Adv
    {
        public string advNo { get; set; }
        public string classify { get; set; }
        public string tradeType { get; set; }
        public string asset { get; set; }
        public string fiatUnit { get; set; }
        public object advStatus { get; set; }
        public object priceType { get; set; }
        public object priceFloatingRatio { get; set; }
        public object rateFloatingRatio { get; set; }
        public object currencyRate { get; set; }
        public string price { get; set; }
        public string initAmount { get; set; }
        public string surplusAmount { get; set; }
        public string amountAfterEditing { get; set; }
        public string maxSingleTransAmount { get; set; }
        public string minSingleTransAmount { get; set; }
        public object buyerKycLimit { get; set; }
        public object buyerRegDaysLimit { get; set; }
        public object buyerBtcPositionLimit { get; set; }
        public object remarks { get; set; }
        public string autoReplyMsg { get; set; }
        public int payTimeLimit { get; set; }
        public List<TradeMethod> tradeMethods { get; set; }
        public object userTradeCountFilterTime { get; set; }
        public object userBuyTradeCountMin { get; set; }
        public object userBuyTradeCountMax { get; set; }
        public object userSellTradeCountMin { get; set; }
        public object userSellTradeCountMax { get; set; }
        public object userAllTradeCountMin { get; set; }
        public object userAllTradeCountMax { get; set; }
        public object userTradeCompleteRateFilterTime { get; set; }
        public object userTradeCompleteCountMin { get; set; }
        public object userTradeCompleteRateMin { get; set; }
        public object userTradeVolumeFilterTime { get; set; }
        public object userTradeType { get; set; }
        public object userTradeVolumeMin { get; set; }
        public object userTradeVolumeMax { get; set; }
        public object userTradeVolumeAsset { get; set; }
        public object createTime { get; set; }
        public object advUpdateTime { get; set; }
        public object fiatVo { get; set; }
        public object assetVo { get; set; }
        public object advVisibleRet { get; set; }
        public object assetLogo { get; set; }
        public int assetScale { get; set; }
        public int fiatScale { get; set; }
        public int priceScale { get; set; }
        public string fiatSymbol { get; set; }
        public bool isTradable { get; set; }
        public string dynamicMaxSingleTransAmount { get; set; }
        public string minSingleTransQuantity { get; set; }
        public string maxSingleTransQuantity { get; set; }
        public string dynamicMaxSingleTransQuantity { get; set; }
        public string tradableQuantity { get; set; }
        public string commissionRate { get; set; }
        public List<object> tradeMethodCommissionRates { get; set; }
        public object launchCountry { get; set; }
    }

    public class Advertiser
    {
        public string userNo { get; set; }
        public object realName { get; set; }
        public string nickName { get; set; }
        public object margin { get; set; }
        public object marginUnit { get; set; }
        public object orderCount { get; set; }
        public int monthOrderCount { get; set; }
        public double monthFinishRate { get; set; }
        public int advConfirmTime { get; set; }
        public object email { get; set; }
        public object registrationTime { get; set; }
        public object mobile { get; set; }
        public string userType { get; set; }
        public List<object> tagIconUrls { get; set; }
        public int userGrade { get; set; }
        public string userIdentity { get; set; }
        public object proMerchant { get; set; }
    }

    public class Datum
    {
        public Adv adv { get; set; }
        public Advertiser advertiser { get; set; }
    }

    public class BinanceApiResponse
    {
        public string code { get; set; }
        public object message { get; set; }
        public object messageDetail { get; set; }
        public List<Datum> data { get; set; }
        public int total { get; set; }
        public bool success { get; set; }
    }

