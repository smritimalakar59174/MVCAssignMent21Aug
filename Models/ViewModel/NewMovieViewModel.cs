using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieCustomerWithAuthMVC_app.Models;

namespace MovieCustomerWithAuthMVC_app.Models.ViewModel
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}