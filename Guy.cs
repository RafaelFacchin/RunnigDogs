using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_corrida_de_caes
{
    public class Guy
    {
        //**ATRIBUTOS/ CAMPOS
        public string Name; //O nome do cara
        public Bet MyBet; // Uma instancia de Bet() qu etem sua aposta
        public int cash; //Quanto dinheiro ele tem

        //Os ultimos dois campos sao os controles no formulario da GUI dos caras
        public RadioButton MyRadioButton; //Meu radioButton
        public Label MyLabel; //Minha Label

        //****METODOS

        //Defina minha ETIQUETA para a descricao da minha aposta e a etiqueta em meu
        //botao de radio para mostrar meu dinheiro ("Ex: Joao tem 43 reais")
        public void UpdateLabels()
        {
            
        }

        //REDEFINE a aposta p/ que seja == 0
        public void ClearBet()
        {

        }

        //Metodo para fazer uma NOVA aposta e armazena-la em uma campo de APOSTA;
        //Retorna TRUE se o cara teve dinheiro suficiente p/ apostar
        public bool PlaceBet(int Amount, int Dog)
        {
            return false;
        }

        //Metodo p/ cobrar a aposta GANHA
        public void Collect(int Winner)
        {

        }


    }
}
