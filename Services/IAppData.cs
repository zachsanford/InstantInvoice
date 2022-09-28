using InstantInvoice.Models;
namespace InstantInvoice.Services;

internal interface IAppData
{
    public Invoice UserInvoiceData { get; set; }
}