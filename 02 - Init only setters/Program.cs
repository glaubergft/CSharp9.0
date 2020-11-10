using InitOnlySetters.ExampleClasses;
using System;

namespace InitOnlySetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Private set ===> 
            //// Init ==========> 
            Receipt myReceipt1 = new Receipt(100);
            myReceipt1.TransactionValue = 200;
        }
    }
}
