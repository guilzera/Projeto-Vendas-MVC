using System.Collections.Generic;

namespace SalesWebMVC.Models
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; } 
    }
}
