using BeastTuners.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

public class CartService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private const string CartSessionKey = "Cart";

    public CartService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public List<CartItem> GetCart()
    {
        var session = _httpContextAccessor.HttpContext.Session;
        var cartJson = session.GetString(CartSessionKey);
        return cartJson == null ? new List<CartItem>() : JsonConvert.DeserializeObject<List<CartItem>>(cartJson);
    }

    public void AddToCart(CartItem item)
    {
        var cart = GetCart();
        var existingItem = cart.Find(c => c.PartID == item.PartID);

        if (existingItem != null)
        {
            existingItem.Quantity += item.Quantity;  
        }
        else
        {
            cart.Add(item);
        }

        SaveCart(cart);
    }

    public void UpdateCart(int partID, int quantity)
    {
        var cart = GetCart();
        var item = cart.Find(c => c.PartID == partID);

        if (item != null)
        {
            if (quantity > 0)
            {
                item.Quantity = quantity;  
            }
            else
            {
                cart.Remove(item); 
            }
        }

        SaveCart(cart);
    }

    public void RemoveFromCart(int partId)
    {
        var cart = GetCart();
        var item = cart.Find(c => c.PartID == partId);

        if (item != null)
        {
            if (item.Quantity > 1)
            {
                item.Quantity--;  //Decrease quantity instead of removing
            }
            else
            {
                cart.Remove(item); //Remove item if quantity reaches 0
            }
        }

        SaveCart(cart);
    }

    public void ClearCart()
    {
        SaveCart(new List<CartItem>());
    }

    private void SaveCart(List<CartItem> cart)
    {
        var session = _httpContextAccessor.HttpContext.Session;
        session.SetString(CartSessionKey, JsonConvert.SerializeObject(cart));
    }
}
