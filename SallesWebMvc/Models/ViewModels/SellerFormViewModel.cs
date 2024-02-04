using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace SallesWebMvc.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Departament> Departaments { get; set; }
    }
}
