using Laboratorio_3_OOP_201902.Cards;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laboratorio_3_OOP_201902
{
    public class Game
    {
        //Atributos
        private Player[] players;
        private Player activePlayer;
        private List<Deck> decks;
        private Board boardGame;
        private bool endGame;

        //Constructor
        public Game(Player[] players, Player activeplayer, List<Deck> decks, Board boardgame, bool endgame)
        {
            this.players = players;
            this.decks = decks; 
            this.boardGame = boardgame;
            this.activePlayer = activeplayer;
            this.endGame = endgame;
            
        }
     
        //Propiedades
        public Player[] Players
        {
            get
            {
                return this.players;
            }
        }
        public Player ActivePlayer
        {
            get
            {
                return this.activePlayer;
            }
            set
            {
                activePlayer = value;
            }
        }
        public List<Deck> Decks
        {
            get
            {
                return this.decks;
            }
        }
        public Board BoardGame
        {
            get
            {
                return this.boardGame;
            }
            set
            {
                boardGame = value;
            }
        }
        public bool EndGame
        {
            get
            {
                return this.endGame;
            }
            set
            {
                endGame = value;
            }
        }

        //Metodos
        public bool CheckIfEndGame()
        {
            if (players[0].LifePoints == 0 || players[1].LifePoints == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetWinner()
        {
            if (players[0].LifePoints == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void Play()
        {
            throw new NotImplementedException();
        }

        public void addDeck()
        {
            
            List<Deck> decku = new List<Deck>();
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Files\Decks.txt";
            string[] carda = new string[6];
            using (StreamReader deckFile = new StreamReader(path))

            {
                
                string line;
                Console.WriteLine(path);
                while ((line = deckFile.ReadLine()) != null)

                {
                    Deck deckd = new Deck();
                    deckd.Cards = new List<Card>();
                    //Console.WriteLine(line);//
                    if (line == "START")
                    {
                        Console.WriteLine(line);
                        
                        while ((line = deckFile.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                            carda = line.Split(",", 6, StringSplitOptions.RemoveEmptyEntries);

                            if (carda[0] == "CombatCard")
                            {
                                Card carte = new CombatCard(carda[1], carda[2], carda[3], int.Parse(carda[4]), bool.Parse(carda[5]));
                                deckd.AddCard(carte);

                            }
                            if(carda[0]=="SpecialCard")
                            {
                                deckd.AddCard(new SpecialCard(carda[1], carda[2], carda[3]));
                            }
                            if(line == "END")
                            {
                                break;
                            }
                        }
                        decku.Add(deckd);  
                    }

                    

                }
                deckFile.Close();

            }
            this.decks = decku;
        }
    }
}
