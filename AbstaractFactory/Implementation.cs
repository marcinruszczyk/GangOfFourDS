﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstaractFactory.IDiscountService;

namespace AbstaractFactory
{
    //AbstractFactory
    public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();
        IShippingCostsService CreateShippingCostsService();
    }

   //AbstractProduct
    public interface IDiscountService
    {
        int DiscountPercentage { get; }
    }
             
    public interface IShippingCostsService
    {
        decimal ShippingCosts { get; }

    }

    //ConcreteProduct
    public class BelgiumDiscountService : IDiscountService
    {
        public int DiscountPercentage => 20;
    }


    //ConcreteProduct
    public class FranceDiscountService : IDiscountService
    {
        public int DiscountPercentage => 10;
    }

    //ConcreteProduct
    public class BelgiumShippingCostsService : IShippingCostsService 
    {
        public decimal ShippingCosts => 20;
    }

    public class FranceShippingCostsService : IShippingCostsService
    {
        public decimal ShippingCosts => 25;
    }


    //ConcreteFactory

    public class BelgiumShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new BelgiumDiscountService();
        }

        public IShippingCostsService CreateShippingCostsService()
        {
            return new BelgiumShippingCostsService();
        }
    }

    //ConcreteFactory
    public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new FranceDiscountService();
        }

        public IShippingCostsService CreateShippingCostsService()
        {
            return new FranceShippingCostsService();
        }
    }



    //Client class

    public class ShoppingCart
    {
        private readonly IDiscountService _discountService;
        private readonly IShippingCostsService _shippingCostsService;
        private int _orderCosts;

        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {
            _discountService = factory.CreateDiscountService();
            _shippingCostsService = factory.CreateShippingCostsService();
            _orderCosts = 200;
            
        }

        public void CalculateCosts()
        {
            Console.WriteLine($"Total costs = " +
                $"{_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts }");
        }


    }



}
