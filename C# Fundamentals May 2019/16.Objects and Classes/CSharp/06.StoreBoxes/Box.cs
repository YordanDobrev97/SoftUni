
public class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public double ItemPrice { get; set; }

    public Box(string serialNumber, Item item, int itemQuantity, double itemPrice)
    {
        this.SerialNumber = serialNumber;
        this.Item = item;
        this.ItemQuantity = itemQuantity;
        this.ItemPrice = itemPrice;
    }
}

