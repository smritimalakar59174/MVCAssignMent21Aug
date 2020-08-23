using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieCustomerWithAuthMVC_app;

namespace MovieCustomerWithAuthMVC_app.Models.ViewModel
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}