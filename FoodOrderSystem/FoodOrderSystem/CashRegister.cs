using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FoodOrderSystem
{
    class CashRegister
    {
        bool empty, payment;
        static CashRegister instance;

        public CashRegister()
        {
            empty = true;
            payment = false;
        }

        public static CashRegister getInstance()
        {
            if (instance == null) instance = new CashRegister();    
            return instance;
        }

        bool isEmpty() { return empty; }

        bool isPaid() { return payment; }

        public void putCash()
        {
            if (isEmpty())
            {
                WriteLine("The cash register is full...");
                empty = false;
            }
        }

        public void CompletePayment()
        {
            if (!isEmpty() && !isPaid())
            {
                WriteLine("Payment is completed ...");
                payment = true;
            }
        }

        public void CompleteOrder()
        {
            WriteLine("Thank you for choosing us, Have a good day!\n");
            empty = true;
            payment = false;
        }
    }
}
