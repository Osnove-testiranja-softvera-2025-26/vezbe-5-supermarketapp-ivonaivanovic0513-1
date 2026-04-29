using NUnit.Framework;
using OTS_Supermarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Supermarket.Test
{
    public class CartTest
    {
        [Test]
        public void AddOneCart_SouldAddItemToCart_Success()
        {
            //ARRANGE
            Cart cart = new Cart();
            Monitor monitor = new Monitor();
            //ACT
            cart.AddOneToCart();

            //ASSERT
            Assert.That(cart.Size is.EqualTo(2));
            Assert.That(cart.Amount, Is.EqualTo(100));

        }

        [Test]
        public void Checkout_WithLessThanTenItems_ShouldThrowException()
        {
            // ARRANGE
            Cart cart = new Cart();

            
            for (int i = 0; i < 9; i++)
            {
                cart.AddOneToCart(new Monitor());
            }
            // ACT 
            var ex = Assert.Throws<Exception>(() => cart.Checkout());
           //ASSERT
            Assert.That(ex.Message, Is.EqualTo("U korpi se nalaze manje od 10 artikala"));
        }
        [Test]
        public void Checkout_WithMixedItemsLessThanTen_ShouldThrowException()
        {
            // ARRANGE
            Cart cart = new Cart();

            // Dodajemo različite objekte
            cart.AddOneToCart(new Monitor());
            cart.AddOneToCart(new Keyboard());
            cart.AddOneToCart(new Laptop());
            cart.AddOneToCart(new Computer());
            cart.AddOneToCart(new Chair());
            // Ukupno 5 artikala

            // ACT & ASSERT
            var ex = Assert.Throws<Exception>(() => cart.Checkout());

            // Proveravamo da li je Size ispravno izračunat pre bacanja greške
            Assert.That(cart.Size, Is.EqualTo(5));
            Assert.That(ex.Message, Is.EqualTo("U korpi se nalaze manje od 10 artikala"));
        }
    }
}
