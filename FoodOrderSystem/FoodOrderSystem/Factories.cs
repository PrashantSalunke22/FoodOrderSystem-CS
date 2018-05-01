using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FoodOrderSystem
{
    public interface IHamburgerIngredientFactory
    {
        IBread CreateBread();
        IMeat CreateMeat();
        IVeggie []CreateVeggies();
        ISauce []CreateSauces();
    }

    public class TexasSmokeHouseFactory : IHamburgerIngredientFactory
    {
        public TexasSmokeHouseFactory()
        {
            CreateBread();
            CreateMeat();
            CreateSauces();
            CreateVeggies();
        }

        public IBread CreateBread()
        {
            IBread bread = new RyeBread();
            Write("TSH Bread: " + bread.BreadName);
            return bread;
        }

        public IMeat CreateMeat()
        {
            IMeat meat = new Beef();
            Write("\nTSH Meat: " + meat.MeatName);
            return meat;
        }

        public IVeggie[] CreateVeggies()
        {
            IVeggie[] veggies = { new Pickle(), new Tomato() };
            Write("\nTSH Veggies: ");
            for (int i = 0; i < veggies.Length; i++) Write(veggies[i].VeggieName + " ");
            return veggies;
        }

        public ISauce []CreateSauces()
        {
            ISauce[] sauces = { new BBQ(), new Mustard() };
            Write("\nTSH Sauces: ");
            for (int i = 0; i < sauces.Length; i++) Write(sauces[i].SauceName + " ");
            return sauces;
        }
    }

    public class ChickenRoyaleFactory : IHamburgerIngredientFactory
    {
        public ChickenRoyaleFactory()
        {
            CreateBread();
            CreateMeat();
            CreateSauces();
            CreateVeggies();
        }

        public IBread CreateBread()
        {
            IBread bread = new WhiteBread();
            Write("Chicken Royale Bread: " + bread.BreadName);
            return bread;
        }

        public IMeat CreateMeat()
        {
            IMeat meat = new Chicken();
            Write("\nChicken Royale Meat: " + meat.MeatName);
            return meat;
        }

        public IVeggie[] CreateVeggies()
        {
            IVeggie[] veggies = { new Pickle(), new Lettuce() };
            Write("\nChicken Royale Veggies: ");
            for (int i = 0; i < veggies.Length; i++) Write(veggies[i].VeggieName + " ");
            return veggies;
        }

        public ISauce[] CreateSauces()
        {
            ISauce[] sauces = { new Ketchup(), new Mayo() };
            Write("\nChicken Royale Sauces: ");
            for (int i = 0; i < sauces.Length; i++) Write(sauces[i].SauceName + " ");
            return sauces;
        }
    }
}
