using System;

namespace api.models
{
    public class Stock
    {
        public int Id
        {
            get; set;
        }
        public string Symbol { get; set; } = string.Empty;
        public Stock()
        {
            System.Console.WriteLine(string.Empty);

        }

    }
}