using System;
using DiscountStrategy.Models;

interface IDiscountStrategy
{
    // This will have the algo to calculate the discount depending upon the order
    double CalculateDiscount(Order order);
}

