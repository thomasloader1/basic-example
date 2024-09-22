using ParcialPracticoWeb3.Entity;
using System.ComponentModel;


namespace ParcialPracticoWeb3.Logic;

public class VentaLogic
{
    private static List<Venta> _ventaList = new List<Venta>();
    public List<Venta> Resultados()
    {

        return _ventaList.OrderBy(x => x.IdVenta).ToList();
        
    }

    public static void AgregarVenta(Venta venta)
    {
        venta.IdVenta = _ventaList.Count == 0 ? 1 : _ventaList.Max(x => x.IdVenta) + 1;
        _ventaList.Add(venta);

    }

   public static List<Venta> calcular()
   
}
