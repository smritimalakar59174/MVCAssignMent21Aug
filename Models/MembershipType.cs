using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieCustomerWithAuthMVC_app.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        public short SignUpFees { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}