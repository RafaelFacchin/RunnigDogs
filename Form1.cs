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
            CaraJoao = new Cara { Nome = "Joao", Carteira = 50, MyLabel = label5, MyRadioButton = radioButton1 };
            CaraBeto = new Cara { Nome = "Beto", Carteira = 75, MyLabel = label6, MyRadioButton = radioButton2 };
            CaraAlfredo = new Cara { Nome = "Alfredo", Carteira = 45, MyLabel = label7, MyRadioButton = radioButton3 };

            //***INSTANCIAR OBJETO APOSTA; LIGACAO entre o OBJ CARA com as suas APOSTAS
            ApJoao = new Aposta();
            CaraJoao.MinhaAposta = ApJoao;//LIGA o OBJ "CARA" ao OBJ "APOSTA" para poder Linkar a relacao entre os 2 objetos

            ApBeto = new Aposta();
            CaraBeto.MinhaAposta = ApBeto;

            ApAlfredo = new Aposta();
            CaraAlfredo.MinhaAposta = ApAlfredo;

            //***FAZER a LIMPEZA para as novas APOSTAS
            CaraJoao.LimparAposta();
            CaraBeto.LimparAposta();
            CaraAlfredo.LimparAposta();

            //ATUALIZAR as Labels
            CaraJoao.AtualizarLabels();
            CaraBeto.AtualizarLabels();
            CaraAlfredo.AtualizarLabels();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VERIFICAR qual "radioButton" esta marcado
            if (radioButton1.Checked == true)
            {
                ApJoao.Valor    = Convert.ToInt32(numericUpDown1.Value); //Associa o valor da APOSTA ao APOSTADOR
                ApJoao.Cachorro = Convert.ToInt32(numericUpDown2.Value); //ASSOCIA o APOSTADOR ao cachorro
                if (CaraJoao.Carteira >= ApJoao.Valor)
                {
                    aposta1 = true;
                    radioButton1.Enabled = false; //DETERMINA que o radioButton do apostador seja ativado apenas uma vez
                    radioButton1.Checked = false; //NAO PERMITE QUA A APOSTA SEJA feita novamente
                    ApJoao.PegarDescricao() ;//Pega a descricao INFORMANDO ao apostador o quanto foi apostado
                    CaraJoao.Carteira -= ApJoao.Valor;//RETIRA da carteira do apostador o valor da APOSTA
                    CaraJoao.AtualizarLabels();//ATUALIZAR a label do apostador
                }
                else
                {
                    MessageBox.Show("Voce nao possui dinheiro suficiente para apostar");
                    ApJoao.Valor = 0;
                }
            }

            if (radioButton2.Checked == true)
            {
                ApBeto.Valor = Convert.ToInt32(numericUpDown1.Value); //Associa o valor da APOSTA ao APOSTADOR
                ApBeto.Cachorro = Convert.ToInt32(numericUpDown2.Value); //ASSOCIA o APOSTADOR ao cachorro
                if (CaraBeto.Carteira >= ApBeto.Valor)
                {
                    aposta2 = true;
                    radioButton2.Enabled = false; //DETERMINA que o radioButton do apostador seja ativado apenas uma vez
                    radioButton2.Checked = false; //NAO PERMITE QUA A APOSTA SEJA feita novamente
                    ApBeto.PegarDescricao();//Pega a descricao INFORMANDO ao apostador o quanto foi apostado
                    CaraBeto.Carteira -= ApBeto.Valor;//RETIRA da carteira do apostador o valor da APOSTA
                    CaraBeto.AtualizarLabels();//ATUALIZAR a label do apostador
                }
                else
                {
                    MessageBox.Show("Voce nao possui dinheiro suficiente para apostar");
                    ApBeto.Valor = 0;
                }
            }

            if (radioButton3.Checked == true)
            {
                ApAlfredo.Valor = Convert.ToInt32(numericUpDown1.Value); //Associa o valor da APOSTA ao APOSTADOR
                ApAlfredo.Cachorro = Convert.ToInt32(numericUpDown2.Value); //ASSOCIA o APOSTADOR ao cachorro
                if (CaraAlfredo.Carteira >= ApAlfredo.Valor)
                {
                    aposta3 = true;
                    radioButton3.Enabled = false; //DETERMINA que o radioButton do apostador seja ativado apenas uma vez
                    radioButton3.Checked = false; //NAO PERMITE QUA A APOSTA SEJA feita novamente
                    ApAlfredo.PegarDescricao();//Pega a descricao INFORMANDO ao apostador o quanto foi apostado
                    CaraAlfredo.Carteira -= ApAlfredo.Valor;//RETIRA da carteira do apostador o valor da APOSTA
                    CaraAlfredo.AtualizarLabels();//ATUALIZAR a label do apostador
                }
                else
                {
                    MessageBox.Show("Voce nao possui dinheiro suficiente para apostar");
                    ApAlfredo.Valor = 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Winner;//QUEM GANHOU
            button1.Enabled = false; //DESATIVA A INTERFACE DE APOSTA
            button2.Enabled = false; //DESATIVA A INTERFACE DE APOSTA
            radioButton1.Checked = false;
            radioButton1.Enabled = false;
            radioButton2.Checked = false;
            radioButton2.Enabled = false;
            radioButton3.Checked = false;
            radioButton3.Enabled = false;

            while (Cachorro1.Correr() == false &&
                    Cachorro2.Correr() == false &&
                    Cachorro3.Correr() == false &&
                    Cachorro4.Correr() == false)
            {
                Application.DoEvents();//Permite que o Windows LIBERE o uso do mouse e teclado enquanto o programa executa
                System.Threading.Thread.Sleep(1); //ATRASA um pouco o tempo de execucao

            }
            //VERIFICA SE UM DOS CACHORROS GANHOU
            //CACHORRO 1
            if (Cachorro1.Correr() == true)
            {
                Winner = 1;
                this.CaraJoao.ColetarDinheiro(Winner);
                button1.Enabled = true;
                button2.Enabled = true;
                if (aposta1 == true && ApJoao.Cachorro == Winner)
                {
                    CaraJoao.Carteira += 2 * ApJoao.Valor;
                }
                if (aposta1 == true && ApJoao.Cachorro == Winner)
                {
                    CaraJoao.Carteira += 2 * ApJoao.Valor;
                }
                if (aposta2 == true && ApBeto.Cachorro == Winner)
                {
                    CaraBeto.Carteira += 2 * ApBeto.Valor;
                }
                if (aposta3 == true && ApAlfredo.Cachorro == Winner)
                {
                    CaraAlfredo.Carteira += 2 * ApAlfredo.Valor;
                }
            }

            //CACHORRO 2
            if (Cachorro2.Correr() == true)
            {
                Winner = 2;
                this.CaraJoao.ColetarDinheiro(Winner);
                button1.Enabled = true;
                button2.Enabled = true;
                if (aposta1 == true && ApJoao.Cachorro == Winner)
                {
                    CaraJoao.Carteira += 2 * ApJoao.Valor;
                }
                if (aposta1 == true && ApJoao.Cachorro == Winner)
                {
                    CaraJoao.Carteira += 2 * ApJoao.Valor;
                }
                if (aposta2 == true && ApBeto.Cachorro == Winner)
                {
                    CaraBeto.Carteira += 2 * ApBeto.Valor;
                }
                if (aposta3 == true && ApAlfredo.Cachorro == Winner)
                {
                    CaraAlfredo.Carteira += 2 * ApAlfredo.Valor;
                }
            }

            //CACHORRO 3
            if (Cachorro3.Correr() == true)
            {
                Winner = 3;
                this.CaraJoao.ColetarDinheiro(Winner);
                button1.Enabled = true;
                button2.Enabled = true;
                if (aposta1 == true && ApJoao.Cachorro == Winner)
                {
                    CaraJoao.Carteira += 2 * ApJoao.Valor;
                }
                if (aposta1 == true && ApJoao.Cachorro == Winner)
                {
                    CaraJoao.Carteira += 2 * ApJoao.Valor;
                }
                if (aposta2 == true && ApBeto.Cachorro == Winner)
                {
                    CaraBeto.Carteira += 2 * ApBeto.Valor;
                }
                if (aposta3 == true && ApAlfredo.Cachorro == Winner)
                {
                    CaraAlfredo.Carteira += 2 * ApAlfredo.Valor;
                }
            }

            //CACHORRO 4
            if (Cachorro4.Correr() == true)
            {
                Winner = 4;
                this.CaraJoao.ColetarDinheiro(Winner);
                button1.Enabled = true;
                button2.Enabled = true;
                if (aposta1 == true && ApJoao.Cachorro == Winner)
                {
                    CaraJoao.Carteira += 2 * ApJoao.Valor;
                }
                if (aposta1 == true && ApJoao.Cachorro == Winner)
                {
                    CaraJoao.Carteira += 2 * ApJoao.Valor;
                }
                if (aposta2 == true && ApBeto.Cachorro == Winner)
                {
                    CaraBeto.Carteira += 2 * ApBeto.Valor;
                }
                if (aposta3 == true && ApAlfredo.Cachorro == Winner)
                {
                    CaraAlfredo.Carteira += 2 * ApAlfredo.Valor;
                }
            }

            //ATUALIZAR LABELS DOS CARAS
            CaraJoao.AtualizarLabels();
            CaraBeto.AtualizarLabels();
            CaraAlfredo.AtualizarLabels();

            //RETORNO DOS CACHORROS NA POSICAO INICIAL!!!
            Cachorro1.VoltarPosicaoInicial();
            Cachorro2.VoltarPosicaoInicial();
            Cachorro3.VoltarPosicaoInicial();
            Cachorro4.VoltarPosicaoInicial();

            //DESMARCAR OS "radioButton`s"
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            //HABILITAR OS "radioButton`s"
            radioButton1.Enabled = true; //Permite interagir com o radioButton1
            radioButton2.Enabled = true; //Permite interagir com o radioButton2
            radioButton3.Enabled = true; //Permite interagir com o radioButton3

            //LIBERA as apostas p/ jogar novamente
            aposta1 = false;
            aposta2 = false;
            aposta3 = false;

            //ZERA as apostas PREVIAS
            CaraJoao.LimparAposta();
            CaraBeto.LimparAposta();
            CaraAlfredo.LimparAposta();

            //DESABILITA radioButton, caso o apostador esteja sem dinheiro
            if (CaraJoao.Carteira == 0)
            {
                CaraJoao.MyRadioButton.Enabled = false;
            }
            if (CaraBeto.Carteira == 0) 
            {
                CaraBeto.MyRadioButton.Enabled = false;
            }
            if (CaraAlfredo.Carteira == 0)
            {
                CaraAlfredo.MyRadioButton.Enabled = false;
            }

        }
    }
}
