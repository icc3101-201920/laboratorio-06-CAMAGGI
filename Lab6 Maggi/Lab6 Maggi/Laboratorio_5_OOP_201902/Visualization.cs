using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Laboratorio_5_OOP_201902.Cards;
using Laboratorio_5_OOP_201902.Enums;

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
                
                if  (card.Type == EnumType.melee ||
                     card.Type == EnumType.range ||
                     card.Type == EnumType.longRange)
                    {
                    CombatCard tempCard =card as CombatCard;
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"||{c++}: {card.Name} ({card.Type.ToString()}): {tempCard.AttackPoints}||");
                    System.Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{c++}: {card.Name} ({card.Type.ToString()})");
                    System.Console.ForegroundColor = ConsoleColor.White;
                }
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

        public static void ConsoleError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public static void ShowProgramMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void ShowListOptions(List<string> options, string message = null)
        {

        }




    }
}
