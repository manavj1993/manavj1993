using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice.RoughProblemSolving
{
    public interface ICoffee
    {
        double GetCost();
        string GetIngredients();
    }

    public class BasicCoffee : ICoffee
    {
        public double GetCost()
        {
            return 1.0;
        }

        public string GetIngredients()
        {
            return "Coffee";
        }
    }

    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee decoratedCoffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            decoratedCoffee = coffee;
        }

        public virtual double GetCost()
        {
            return decoratedCoffee.GetCost();
        }

        public virtual string GetIngredients()
        {
            return decoratedCoffee.GetIngredients();
        }
    }

    public class CreamDecorator : CoffeeDecorator
    {
        public CreamDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost()
        {
            return decoratedCoffee.GetCost() + 0.5;
        }

        public override string GetIngredients()
        {
            return decoratedCoffee.GetIngredients() + ", Cream";
        }
    }

    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost()
        {
            return decoratedCoffee.GetCost() + 0.2;
        }

        public override string GetIngredients()
        {
            return decoratedCoffee.GetIngredients() + ", Sugar";
        }
    }

    public static class Client
    {
        public static void Function()
        {
            // Create a basic coffee
            ICoffee coffee = new BasicCoffee();

            // Decorate the coffee with cream
            coffee = new CreamDecorator(coffee);

            // Decorate the coffee with sugar
            coffee = new SugarDecorator(coffee);

            // Get the cost and ingredients of the decorated coffee
            double cost = coffee.GetCost();
            string ingredients = coffee.GetIngredients();

            Console.WriteLine("Cost: $" + cost);
            Console.WriteLine("Ingredients: " + ingredients);
        }
    }

}