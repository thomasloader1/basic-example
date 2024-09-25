using Microsoft.AspNetCore.Mvc;
using ParcialPracticoWeb3.Logic.Interfaces;
using ParcialPracticoWeb3.Web.Models;

namespace ParcialPracticoWeb3.Web.Controllers;

public class VentasController : Controller
{
    private IVentaLogic _vlogic;
    public VentasController(IVentaLogic vlogic)
    {
        _vlogic = vlogic;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult RegistrarVenta() {

        return View();

    }

    [HttpPost]
    public IActionResult RegistrarVenta(VentasViewModel vm)
    {
        if (!ModelState.IsValid)
        {
            return View(vm);
        }

        _vlogic.SaveVenta(VentasViewModel.ParseFromViewModel(vm));

        return RedirectToAction("Resultados");

    }


    [HttpGet]
    public IActionResult Resultados()
    {
        var sales = _vlogic.Results();
        return View(VentasViewModel.FromVenta(sales));
    }
  
}
