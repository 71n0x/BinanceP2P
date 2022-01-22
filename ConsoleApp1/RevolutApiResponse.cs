namespace BinanceBestExchange;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
public class Sender
{
    public int amount { get; set; }
    public string currency { get; set; }
}

public class Recipient
{
    public int amount { get; set; }
    public string currency { get; set; }
}

public class Rate
{
    public string from { get; set; }
    public string to { get; set; }
    public double rate { get; set; }
    public long timestamp { get; set; }
}

public class Fx
{
    public int amount { get; set; }
    public string currency { get; set; }
}

public class Amount2
{
    public int amount { get; set; }
    public string currency { get; set; }
    public string percentage { get; set; }
}

public class FxWeekend
{
    public double amount { get; set; }
}

public class Total
{
    public int amount { get; set; }
    public string currency { get; set; }
}

public class Cost
{
    public int amount { get; set; }
    public string currency { get; set; }
}

public class Fees
{
    public Fx fx { get; set; }
    public FxWeekend fxWeekend { get; set; }
    public Total total { get; set; }
    public Cost cost { get; set; }
}

public class Plan
{
    public string id { get; set; }
    public string name { get; set; }
    public Fees fees { get; set; }
    public string tooltipLong { get; set; }
    public string tooltipShort { get; set; }
}

public class RevolutApiResponse
{
    public Sender sender { get; set; }
    public Recipient recipient { get; set; }
    public Rate rate { get; set; }
    public string fxTooltip { get; set; }
    public List<Plan> plans { get; set; }
}