using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Threading.Thread;
namespace FoodOrderSystem
{
    class Screen
    {
        HamburgerMenu hamburgerMenu;
        ConsoleKey ck;
        CashRegister cashRegister;

        public Screen()
        {
            cashRegister = CashRegister.getInstance();
            MenuChoiseScreen();
        }

        void MenuChoiseScreen()
        {
            WriteLine("1 - Texas Smokehouse Menu" +
                      "\n2 - Chicken Royale Menu");

            ck = ReadKey().Key;

            switch (ck)
            {
                case ConsoleKey.NumPad1: hamburgerMenu = new TSHMenu(); break;
                case ConsoleKey.NumPad2: hamburgerMenu = new ChickenRoyaleMenu(); break;
            }

            MenuCustomizeScreen(hamburgerMenu);
        }

        void MenuCustomizeScreen(HamburgerMenu hamburgerMenu)
        {
            Clear();
            WriteLine("1 - Potato Chips\n" +
                      "2 - Chicken Tenders\n" +
                      "3 - Beverages\n");

            ck = ReadKey().Key;

            switch(ck)
            {
                case ConsoleKey.NumPad1: PotatoChipsSizeChoiceScreen(hamburgerMenu); break;
                case ConsoleKey.NumPad2: this.hamburgerMenu = new ChickenTenders(hamburgerMenu); break;
                case ConsoleKey.NumPad3: BeverageChoiseScreen(this.hamburgerMenu); break;
            }

            WriteLine("Do have Do you have any other request? (Y/N)");

            ck = ReadKey().Key;

            switch(ck)
            {
                case ConsoleKey.Y:
                    Clear();
                    MenuCustomizeScreen(this.hamburgerMenu); break;
                case ConsoleKey.N:
                    WriteLine("Do you want to get served or get packed your Order?(S/P)");
                    ck = ReadKey().Key;
                    Clear();
                    switch(ck)
                    {
                        case ConsoleKey.S:
                            this.hamburgerMenu.Prepare(); Sleep(1000);
                            this.hamburgerMenu.Bake(); Sleep(1000);
                            this.hamburgerMenu.Serve(); Sleep(1000);
                            break;
                        case ConsoleKey.P:
                            this.hamburgerMenu.Prepare(); Sleep(1000);
                            this.hamburgerMenu.Bake(); Sleep(1000);
                            this.hamburgerMenu.Box(); Sleep(1000);
                            break;
                    }
                    PaymentScreen(this.hamburgerMenu); break;
            }
        }

        void PotatoChipsSizeChoiceScreen(HamburgerMenu hamburgerMenu)
        {
            Clear();
            WriteLine("Potato Size\n" + 
                      "S - Small\n" +
                      "M - Medium\n" +
                      "L - Large");

            ck = ReadKey().Key;

            switch(ck)
            {
                case ConsoleKey.S: this.hamburgerMenu = new SmallPotatoChips(hamburgerMenu); break;
                case ConsoleKey.M: this.hamburgerMenu = new MediumPotatoChips(hamburgerMenu); break;
                case ConsoleKey.L: this.hamburgerMenu = new LargePotatoChips(hamburgerMenu); break;
            }
        }

        void BeverageChoiseScreen(HamburgerMenu hamburgerMenu)
        {
            Clear();
            WriteLine("Beverage Choise\n" +
                      "1 - Coke\n" +
                      "2 - Ice Tea\n");

            ck = ReadKey().Key;

            switch(ck)
            {
                case ConsoleKey.NumPad1: CokeSizeChoiseScreen(hamburgerMenu); break;
                case ConsoleKey.NumPad2: IceTeaChoiseScreen(hamburgerMenu); break;
            }
        }

        void CokeSizeChoiseScreen(HamburgerMenu hamburgerMenu)
        {
            Clear();
            WriteLine("Coke Size\n" +
                     "S - Small\n" +
                     "M - Medium\n" +
                     "L - Large");

            ck = ReadKey().Key;

            switch (ck)
            {
                case ConsoleKey.S: this.hamburgerMenu = new SmallCoke(hamburgerMenu); break;
                case ConsoleKey.M: this.hamburgerMenu = new MediumCoke(hamburgerMenu); break;
                case ConsoleKey.L: this.hamburgerMenu = new LargeCoke(hamburgerMenu); break;
            }
        }

        void IceTeaChoiseScreen(HamburgerMenu hamburgerMenu)
        {
            Clear();
            WriteLine("Ice Tea Choise\n" +
                      "1 - Lemon\n" +
                      "2 - Peach\n");

            ck = ReadKey().Key;

            switch (ck)
            {
                case ConsoleKey.NumPad1: LemonIceTeaSizeScreen(hamburgerMenu); break;
                case ConsoleKey.NumPad2: PeachIceTeaSizeScreen(hamburgerMenu); break;
            }
        }

        void LemonIceTeaSizeScreen(HamburgerMenu hamburgerMenu)
        {
            Clear();
            WriteLine("Lemon Ice Tea Size\n" +
                     "S - Small\n" +
                     "M - Medium\n" +
                     "L - Large");

            ck = ReadKey().Key;

            switch (ck)
            {
                case ConsoleKey.S: this.hamburgerMenu = new SmallLemonIceTea(hamburgerMenu); break;
                case ConsoleKey.M: this.hamburgerMenu = new MediumLemonIceTea(hamburgerMenu); break;
                case ConsoleKey.L: this.hamburgerMenu = new LargeLemonIceTea(hamburgerMenu); break;
            }
        }

        void PeachIceTeaSizeScreen(HamburgerMenu hamburgerMenu)
        {
            Clear();
            WriteLine("Peach Ice Tea Size\n" +
                     "S - Small\n" +
                     "M - Medium\n" +
                     "L - Large");

            ck = ReadKey().Key;

            switch (ck)
            {
                case ConsoleKey.S: this.hamburgerMenu = new SmallPeachIceTea(hamburgerMenu); break;
                case ConsoleKey.M: this.hamburgerMenu = new MediumPeachIceTea(hamburgerMenu); break;
                case ConsoleKey.L: this.hamburgerMenu = new LargePeachIceTea(hamburgerMenu); break;
            }
        }

        void PaymentScreen(HamburgerMenu hamburgerMenu)
        {
            Clear();
            WriteLine("CHECK\n" +
                       hamburgerMenu.GetDescription() +
                      "\nTOTAL:" + hamburgerMenu.GetCost() +
                      "\nPush ENTER button to continue.");
            ck = ReadKey().Key;
            if(ck != ConsoleKey.Enter)
            {
                WriteLine("Please try again!");
                Sleep(1000);
                PaymentScreen(hamburgerMenu);
            }
            else
            {
                Clear();
                cashRegister.putCash();
                Sleep(1000);
                cashRegister.CompletePayment();
                Sleep(1000);
                cashRegister.CompleteOrder();
            }

        }
    }
}
