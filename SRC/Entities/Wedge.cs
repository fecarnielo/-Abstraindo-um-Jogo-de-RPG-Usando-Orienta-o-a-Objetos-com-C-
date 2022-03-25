using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogo_Carrefour_Woman.SRC.Entities
{
    public class Wedge : Hero
     {
        public Wedge(string Name,int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Defendeu com seu super escudo!!! ";
        }
            
     }

 }
