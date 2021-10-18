using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Repository
{
    public class MedicineRepository
    {
        private static CentuDY_dbEntities db = new CentuDY_dbEntities();
        public static List<Medicine> Get5RandomMedicines()
        {
            int totalMedicines = (from x in db.Medicines select x).ToList().Count;
            int min = (from x in db.Medicines select x).FirstOrDefault().MedicineId;
            Random rand = new Random();

            List<Medicine> medicines = new List<Medicine>();

            for (int i=0; i<5; i++)
            {
                int randId = rand.Next(min, totalMedicines);
                Medicine medicine = (from x in db.Medicines 
                                     where x.MedicineId == randId 
                                     select x).FirstOrDefault();
                medicines.Add(medicine);
            }

            return medicines;
        }

        public static List<Medicine> GetAllMedicines()
        {
            return (from x in db.Medicines select x).ToList();
        }

        public static List<Medicine> GetSearchedMedicines(string search)
        {
            return (from x in db.Medicines 
                    where x.Name.Contains(search) 
                    select x).ToList();
        }

        public static Medicine GetMedicineById(int medicineId)
        {
            return (from x in db.Medicines 
                    where x.MedicineId == medicineId 
                    select x).FirstOrDefault();
        }

        public static void InsertMedicine(Medicine medicine)
        {
            db.Medicines.Add(medicine);
            db.SaveChanges();
        }

        public static void UpdateMedicine(int medicineId, string name, string desc, int stock, int price)
        {
            Medicine medicine = (from x in db.Medicines 
                                 where x.MedicineId == medicineId 
                                 select x).FirstOrDefault();

            if(medicine != null)
            {
                medicine.Name = name;
                medicine.Description = desc;
                medicine.Stock = stock;
                medicine.Price = price;

                db.SaveChanges();
            }
        }

        public static void RemoveMedicine(int medicineId)
        {
            Medicine medicine = (from x in db.Medicines
                                 where x.MedicineId == medicineId
                                 select x).FirstOrDefault();

            if(medicine != null)
            {
                db.Medicines.Remove(medicine);
                db.SaveChanges();
            }
        }
    }
}