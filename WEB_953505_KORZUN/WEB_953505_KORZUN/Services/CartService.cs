using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WEB_953505_KORZUN.Entities;
using WEB_953505_KORZUN.Extensions;
using WEB_953505_KORZUN.Models;

namespace WEB_953505_KORZUN.Services
{
    public class CartService : Cart
    {
        private string sessionKey = "cart";
        [JsonIgnore]
        ISession Session { get; set; }
        public static Cart GetCart(IServiceProvider sp)
        {
            // получить объект сессии
            var session = sp
            .GetRequiredService<IHttpContextAccessor>()
            .HttpContext
            .Session;
            // получить CartService из сессии
            // или создать новый для возможности тестирования
            var cart = session?.Get<CartService>("cart")
            ?? new CartService();
            cart.Session = session;
            return cart;
        }
        public override void AddToCart(Product product)
        {
            base.AddToCart(product);
            Session?.Set<CartService>(sessionKey, this);
        }
        public override void RemoveFromCart(int id)
        {
            base.RemoveFromCart(id);
            Session?.Set<CartService>(sessionKey, this);
        }
        public override void ClearAll()
        {
            base.ClearAll();
            Session?.Set<CartService>(sessionKey, this);
        }
    }
    
}
