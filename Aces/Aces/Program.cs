using System;

namespace Aces
{
    internal class Program
    {
        // Determines if two cards entered by the user qualify as a pair of aces.
        static void Main(string[] args)
        {
            char card1, 
                 card2;
            Console.Write("Enter the character for the first card: ");
            card1 = char.Parse(Console.ReadLine());
            Console.Write("Enter the character for the second card: ");
            card2 = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if (card1 == '1' && card2 == '1' )
            {
                Console.WriteLine("Pair of aces -- both cards are aces");
            }

            else if ( card1 == '*' && card1 == '*' )
            {
                Console.WriteLine("Pair of aces -- both cards are jokers");
            }
            else if ( (card1 == '1' && card2 == '*') || (card1 == '*' && card2 == '1') )
            {
                Console.WriteLine("Pair of aces -- one card is an ace, the other is a joker");
            }
            else
            {
                Console.WriteLine("Not a pair of aces");
            }
        }
    }
}
