var trans = new TransferTransaction()
{
    Amount = 10,
    FromIBAN = "1",
    ToIBAN = "2",
};

var jsonAdapter = new JsonBankApiAdapter();
jsonAdapter.ExecuteTransaction(trans);

var xmlAdapter = new XmlBankApiAdapter();
xmlAdapter.ExecuteTransaction(trans);

interface IBankApi
{
    bool ExecuteTransaction(TransferTransaction transaction);
}

class JsonBankApiAdapter : IBankApi
{
    private readonly JsonBankApi jsonBankApi;
    public JsonBankApiAdapter()
    {
        jsonBankApi = new();
    }
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        return jsonBankApi.ExecuteTransaction(transaction);
    }
}

class XmlBankApiAdapter : IBankApi
{
    private readonly XMLBankApi xmLBankApi;
    public XmlBankApiAdapter()
    {
        xmLBankApi = new();
    }
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        return xmLBankApi.ExecuteTransaction(transaction);
    }
}

class JsonBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var xml = $$""""
            {
                ""TransferTransaction:"" : ""{{transaction.FromIBAN}}""
                ""ToIBAN:"" : ""{{transaction.ToIBAN}}""
                ""Amount:"" : ""{{transaction.Amount}}""
            }
            """";
        Console.WriteLine(xml);
        return true;
    }
}

class XMLBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var xml = $"""
            <TransferTransaction>
                <FromIBAN>{transaction.FromIBAN}</FromIBAN>
                <ToIBAN>{transaction.ToIBAN}</ToIBAN>
                <Amount>{transaction.Amount}</Amount>
            </TransferTransaction>
            """;
        Console.WriteLine(xml);
        return true;
    }
}

class TransferTransaction
{
    public string FromIBAN { get; set; }
    public string ToIBAN { get; set; }
    public decimal Amount { get; set; }
}