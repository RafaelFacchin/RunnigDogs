using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_corrida_de_caes
{
    public class Aposta
    {
        //**ATRIBUTOS/ CAMPOS
        public int Valor; //Define a quantidade de dinheiro APOSTADA
        public int Cachorro; // Define o numero do cao na qual apostamos
        public Cara Apostador; //O cara que fez a aposta

        //****METODOS
        //Este metodo retorna uma STRING que DIZ quem fez a aposta, QUANTO dinheiro foi apostado,
        //e em qual CAO foi feita a aposta; se a quantidade for ZERO, a aposta nao foi feita ("Joao nao apostou")
        public string PegarDescricao()
        {
            if(Apostador.Carteira >= Valor)
            {
                this.Apostador.MyLabel.Text = this.Apostador.Nome + " apostador" + Valor + " reais no cachorro numero " + Cachorro;

            }
            return Apostador.MyLabel.Text;
        }

        //o parametro deste metodo e o vencedor da corrida. Se o cao venceu
        //RETORNE  a quantidade apostada. De outra forma, retorne um valor negativo do valor apostado
        public int Pagar(int Vencedor)
        {
            return Valor;
        }

    }
}
