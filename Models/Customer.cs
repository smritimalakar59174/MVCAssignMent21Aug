using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieCustomerWithAuthMVC_app.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        public bool IsSubscribe { get; set; }
        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }

        public DateTime DOB { get; set; }

    }
}