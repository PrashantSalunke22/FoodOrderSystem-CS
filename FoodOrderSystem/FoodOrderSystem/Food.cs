using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FoodOrderSystem
{
    public class Hamburger
    {
        public IBread bread;
        public IMeat meat;
        public IVeggie []veggies;
        public ISauce []sauces;
       
       public void Prepare() { WriteLine("Preparing your Hamburger Menu"); }

       public void Bake() { WriteLine("Baking your Hamburger Menu"); }

       public void Serve() { WriteLine("Serving your Hamburger Menu"); }

       public void Box() { WriteLine("Boxing your Hamburger Menu"); }
    }
}
