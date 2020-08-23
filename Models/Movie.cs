using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieCustomerWithAuthMVC_app.Models
{
    public class Movie
    {
        public int Id { get; set; }
       [Required]
        public string MovieName { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}