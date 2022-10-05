using System.ComponentModel.DataAnnotations;
namespace InstantInvoice.Models;

public class Invoice
{
    [Required]
    public DateTime Date { get; set; } = DateTime.Now;
    [Required]
    [StringLength(4, ErrorMessage = "Invoice Number too long!")]
    public string Number { get; set; } = "0001";
    [Required]
    [StringLength(50, ErrorMessage = "Company Name too long!")]
    public string CompanyName { get; set; }
    [Required]
    [StringLength(75, ErrorMessage = "Address too long!")]
    public string CompanyAddress { get; set; }
    [Required]
    [StringLength(25, ErrorMessage = "City too long!")]
    public string CompanyCity { get; set; }
    [Required]
    [StringLength(20, ErrorMessage = "State too long!")]
    public string CompanyState { get; set; }
    [Required]
    [StringLength(5, MinimumLength = 5, ErrorMessage = "Zip Code needs to be 5 digits long!")]
    public string CompanyZipCode { get; set; }
    [StringLength(50, ErrorMessage = "Website too long!")]
    public string? CompanyWebsite { get; set; }
    [StringLength(50, ErrorMessage = "Email too long!")]
    public string? CompanyEmail { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "Company Name too long!")]
    public string BillingName { get; set; }
    [Required]
    [StringLength(75, ErrorMessage = "Address too long!")]
    public string BillingAddress { get; set; }
    [Required]
    [StringLength(25, ErrorMessage = "City too long!")]
    public string BillingCity { get; set; }
    [Required]
    [StringLength(20, ErrorMessage = "State too long!")]
    public string BillingState { get; set; }
    [Required]
    [StringLength(5, MinimumLength = 5, ErrorMessage = "Zip Code needs to be 5 digits long!")]
    public string BillingZipCode { get; set; }
    [StringLength(50, ErrorMessage = "Company Name too long!")]
    public string? ShippingName { get; set; }
    [StringLength(75, ErrorMessage = "Address too long!")]
    public string? ShippingAddress { get; set; }
    [StringLength(25, ErrorMessage = "City too long!")]
    public string? ShippingCity { get; set; }
    [StringLength(20, ErrorMessage = "State too long!")]
    public string? ShippingState { get; set; }
    [StringLength(5, MinimumLength = 5, ErrorMessage = "Zip Code needs to be 5 digits long!")]
    public string? ShippingZipCode { get; set; }
    public List<LineItem> Items { get; set; }
    public double Subtotal => GetTotal(Items);
    public double Discount { get; set; } = 0.00;
    public double Tax { get; set; }
    public double Total => Subtotal - Discount + Tax;
    [StringLength(350, ErrorMessage = "Notes are too long!")]
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
    [Required]
    public int Quantity { get; set; }
    [Required]
    [StringLength(75, ErrorMessage = "Item Description too long!")]
    public string Description { get; set; }
    [Required]
    public double UnitCost { get; set; }
    public double Total => Quantity * UnitCost;
}