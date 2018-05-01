using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderSystem
{
    public interface IBread { string BreadName { set; get; } }
    public class RyeBread : IBread
    {
        string breadName;
        public string BreadName {
            set { breadName = value; }
            get { return breadName; }
        }

        public RyeBread() { BreadName = "Rye Bread"; }
    }
    public class WhiteBread : IBread
    {
        string breadName;
        public string BreadName
        {
            set { breadName = value; }
            get { return breadName; }
        }

        public WhiteBread() { BreadName = "White Bread"; }
    }

    public interface IMeat { string MeatName { set; get; } }
    public class Beef : IMeat
    {
        string meatName;

        public string MeatName
        {
            set { meatName = value; }
            get { return meatName; }
        }

        public Beef() { MeatName = "Beef"; }
    }
    public class Chicken : IMeat
    {
        string meatName;

        public string MeatName
        {
            set { meatName = value; }
            get { return meatName; }
        }

        public Chicken() { MeatName = "Chicken"; }
    }

    public interface IVeggie { string VeggieName { set; get; } }
    public class Lettuce : IVeggie
    {
        string veggieName;

        public string VeggieName
        {
            set { veggieName = value; }
            get { return veggieName; }
        }

        public Lettuce() { VeggieName = "Lettuce"; }
    }
    public class Tomato : IVeggie
    {
        string veggieName;

        public string VeggieName
        {
            set { veggieName = value; }
            get { return veggieName; }
        }

        public Tomato() { VeggieName = "Tomato"; }
    }
    public class Pickle : IVeggie
    {
        string veggieName;

        public string VeggieName
        {
            set { veggieName = value; }
            get { return veggieName; }
        }
        public Pickle() { veggieName = "Pickle"; }
    }

    public interface ISauce { string SauceName { set; get; } }
    public class BBQ : ISauce
    {
        string sauceName;

        public string SauceName
        {
            set { sauceName = value; }
            get { return sauceName; }
        }

        public BBQ() { SauceName = "BBQ"; }
    }
    public class Mustard : ISauce
    {
        string sauceName;

        public string SauceName
        {
            set { sauceName = value; }
            get { return sauceName; }
        }

        public Mustard() { SauceName = "Mustard"; }
    }
    public class Mayo : ISauce
    {
        string sauceName;

        public string SauceName
        {
            set { sauceName = value; }
            get { return sauceName; }
        }

        public Mayo() { SauceName = "Mayo"; }
    }
    public class Ketchup : ISauce
    {
        string sauceName;

        public string SauceName
        {
            set { sauceName = value; }
            get { return sauceName; }
        }

        public Ketchup() { SauceName = "Ketchup"; }
    }
}
