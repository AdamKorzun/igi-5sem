using System;
using System.Collections.Generic;
using System.Linq;
using WEB_953505_KORZUN.Entities;

namespace WEB_953505_KORZUN.Models
{
    public class Cart
    {
        public Dictionary<int, CartItem> Items { get; set; }
        public Cart()
        {
            Items = new Dictionary<int, CartItem>();
        }
        public virtual int Count
        {
            get
            {
                return Items.Sum(item => item.Value.Quantity);
            }
        }
 
        public virtual int Price
        {
            get
            {
                return Items.Sum(item => item.Value.Quantity *
                (int)item.Value.Product.Price);
            }
        }
  
        public virtual void AddToCart(Product product)
        {

            if (Items.ContainsKey(product.ProductId))
                Items[product.ProductId].Quantity++;
            else
                Items.Add(product.ProductId, new CartItem
                {
                    Product = product,
                    Quantity = 1
                });
        }
      
        public virtual void RemoveFromCart(int id)
        {
            Items.Remove(id);
        }
    
        public virtual void ClearAll()
        {
            Items.Clear();
        }
    }
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

}
