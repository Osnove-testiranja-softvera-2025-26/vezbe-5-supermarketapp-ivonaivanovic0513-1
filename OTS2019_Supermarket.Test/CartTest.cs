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

    }
}
