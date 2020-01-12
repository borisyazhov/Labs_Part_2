using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA13_2
{
    class Card
    {
        public int NumberOfCard { get; set; }
        public int GetNumberOfCard()
        {
            return NumberOfCard;
        }
        public string FCS { get; set; }
        public string GetFCS()
        {
            return FCS;
        }
        public int Discounts { get; set; }
        public int GetDiscounts()
        {
            return Discounts;
        }
        public Card()
        {
            MyClassEventArgs.mOne();
        }
        public Card(int numberofcard, string fcs, int discounts)
        {
            NumberOfCard = numberofcard;
            FCS = fcs;
            Discounts = Discounts;
            MyClassEventArgs.MessegeTwo();
        }
    }
    class Shop
    {

        private List<Card> Cards { get; set; }
        public Shop()
        {
            MyClassEventArgs.MessegeTwo();
        }
        public Shop(List<Card> cards)
        {
            this.Cards = cards;
            MyClassEventArgs.MessegeTwo();
        }
        public void Laba13_2()
        {
            foreach(Card i in Cards)
            {
                if(i.GetDiscounts() == 10)
                {
                    Console.WriteLine(i.GetDiscounts());
                    Console.WriteLine(i.GetNumberOfCard());
                }
            }
        }
    }
    class MyClassEventArgs
    {
      
      public static  Action mOne = () => { Console.WriteLine(" Oblect Card was created"); };
        public static void MessegeTwo()
        {
            Console.WriteLine(" Oblect Shop was created");
        }
    }
}
