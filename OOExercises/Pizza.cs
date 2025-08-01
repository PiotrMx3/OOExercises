using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercises
{
    internal abstract class Pizza
    {
        protected List<string> Ingredients;

        public Pizza(string[] extraToppings)
        {
            this.Ingredients = new List<string> { "deeg", "tomatensaus", "kaas" };

            foreach (var topping in extraToppings)
            {
                this.Ingredients.Add(topping);
            }
        }

        public abstract double UnitPrice
        {
            get;
        }

        public double Price
        {
            get
            {
                return this.UnitPrice + (this.Ingredients.Count * 0.5);
            }
        }
        
        public void ShowIngredients()
        {
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine(ingredient);
            }
        }

    }


    internal class Margherita : Pizza
    {

        public Margherita() : base(new[] { "mozzarella" })
        {

        }
        public override double UnitPrice    
        {
            get { return 5.00; }
        }
    }


    internal class Vegie : Pizza
    {
        public Vegie() : base(new[] {"tofu" , "spinaze"})
        {
            Ingredients.Remove("kaas");
        }
        public override double UnitPrice
        {
            get { return 6.00; }
        }
    }


}
