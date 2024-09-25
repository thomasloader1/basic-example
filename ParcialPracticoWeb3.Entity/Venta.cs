namespace ParcialPracticoWeb3.Entity;


public class Venta
{
    public int SaleId { get; set; }
    public string? Client { get; set; }
    public int SaleQuantity { get; set; }
    public decimal UnitPrice { get; set; }

    public decimal TotalSale => UnitPrice * SaleQuantity;

}
