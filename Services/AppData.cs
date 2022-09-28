using InstantInvoice.Models;
namespace InstantInvoice.Services;

public class AppData : IAppData
{
    public Invoice UserInvoiceData { get; set; }
}