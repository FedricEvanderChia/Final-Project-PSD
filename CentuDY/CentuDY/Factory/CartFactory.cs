using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Factory
{
    public class CartFactory
    {
        public static Cart CreateCartItem(int userId, int medicineId, int quantity)
        {
            Cart cart = new Cart
            {
                UserId = userId,
                MedicineId = medicineId,
                Quantity = quantity
            };

            return cart;
        }
    }
}