using Laboratorio_3_OOP_201902.Cards;
using System;
using System.Collections.Generic;
using System.Text;

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
        public Game()
        {
            this.players = new array<Player>();
            this.decks = new List<Deck>();
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
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Files\Decks.txt";
            using (StreamReader deckFile = new StreamReader(Path))
            {
                int cont = 0;
                string line;

                while ((line = deckFile.ReadLine()) != null)
                {
                    if (line == "START")
                    {
                        deckFile.Read();
                        while (line =! "end")
                        {

                        }
                    cont++;
                }
                deckFile.Close();
                
            }
        }
    }
}
