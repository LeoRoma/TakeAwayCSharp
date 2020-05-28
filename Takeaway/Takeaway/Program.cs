using System;

namespace Takeaway
{
    class Program
    {
        static void Main(string[] args)
        {
            Dish margherita = new Dish("Margherita", 5.00);
            Dish boscaiola = new Dish("Boscaiola", 5.60);
            Dish diavola = new Dish("Diavola", 6.00);
            Dish capricciosa = new Dish("Capricciosa", 6.60);

            Menu menu = new Menu(
                new[] {
                    margherita,
                    boscaiola,
                    diavola,
                    capricciosa
                });

            Checkout checkout = new Checkout();
            
            //menu.Print();

            checkout.Add(margherita, 4);
            checkout.Add(boscaiola, 2);
            checkout.Add(diavola, 3);
            checkout.Add(capricciosa, 1);
            checkout.Calculate();
            checkout.PrintBill();
            checkout.Payment(55.80);
        }
    }
}
