using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogo_Carrefour_Woman.SRC.Entities
{
    public class Topapa : Hero
    {
        public Topapa(string Name,int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Criou uma poção mágica";
        }

        public string Attack(int Pocao){

            if (Pocao > 5){

                return this.Name + " a poção mágica deu certo! Legal! ";
            }
            else{

                return this.Name + " Algo falhou, vamos tentar de novo... ";
            }
            
        }

    }
}