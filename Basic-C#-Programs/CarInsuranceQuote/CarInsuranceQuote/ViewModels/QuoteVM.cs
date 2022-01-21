using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceQuote.ViewModels
{
    
    public class QuoteVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> Total { get; set; }

    }
}