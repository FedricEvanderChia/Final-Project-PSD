using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Factory
{
    public class MedicineFactory
    {
        public static Medicine CreateMedicine(string name, string description, int stock, int price)
        {
            Medicine medicine = new Medicine
            {
                Name = name,
                Description = description,
                Stock = stock,
                Price = price
            };

            return medicine;
        }
    }
}