using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_corrida_de_caes
{
    public partial class Form1 : Form
    {
        //***DEFINICAO DOS CACHORROS DE CORRIDA
        Cachorro Cachorro1;
        Cachorro Cachorro2;
        Cachorro Cachorro3;
        Cachorro Cachorro4;

        //****DEFINICAO DOS APOSTADORES
        Cara CaraJoao;
        Cara CaraBeto;
        Cara CaraAlfredo;

        //****APOSTAS DOS CARAS
        Aposta ApJoao;
        Aposta ApBeto;
        Aposta ApAlfredo;

        //****VARIAVEIS DIVERSAS
        public bool vencedor;
        public bool aposta1;
        public bool aposta2;
        public bool aposta3;

        public Form1()
        {
            InitializeComponent();

            //***INSTANCIAR OBJETO CACHORRO; LIGACAO entre o OBJ cachorro e sua PictureBox correspondente
            Cachorro1 = new Cachorro();
            Cachorro1.MyPictureBox = pictureBox2;

            Cachorro2 = new Cachorro();
            Cachorro2.MyPictureBox = pictureBox3;

            Cachorro3 = new Cachorro();
            Cachorro3.MyPictureBox = pictureBox4;

            Cachorro4 = new Cachorro();
            Cachorro4.MyPictureBox = pictureBox5;

            //***INSTANCIAR OBJETO CARA; LIGACAO entre o OBJ CARA e seus label`s e botoes
            CaraJoao = new Cara { Nome = "Joao", Carteira = 50, MyLabel = label5, MyRadioButton = radioButton1};
            CaraBeto = new Cara { Nome = "Beto", Carteira = 75, MyLabel = label6, MyRadioButton = radioButton2 };
            CaraAlfredo = new Cara { Nome = "Alfredo", Carteira = 45, MyLabel = label7, MyRadioButton = radioButton3 };

            //***INSTANCIAR OBJETO APOSTA; LIGACAO entre o OBJ CARA com as suas APOSTAS
            ApJoao = new Aposta();
            CaraJoao.MinhaAposta = ApJoao;//LIGA o OBJ "CARA" ao OBJ "APOSTA" para poder Linkar a relacao entre os 2 objetos
            
            ApBeto = new Aposta();
            CaraBeto.MinhaAposta = ApBeto;

            ApAlfredo = new Aposta();
            CaraAlfredo.MinhaAposta = ApAlfredo;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
