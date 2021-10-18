using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller
{
    public class CartController
    {
        public static string AddtoCart(int userId, int medicineId, string quantity, int stock)
        {
            int quantityInt;

            if(quantity.Length <= 0)
            {
                return "Quantity cannot be empty";
            }
            else if(!Int32.TryParse(quantity, out quantityInt))
            {
                return "Quantity must be numeric";
            }
            else if(Int32.TryParse(quantity, out quantityInt))
            {
                quantityInt = Int32.Parse(quantity);
                int existQuantity = 0;
                int totalQuantity = quantityInt;

                Cart existingItem = CartHandler.GetExistingItem(userId, medicineId);
                
                if(existingItem != null)
                {
                    existQuantity = (int)existingItem.Quantity;
                    totalQuantity = quantityInt + existQuantity;
                }

                if (quantityInt <= 0)
                {
                    return "Quantity must be more than 0";
                }
                else if(quantityInt > stock)
                {
                    return "Quantity must be less than or equals to current stock";
                }
                else if(totalQuantity > stock)
                {
                    return ("You have item with quantity of " + existQuantity.ToString() + ", cannot exceed current stock");
                }
                else if(existingItem != null)
                {
                    CartHandler.UpdateCartItem(userId, medicineId, quantityInt);
                    return "";
                }
            }

            CartHandler.AddtoCart(userId, medicineId, quantityInt);
            return "";
        }

        public static List<Cart> GetAllCartItemsByUserId(int userId)
        {
            return CartHandler.GetAllCartItemsByUserId(userId);
        }

        public static void RemoveCartItem(int userId, int medicineId)
        {
            CartHandler.RemoveCartItem(userId, medicineId);
        }
    }
}