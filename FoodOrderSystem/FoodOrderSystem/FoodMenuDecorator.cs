using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderSystem
{
    public abstract class FoodMenuDecorator : HamburgerMenu { public abstract double GetSnackOrBeverageCost(); }

    public class SmallPotatoChips : FoodMenuDecorator
    {
        HamburgerMenu hamburgerMenu;

        public SmallPotatoChips(HamburgerMenu hamburgerMenu) { this.hamburgerMenu = hamburgerMenu; }

        public override string GetDescription() { return hamburgerMenu.GetDescription() + "\nPotato Chips(S)    " + GetSnackOrBeverageCost(); }

        public override double GetCost() { return GetSnackOrBeverageCost() + hamburgerMenu.GetCost(); }

        public override double GetSnackOrBeverageCost() { return 0.30; }
    }
    public class MediumPotatoChips : FoodMenuDecorator
    {
        HamburgerMenu hamburgerMenu;

        public MediumPotatoChips(HamburgerMenu hamburgerMenu) { this.hamburgerMenu = hamburgerMenu; }

        public override string GetDescription() { return hamburgerMenu.GetDescription() + "\nPotato Chips(M)    " + GetSnackOrBeverageCost(); }

        public override double GetCost() { return GetSnackOrBeverageCost() + hamburgerMenu.GetCost(); }

        public override double GetSnackOrBeverageCost() { return 0.40; }
    }
    public class LargePotatoChips : FoodMenuDecorator
    {
        HamburgerMenu hamburgerMenu;

        public LargePotatoChips(HamburgerMenu hamburgerMenu) { this.hamburgerMenu = hamburgerMenu; }

        public override string GetDescription() { return hamburgerMenu.GetDescription() + "\nPotato Chips(L)    " + GetSnackOrBeverageCost(); }

        public override double GetCost() { return GetSnackOrBeverageCost() + hamburgerMenu.GetCost(); }

        public override double GetSnackOrBeverageCost() { return 0.50; }
    }
    public class ChickenTenders : FoodMenuDecorator
    {
        HamburgerMenu hamburgerMenu;

        public ChickenTenders(HamburgerMenu hamburgerMenu) { this.hamburgerMenu = hamburgerMenu; }

        public override string GetDescription() { return hamburgerMenu.GetDescription() + "\nChicken Tenders    " + GetSnackOrBeverageCost(); }

        public override double GetCost() { return GetSnackOrBeverageCost() + hamburgerMenu.GetCost(); }

        public override double GetSnackOrBeverageCost() { return 0.40; }
    }

    public class SmallCoke : FoodMenuDecorator
    {
        HamburgerMenu hamburgerMenu;

        public SmallCoke(HamburgerMenu hamburgerMenu) { this.hamburgerMenu = hamburgerMenu; }

        public override string GetDescription() { return hamburgerMenu.GetDescription() + "\nCoke(S)    " + GetSnackOrBeverageCost(); }

        public override double GetCost() { return GetSnackOrBeverageCost() + hamburgerMenu.GetCost(); }

        public override double GetSnackOrBeverageCost() { return 0.20; }
    }
    public class MediumCoke : FoodMenuDecorator
    {
        HamburgerMenu hamburgerMenu;

        public MediumCoke(HamburgerMenu hamburgerMenu) { this.hamburgerMenu = hamburgerMenu; }

        public override string GetDescription() { return hamburgerMenu.GetDescription() + "\nCoke(M)    " + GetSnackOrBeverageCost(); }

        public override double GetCost() { return GetSnackOrBeverageCost() + hamburgerMenu.GetCost(); }

        public override double GetSnackOrBeverageCost() { return 0.30; }
    }
    public class LargeCoke : FoodMenuDecorator
    {
        HamburgerMenu hamburgerMenu;

        public LargeCoke(HamburgerMenu hamburgerMenu) { this.hamburgerMenu = hamburgerMenu; }

        public override string GetDescription() { return hamburgerMenu.GetDescription() + "\nCoke(L)    " + GetSnackOrBeverageCost(); }

        public override double GetCost() { return GetSnackOrBeverageCost() + hamburgerMenu.GetCost(); }

        public override double GetSnackOrBeverageCost() { return 0.40; }
    }

    public class SmallLemonIceTea : FoodMenuDecorator
    {
        HamburgerMenu hamburgerMenu;

        public SmallLemonIceTea(HamburgerMenu hamburgerMenu) { this.hamburgerMenu = hamburgerMenu; }

        public override string GetDescription() { return hamburgerMenu.GetDescription() + "\nLemon Ice Tea(S)    " + GetSnackOrBeverageCost(); }

        public override double GetCost() { return GetSnackOrBeverageCost() + hamburgerMenu.GetCost(); }

        public override double GetSnackOrBeverageCost() { return 0.10; }
    }
    public class MediumLemonIceTea : FoodMenuDecorator
    {
        HamburgerMenu hamburgerMenu;

        public MediumLemonIceTea(HamburgerMenu hamburgerMenu) { this.hamburgerMenu = hamburgerMenu; }

        public override string GetDescription() { return hamburgerMenu.GetDescription() + "\nLemon Ice Tea(M)    " + GetSnackOrBeverageCost(); }

        public override double GetCost() { return GetSnackOrBeverageCost() + hamburgerMenu.GetCost(); }

        public override double GetSnackOrBeverageCost() { return 0.20; }
    }
    public class LargeLemonIceTea : FoodMenuDecorator
    {
        HamburgerMenu hamburgerMenu;

        public LargeLemonIceTea(HamburgerMenu hamburgerMenu) { this.hamburgerMenu = hamburgerMenu; }

        public override string GetDescription() { return hamburgerMenu.GetDescription() + "\nLemon Ice Tea(L)    " + GetSnackOrBeverageCost(); }

        public override double GetCost() { return GetSnackOrBeverageCost() + hamburgerMenu.GetCost(); }

        public override double GetSnackOrBeverageCost() { return 0.30; }
    }

    public class SmallPeachIceTea : FoodMenuDecorator
    {
        HamburgerMenu hamburgerMenu;

        public SmallPeachIceTea(HamburgerMenu hamburgerMenu) { this.hamburgerMenu = hamburgerMenu; }

        public override string GetDescription() { return hamburgerMenu.GetDescription() + "\nPeach Ice Tea(S)    " + GetSnackOrBeverageCost(); }

        public override double GetCost() { return GetSnackOrBeverageCost() + hamburgerMenu.GetCost(); }

        public override double GetSnackOrBeverageCost() { return 0.10; }
    }
    public class MediumPeachIceTea : FoodMenuDecorator
    {
        HamburgerMenu hamburgerMenu;

        public MediumPeachIceTea(HamburgerMenu hamburgerMenu) { this.hamburgerMenu = hamburgerMenu; }

        public override string GetDescription() { return hamburgerMenu.GetDescription() + "\nPeach Ice Tea(M)    " + GetSnackOrBeverageCost(); }

        public override double GetCost() { return GetSnackOrBeverageCost() + hamburgerMenu.GetCost(); }

        public override double GetSnackOrBeverageCost() { return 0.20; }
    }
    public class LargePeachIceTea : FoodMenuDecorator
    {
        HamburgerMenu hamburgerMenu;

        public LargePeachIceTea(HamburgerMenu hamburgerMenu) { this.hamburgerMenu = hamburgerMenu; }

        public override string GetDescription() { return hamburgerMenu.GetDescription() + "\nPeach Ice Tea(L)    " + GetSnackOrBeverageCost(); }

        public override double GetCost() { return GetSnackOrBeverageCost() + hamburgerMenu.GetCost(); }

        public override double GetSnackOrBeverageCost() { return 0.30; }
    }
}
