using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_corrida_de_caes
{
    public class GreyHound //ESTA classe CONTROLA  a posicao da Picture na pista durante a corrida
    {
        //**ATRIBUTOS/ CAMPOS
        public int StartingPosition; //Onde pictureBox inicia
        public int RaceTrackLenght; //O tamanho da pista de corrida
        public PictureBox MyPictureBox = null; // Meu objeto PictureBox
        public int Location = 0; //Minha posicao na pista
        public Random Randomizer; //Uma instancia randomizada

        //****METODOS
        public bool Run()
        {
            //AVANCE 1, 2 ,3 ou 4 espacos aleatoriament

            //Atualize a posicao de PictureBox no formulario

            //Retorne TRUE se eu ganhar a corrida
            return true;
        }

        public void TakeStartingPosition()
        {
            //REDEFINIR minha posicao p/ a linha de partida
        }

        //????
        //Point p = MyPictureBox.Location;
        //p.X += distance;


    }
}
