using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DelegateCodingChallenge
{
    public delegate void MyEventHandler(int i);
    class PiggyBank
    {
        public event MyEventHandler valueChanged;
        private int bal;
        public int Bal
        {
            get { return bal; }
            set
            {
                this.bal = value;
                this.valueChanged(this.bal);
            }
        }

        public PiggyBank()
        {
            bal = 0;
        }
    }

    public class Bank
    {
        static void Main(string[] args)
        {
            const int _target = 100;
            PiggyBank obj = new PiggyBank();
            obj.valueChanged += (int bal) =>
            {
                Console.WriteLine("The new value set to {0}", bal);
            };
            obj.valueChanged += (int bal) =>
            {
                if (bal >= _target)
                {
                    Console.WriteLine("Target reached!");
                }
            };
            int deposit;
            do
            {
                Console.WriteLine("Enter deposit amount: ");
                var inp = Console.ReadLine();
                if (inp == "exit") break;
                deposit = int.Parse(inp);
                obj.Bal += deposit;
            } while (true);
        }
    }
   
}
