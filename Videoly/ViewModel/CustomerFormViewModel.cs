using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videoly.Models;

namespace Videoly.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customers Customers { get; set; }
    }
}