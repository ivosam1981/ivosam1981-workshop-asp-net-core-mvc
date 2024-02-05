using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SallesWebMvc.Models
{
    public class Seller
    {
        public  int Id { get; set; }

        [Required(ErrorMessage ="{0} requerido")]
        [StringLength(60, MinimumLength = 3 , ErrorMessage ="Tamanho do {0} deve ser entre {2} e {1}")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} requerido")]

        [EmailAddress(ErrorMessage ="Entre com um {0} válido")]
        public string Email { get; set; }
        
        [Display(Name ="Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} requerido")]

        public DateTime BirthDate { get; set; }

        [Display(Name="Base Salary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        [Required(ErrorMessage = "{0} requerido")]
        [Range(100, 50000, ErrorMessage ="{0} deve ser entre {1} e {2}")]

        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public int DepartamentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemmveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date <= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }


    }
}
