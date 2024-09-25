using ParcialPracticoWeb3.Entity;
using System.Reflection;

namespace ParcialPracticoWeb3.Web.Models;

public class VentasViewModel
{
    public int SaleId {  get; set; }
    public string Client {  get; set; }
    public int SaleQuantity {  get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalSale { get; set; }


    public static VentasViewModel ParseFromModel(Venta v)
    {
        return new VentasViewModel
        {
            SaleId = v.SaleId,
            Client = v.Client,
            SaleQuantity = v.SaleQuantity,
            UnitPrice = v.UnitPrice,
            TotalSale = v.TotalSale
        };
    }

    public static Venta ParseFromViewModel(VentasViewModel vvm)
    {
        return new Venta {
                SaleId = vvm.SaleId,
                Client = vvm.Client,
                SaleQuantity = vvm.SaleQuantity,
                UnitPrice = vvm.UnitPrice
            };
    }

    public static List<VentasViewModel> FromVenta(List<Venta> sales)
    {
        return sales.Select(s => ParseFromModel(s)).ToList();
    }

}
