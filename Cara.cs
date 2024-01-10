using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_corrida_de_caes
{
    public class Cara
    {
        //**ATRIBUTOS/ CAMPOS
        public string Nome; //O nome do cara
        public Aposta MinhaAposta; // Uma instancia de Bet() qu etem sua aposta
        public int Carteira; //Quanto dinheiro ele tem

        //Os ultimos dois campos sao os controles no formulario da GUI dos caras
        public RadioButton MyRadioButton; //Meu radioButton
        public Label MyLabel; //Minha Label

        //****METODOS

        //Defina minha ETIQUETA para a descricao da minha aposta e a etiqueta em meu
        //botao de radio para mostrar meu dinheiro ("Ex: Joao tem 43 reais")
        public void AtualizarLabels()
        {
            MyRadioButton.Text = Nome + " tem " + Carteira + " Reais.";
        }

        //REDEFINE a aposta p/ que seja == 0
        public void LimparAposta()
        {
            MyLabel.Text = "Nao houve nenhuma aposta do " + Nome;
            MinhaAposta.Valor = 0;
        }

        //Metodo para fazer uma NOVA aposta e armazena-la em uma campo de APOSTA;
        //Retorna TRUE se o cara teve dinheiro suficiente p/ apostar
        public bool Apostar(int Quantia, int Cachorro)
        {
            Quantia = this.MinhaAposta.Valor;// DEFINE o VALOR da aposta
            Cachorro = this.MinhaAposta.Cachorro;// DEFINE o cachorro em que sera feita a aposta
            
            //***TESTE DE VALOR PARA APOSTA
            if(Quantia > Carteira)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Metodo p/ cobrar a aposta GANHA
        public void ColetarDinheiro(int Vencedor)
        {
            MessageBox.Show("O Cachorro vencedor eh o numero " + Vencedor, "Cachorro vencedor!");
        }


    }
}
