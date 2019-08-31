using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3_OOP_201902.Cards
{
    public abstract class Card
    {
        //Atributos
        protected string name;
        protected string enumType;
        protected string effect;

        //Constructor
        public Card()
        {

        }

        //Propiedades
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string EnumType
        {
            get
            {
                return this.enumType;
            }
            set
            {
                this.enumType = value;
            }
        }
        public string Effect
        {
            get
            {
                return this.effect;
            }
            set
            {
                this.effect = value;
            }
        }
        
    }
}
