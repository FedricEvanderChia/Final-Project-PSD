using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Repository
{
    public class CartRepository
    {
        private static CentuDY_dbEntities db = new CentuDY_dbEntities();

        public static bool AddtoCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();

            return true;
        }

        public static Cart GetExistingItem(int userId, int medicineId)
        {
            return (from x in db.Carts
                    where x.UserId == userId && x.MedicineId == medicineId
                    select x).FirstOrDefault();
        }

        public static List<Cart> GetAllCartItemsByUserId(int userId)
        {
            return (from x in db.Carts 
                    where x.UserId == userId
                    select x).ToList();
        }

        public static void UpdateCartItem(int userId, int medicineId, int quantity)
        {
            Cart cart = (from x in db.Carts
                         where x.UserId == userId && x.MedicineId == medicineId
                         select x).FirstOrDefault();

            if(cart != null)
            {
                cart.Quantity += quantity;

                db.SaveChanges();
            }
        }

        public static void RemoveCartItem(int userId, int medicineId)
        {
            Cart cart = (from x in db.Carts
                         where x.UserId == userId && x.MedicineId == medicineId
                         select x).FirstOrDefault();

            db.Carts.Remove(cart);
            db.SaveChanges();
        }
    }
}