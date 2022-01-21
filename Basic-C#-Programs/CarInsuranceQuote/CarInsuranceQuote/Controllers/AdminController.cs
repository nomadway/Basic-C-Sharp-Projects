using CarInsuranceQuote.Models;
using CarInsuranceQuote.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceQuote.Controllers
{
    public class AdminController : Controller
    {
    
        public ActionResult Index()
        {
            using (Car_Insurance_QuoteEntities db = new Car_Insurance_QuoteEntities())
            {
                List<Quote> quotes = db.Quotes.ToList(); 

                var quoteVMs = new List<QuoteVM>(); 
               
                foreach (var quote in quotes)
                {
                    QuoteVM quoteVM = new QuoteVM();
                    quoteVM.FirstName = quote.FirstName;
                    quoteVM.LastName = quote.LastName;
                    quoteVM.Email = quote.Email;
                    quoteVM.Total = quote.Total;

                    quoteVMs.Add(quoteVM); 
                }

                return View(quoteVMs);
            }
        }
    }
}