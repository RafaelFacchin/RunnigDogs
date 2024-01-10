using System;
using System.Collections.Generic;
using System.Drawing;// Biblioteca itilizada p/ movimento de figuras
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_corrida_de_caes
{
    public class Cachorro //ESTA classe CONTROLA  a posicao da Picture na pista durante a corrida
    {
        //**ATRIBUTOS/ CAMPOS
        public int PontoInicial = 1; //Posicao onde pictureBox inicia (Coord. "x"
        public int LarguraDaPista = 750; //O tamanho da pista de corrida
        public PictureBox MyPictureBox = null; // Meu objeto PictureBox
        public int Location = 0; //Minha posicao na pista
        public Random MeuRandom; //Uma instancia randomizada

        //****METODOS
        public bool Correr()
        {
            //AVANCE 1, 2 ,3 ou 4 espacos aleatoriamente (MOVE DA ESQUERDA P/  A DIREITA)
            int correu;
            MeuRandom = new Random(); //Objeto RANDOM (gera os numeros aleatorios)
            correu = MeuRandom.Next(0, 10); //Next: Gera um numero inteiro aleatorio entre 0 e 10
            correu = (correu * MeuRandom.Next(0, 2)) % 5; // "% 5" pega o resto da divisao por 5 (1,2,3,4)
            correu = (correu % 4) + 1; //***"correu %4"= GERA numeros do resto da divisao por 4 mais 1

            //Atualize a posicao de PictureBox no formulario
            Point p = MyPictureBox.Location; // Determina a localizacao do Piture box (o cachorro)
            p.X += correu;
            MyPictureBox.Location = p;

            //Retorne TRUE se eu ganhar a corrida
            if(p.X >= LarguraDaPista)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void VoltarPosicaoInicial()
        {
            //REDEFINIR minha posicao p/ a linha de partida
            Point p = this.MyPictureBox.Location;//ATRINUI o valor da localizacao ao gif correspondente
            p.X = PontoInicial;// RETORNA ao valor inicial
            this.MyPictureBox.Location = p;// INDICA  para a imagem ir na mesma posicao em que "p" esta
        }

   

    }
}
