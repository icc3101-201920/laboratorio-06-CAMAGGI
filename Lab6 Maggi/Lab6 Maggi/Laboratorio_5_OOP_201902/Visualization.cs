using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Laboratorio_5_OOP_201902.Cards;

namespace Laboratorio_5_OOP_201902
{
    public static class Visualization
    {
        static void Playing()
        {

        }
       public static void  ShadowHand(Hand hand)
        {
            int c = 1;
            Console.WriteLine($"Player Hand:");
            foreach (Card card in hand.Cards)
            {
                Console.WriteLine($"{c++}: {card.Name}");
            }
            
            
        }


        public static void ShowDecks(List<Deck> decks)
        {
            int c = 0;
            Console.WriteLine("Select Deck: ");
            foreach (Deck deck in decks)
            {
                c++;
                Console.WriteLine($"[{c-1}] Deck {c} ");
            }
        }
        static void ShowCaptains(List<SpecialCard> captains)
        {
            int c = 0;
            Console.WriteLine("Select one captain: ");
            foreach (SpecialCard captain in captains)
            {
                c++;
                Console.WriteLine($"[{c - 1}] Captain: {captain.Name}: {captain.Effect} ");
            }
        }

        static void GetUserInput(int maxInput, bool stopper = false)
        {

        }

        static void ConsoleError(string message)
        {

        }

        static void ShowProgramMessage(string message)
        {

        }
        static void ShowListOptions(List<string> options, string message = null)
        {

        }




    }
}
