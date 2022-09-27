using InstantInvoice.Models;
namespace InstantInvoice.Services;

public class InvoiceService
{
    public List<LineItem> ConvertListItem(LineItem[] lineItemArray)
    {
        List<LineItem> returnList = new List<LineItem>();

        foreach (LineItem item in lineItemArray)
        {
            if (item.Quantity != 0 && !string.IsNullOrEmpty(item.Description) && item.UnitCost != 0.00)
            {
                returnList.Add(item);
            }
        }

        return returnList;
    }
}