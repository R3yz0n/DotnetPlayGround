using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.models
{
    public class Stock
    {
        public int Id
        {
            get; set;
        }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        // [Column(TypeName = "decimal(18, 2)")]

        public decimal Purchase { get; set; }
        // [Column(TypeName = "decimal(18, 2)")]



        // public Stock()
        // {
        //     System.Console.WriteLine(string.Empty);

        // }

    }

}