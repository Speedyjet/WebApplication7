using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class ShoppingCartModel
    {
        public static ShoppingCartModel CurrentCart
        {
            get
            {
                var cart = HttpContext.Current.Session["Cart"] as ShoppingCartModel;
                if (null != cart) return cart;
                cart = new ShoppingCartModel();
                HttpContext.Current.Session["Cart"] = cart;
                return cart;
            }
        }
    }
}