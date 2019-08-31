using Laboratorio_3_OOP_201902.Cards;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Laboratorio_3_OOP_201902
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            cards.Add(new CombatCard("Goblin", "melee", null, 5, false));
            cards.Add(new SpecialCard("Snow", "weather", "All LongRange attack points to 1"));
            cards.Add(new SpecialCard("General Harris", "captain", "All LongRange attack points to 10"));
            cards.Add(new SpecialCard("General Smith", "captain", "All Range attack points to 10"));
            cards.Add(new SpecialCard("Motivation", "buff", "All minions attack double on selected line"));
            cards.Add(new CombatCard("Destructor", "longRange", null, 10, true));
            Console.WriteLine(cards[1].GetType().Name == nameof(Card));
            Board board = new Board();
            board.AddCard(cards[2],0);
            board.AddCard(cards[1]);
            Console.WriteLine(board.PlayerCards[0]["captain"][0].Name);
            Console.WriteLine(board.WeatherCards[0].Name);
            board.AddCard(cards[3], 1);
            Console.WriteLine(board.PlayerCards[1]["captain"][0].Name);
            board.AddCard(cards[4], 0, "melee");
            Console.WriteLine(board.PlayerCards[0]["buffmelee"][0].Name);
            board.AddCard(cards[4], 0, "range");
            Console.WriteLine(board.PlayerCards[0]["buffrange"][0].Name);
            board.AddCard(cards[0], 0);
            Console.WriteLine(String.Join(", ", board.GetMeleeAttackPoints()));
            board.AddCard(cards[0], 0);
            Console.WriteLine(String.Join(", ", board.GetMeleeAttackPoints()));
            Console.WriteLine(String.Join(", ", board.GetRangeAttackPoints()));
            board.DestroyCards();
            Console.WriteLine(board.PlayerCards[0]["captain"][0].Name);
            Console.WriteLine(String.Join(", ", board.GetMeleeAttackPoints()));
            Console.WriteLine(String.Join(", ", board.GetRangeAttackPoints()));
            Console.WriteLine(board.WeatherCards.Count);
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Files\Decks.txt";
            Player[] jugadores = new Player[2];
            Player activo = new Player();
            List<Deck> mazo = new List<Deck>();
            Board Tabla = new Board();
            bool j = true;
            List<SpecialCard> capi = new List<SpecialCard>();
            Game game = new Game(jugadores,activo,mazo,Tabla,j,capi);
            game.addDeck();
            game.AddCaptains();
            //Console.WriteLine(game.Captains.Count());//
            //Console.WriteLine("hola");//
            //Console.WriteLine(game.Decks.Count());//
            /*for (int k=0; k<game.Decks.Count(); k++)
            {
                for(int i = 0; i < game.Decks[k].Cards.Count(); i++)
                {
                    
                    Console.WriteLine(game.Decks[k].Cards[i].Name);

                }
                
            }
            
            for(int p = 0; p < game.Captains.Count(); p++)
            {
                Console.WriteLine(game.Captains[p].Name);
            }
            */
        }
    }
}
