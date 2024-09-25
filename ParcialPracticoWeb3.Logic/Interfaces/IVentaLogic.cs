using ParcialPracticoWeb3.Entity;

namespace ParcialPracticoWeb3.Logic.Interfaces;

public interface IVentaLogic
{
    void SaveVenta(Venta v);
    List<Venta> Results();
}
