using CentuDY.Factory;
using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Handler
{
    public class CartHandler
    {
        public static void AddtoCart(int userId, int medicineId, int quantity)
        {
            Cart cart = CartFactory.CreateCartItem(userId, medicineId, quantity);
            CartRepository.AddtoCart(cart);
        }

        public static Cart GetExistingItem(int userId, int medicineId)
        {
            return CartRepository.GetExistingItem(userId, medicineId);
        }

        public static List<Cart> GetAllCartItemsByUserId(int userId)
        {
            return CartRepository.GetAllCartItemsByUserId(userId);
        }

        public static void UpdateCartItem(int userId, int medicineId, int quantity)
        {
            CartRepository.UpdateCartItem(userId, medicineId, quantity);
        }

        public static void RemoveCartItem(int userId, int medicineId)
        {
            CartRepository.RemoveCartItem(userId, medicineId);
        }
    }
}