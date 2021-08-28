using iMedicalMVC.Fascade;
using iMedicalMVC.ViewModel.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.Controllers
{
    public class PriceListController : Controller
    {
        //[HttpGet]
        //public ActionResult ShowAll()
        //{
        //    var showAllPriceList = new PriceListService().GetAll();

        //    return View(showAllPriceList);
        //}

        //[HttpGet]
        //public ActionResult AddNew()
        //{
        //    return View();
        //}



        //[HttpPost]
        //public ActionResult AddNew(CreatePriceListViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var priceListService = new PriceListService();
        //        try
        //        {
        //            priceListService.ValidatePriceList(model);
        //            priceListService.AddPriceList(model);

        //            return RedirectToAction("ShowAll", "PriceList");
        //        }
        //        catch (Exception e)
        //        {
        //            ModelState.AddModelError(string.Empty, e.Message);
        //            return View(model);
        //        }
        //    }
        //    else
        //    {
        //        return View(model);
        //    }
        //}
    }

    
}