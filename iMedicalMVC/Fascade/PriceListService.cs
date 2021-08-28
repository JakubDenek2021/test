using iMedicalMVC.DAO;
using iMedicalMVC.Models;
using iMedicalMVC.ViewModel.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Fascade
{
    public class PriceListService
    {
        //public List<PriceListViewModel> GetAll()
        //{
        //    var model = new PriceListDao().GetAll();
        //    var result = new List<PriceListViewModel>();
        //    foreach (var item in model)
        //    {
        //        result.Add(new PriceListViewModel()
        //        {

        //            Name = item.Name,
        //            Price = item.Price,
        //            Description = item.Description
        //        });
        //    }
        //    return result;
        //}

        //internal void AddPriceList(CreatePriceListViewModel model)
        //{
        //    Price_list priceList = new Price_list();

        //    priceList.Name = model.Name;
        //    priceList.Price = model.Price;
        //    priceList.Description = model.Description;

        //    new PriceListDao().Save(priceList);
        //}


        //internal void ValidatePriceList(CreatePriceListViewModel model)
        //{

        //}

    }
}