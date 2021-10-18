using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller
{
    public class MedicineController
    {
        public static List<Medicine> Get5RandomMedicines()
        {
            return MedicineHandler.Get5RandomMedicines();
        }

        public static List<Medicine> GetAllMedicines()
        {
            return MedicineHandler.GetAllMedicines();
        }

        public static List<Medicine> GetSearchedMedicines(string search)
        {
            return MedicineHandler.GetSearchedMedicines(search);
        }

        public static Medicine GetMedicineById(int medicineId)
        {
            return MedicineHandler.GetMedicineById(medicineId);
        }

        public static string InsertMedicine(string name, string desc, string stock, string price)
        {
            int stockInt, priceInt;

            if (name.Length <= 0)
            {
                return "Name cannot be empty";
            }

            if (desc.Length <= 0)
            {
                return "Description cannot be empty";
            }
            else if (desc.Length <= 10)
            {
                return "Description must be longer than 10 characters";
            }

            if (stock.Length <= 0)
            {
                return "Stock cannot be empty";
            }
            else if (Int32.TryParse(stock, out stockInt))
            {
                if (stockInt <= 0)
                {
                    return "Stock must be more than 0";
                }
            }
            else if (!Int32.TryParse(stock, out stockInt))
            {
                return "Stock must be numeric";
            }

            if (price.Length <= 0)
            {
                return "Price cannot be empty";
            }
            else if (Int32.TryParse(price, out priceInt))
            {
                if (priceInt <= 0)
                {
                    return "Price must be more than 0";
                }
            }
            else if (!Int32.TryParse(price, out priceInt))
            {
                return "Price must be numeric";
            }

            MedicineHandler.InsertMedicine(name, desc, stockInt, priceInt);

            return "";
        }
        public static string UpdateMedicine(int medicineId, string name, string desc, string stock, string price)
        {
            int stockInt, priceInt;

            if(name.Length <= 0)
            {
                return "Name cannot be empty";
            }

            if(desc.Length <= 0)
            {
                return "Description cannot be empty";
            }
            else if(desc.Length <= 10)
            {
                return "Description must be longer than 10 characters";
            }

            if(stock.Length <= 0)
            {
                return "Stock cannot be empty";
            }
            else if(Int32.TryParse(stock, out stockInt))
            {
                if(stockInt <= 0)
                {
                    return "Stock must be more than 0";
                }
            }
            else if(!Int32.TryParse(stock, out stockInt))
            {
                return "Stock must be numeric";
            }

            if (price.Length <= 0)
            {
                return "Price cannot be empty";
            }
            else if (Int32.TryParse(price, out priceInt))
            {
                if (priceInt <= 0)
                {
                    return "Price must be more than 0";
                }
            }
            else if (!Int32.TryParse(price, out priceInt))
            {
                return "Price must be numeric";
            }

            MedicineHandler.UpdateMedicine(medicineId, name, desc, stockInt, priceInt);

            return "";
        }

        public static void RemoveMedicine(int medicineId)
        {
            MedicineHandler.RemoveMedicine(medicineId);
        }
    }
}