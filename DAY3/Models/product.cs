namespace DAY3.Model{
public class  Product
{
    public Product(int itemID, string itemName, string itemDescription, string itemCode, int quantity, string createDate)
    {
    this.ItemID = itemID;
    this.ItemName = itemName;
    this.ItemDescription = itemDescription;
    this.ItemCode = itemCode;
    this.Quantity = quantity;
    this.CreateDate = createDate; 
    }

    public int? ItemID {get; set;}
    public string? ItemName {get; set;}
    public string? ItemDescription {get; set;}
    public string? ItemCode {get; set;}
    public int? Quantity{get; set;}
    public string? CreateDate{get; set;}
  }
}