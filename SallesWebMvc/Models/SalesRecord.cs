using SallesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;

namespace SallesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public  double Amount { get; set; }
        public SaleStatus SaleStatus { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus saleStatus, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            SaleStatus = saleStatus;
            Seller = seller;
        }
    }
}
