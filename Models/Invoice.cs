namespace InstantInvoice.Models;

public class Invoice
{
    public DateTime Date { get; set; } = DateTime.Now;
    public string Number { get; set; } = "0001";
    public string CompanyName { get; set; }
    public string CompanyAddress { get; set; }
    public string CompanyCity { get; set; }
    public string CompanyState { get; set; }
    public string CompanyZipCode { get; set; }
    public string? CompanyWebsite { get; set; }
    public string? CompanyEmail { get; set; }
    public string BillingName { get; set; }
    public string BillingAddress { get; set; }
    public string BillingCity { get; set; }
    public string BillingState { get; set; }
    public string BillingZipCode { get; set; }
    public string? ShippingName { get; set; }
    public string? ShippingAddress { get; set; }
    public string? ShippingCity { get; set; }
    public string? ShippingState { get; set; }
    public string? ShippingZipCode { get; set; }
    public List<LineItem> Items { get; set; }
    public double Subtotal => GetTotal(Items);
    public double Discount { get; set; } = 0.00;
    public double Tax { get; set; }
    public double Total => Subtotal - Discount + Tax;
    public string? Notes { get; set; }

    private double GetTotal(List<LineItem> _items)
    {
        double _temp = 0.00;
        foreach (LineItem _item in _items)
        {
            _temp += _item.Total;
        }
        return _temp;
    }
}

public class LineItem
{
    public int Quantity { get; set; }
    public string Description { get; set; }
    public double UnitCost { get; set; }
    public double Total => Quantity * UnitCost;
}