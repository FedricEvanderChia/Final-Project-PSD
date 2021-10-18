using CentuDY.Factory;
using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Handler
{
    public class MedicineHandler
    {
        public static List<Medicine> Get5RandomMedicines()
        {
            return MedicineRepository.Get5RandomMedicines();
        }

        public static List<Medicine> GetAllMedicines()
        {
            return MedicineRepository.GetAllMedicines();
        }

        public static List<Medicine> GetSearchedMedicines(string search)
        {
            return MedicineRepository.GetSearchedMedicines(search);
        }

        public static Medicine GetMedicineById(int medicineId)
        {
            return MedicineRepository.GetMedicineById(medicineId);
        }

        public static void InsertMedicine(string name, string desc, int stock, int price)
        {
            Medicine medicine = MedicineFactory.CreateMedicine(name, desc, stock, price);
            MedicineRepository.InsertMedicine(medicine);
        }

        public static void UpdateMedicine(int medicineId, string name, string desc, int stock, int price)
        {
            MedicineRepository.UpdateMedicine(medicineId, name, desc, stock, price);
        }

        public static void RemoveMedicine(int medicineId)
        {
            MedicineRepository.RemoveMedicine(medicineId);
        }
    }
}