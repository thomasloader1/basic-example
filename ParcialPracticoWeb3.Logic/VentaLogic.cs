using ParcialPracticoWeb3.Entity;
using ParcialPracticoWeb3.Logic.Interfaces;
using System.ComponentModel;


namespace ParcialPracticoWeb3.Logic;

public class VentaLogic: IVentaLogic
{
    private List<Venta> _ventaList = new List<Venta>();

    public void SaveVenta(Venta v)
    {
        v.SaleId = _ventaList.Count == 0 ? 1 : _ventaList.Max(x => x.SaleId) + 1;
        _ventaList.Add(v);
    }

    public List<Venta> Results()
    {
        return _ventaList.OrderBy(x => x.SaleId).ToList();
    }
}
