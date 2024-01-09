using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_corrida_de_caes
{
    public class Bet
    {
        //**ATRIBUTOS/ CAMPOS
        public int Amount; //Define a quantidade de dinheiro APOSTADA
        public int Dog; // Define o numero do cao na qual apostamos
        public Guy Bettor; //O cara que fez a aposta

        //****METODOS
        //Este metodo retorna uma STRING que DIZ quem fez a aposta, QUANTO dinheiro foi apostado,
        //e em qual CAO foi feita a aposta; se a quantidade for ZERO, a aposta nao foi feita ("Joao nao apostou")
        public string GetDescription()
        {
            return "A";
        }

        //o parametro deste metodo e o vencedor da corrida. Se o cao venceu
        //RETORNE  a quantidade apostada. De outra forma, retorne um valor negativo do valor apostado
        public int PayOut(int Winner)
        {
            return 0;
        }

    }
}
