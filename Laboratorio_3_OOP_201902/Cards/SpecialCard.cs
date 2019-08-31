using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3_OOP_201902.Cards
{
    public class SpecialCard : Card
    {
        //Atributos
        private string buffType;

        //Propiedades
        public string BuffType
        {
            get
            {
                return buffType;
            }
            set
            {
                buffType = value;
            }
        }
        //Constructor
        public SpecialCard(string name, string enumtype, string effect)
        {
            Name = name;
            EnumType = enumtype;
            Effect = effect;
            BuffType = null;
        }


    }
}
