using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogo_Carrefour_Woman.SRC.Entities
{
    public abstract class Hero
    {
        public Hero(string Name,int  Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero(){

        }

        public string Name;
        public int Level;
        public string HeroType;


        public override String ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }        
            
        public virtual String Attack(){
            return this.Name + " Atacou com sua espada!";
        }
    }
}