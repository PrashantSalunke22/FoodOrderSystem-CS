using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;
using static System.Console;
namespace FoodOrderSystem
{
    public abstract class HamburgerMenu : Hamburger
    {
        public string description = "No Order";

        public virtual string GetDescription() { return description; }

        public abstract double GetCost();

        public Hamburger createHamburger(IHamburgerIngredientFactory hamburgerIngredientFactory)
        {
            Clear();
            Hamburger hamburger = new Hamburger();
            
            hamburger.bread = hamburgerIngredientFactory.CreateBread(); Sleep(1000);
            hamburger.meat = hamburgerIngredientFactory.CreateMeat(); Sleep(1000);
            hamburger.veggies = hamburgerIngredientFactory.CreateVeggies(); Sleep(1000);
            hamburger.sauces = hamburgerIngredientFactory.CreateSauces(); Sleep(1000);

            return hamburger;
        }
    }

    public class TSHMenu : HamburgerMenu
    {
        public TSHMenu()
        {
            description = "Texas Smokehouse";
            createHamburger(new TexasSmokeHouseFactory());
        }

        public override double GetCost() { return 34.50; }
    }

    public class ChickenRoyaleMenu : HamburgerMenu
    {
        public ChickenRoyaleMenu()
        {
            description = "Chicken Royale";
            createHamburger(new ChickenRoyaleFactory());
        }

        public override double GetCost() { return 18.50; }
    }
} 
