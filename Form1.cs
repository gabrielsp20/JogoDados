using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDados
{
    public partial class Form1 : Form
    {
        private Random rdndado = new Random();
        bool flagjogar1;
        bool flagjogar2;
        int valor_Dado1;
        int valor_Dado2;

        public Form1()
        {
            InitializeComponent();
            valorPartida.Text = "5";
            flagjogar1 = true;
            flagjogar2 = true;
        }
        private void comparaDados()
        {
            int ponto1Int = Convert.ToInt16(ponto1.Text);
            int ponto2Int = Convert.ToInt16(ponto2.Text);

            valorPartida.ReadOnly = true;
            if (!flagjogar1 && !flagjogar2)
            {
                Console.WriteLine("Os Dois Jogaram\n");
                if( valor_Dado1 < valor_Dado2 )
                {

                    ponto1Int = ponto1Int - 1;
                    ponto1.Text = Convert.ToString(ponto1Int);
                }
                if ( valor_Dado2 < valor_Dado1)
                {
                    ponto2Int = ponto2Int - 1;
                    ponto2.Text = Convert.ToString(ponto2Int);
                }
                if((ponto1Int == 0) || (ponto2Int == 0)){

                    if(ponto1Int == 0)
                    {
                        vencedor.Text = "JOGADOR2";
                    }
                    else
                    {
                        vencedor.Text = "JOGADOR1";
                    }
                    jogar1.Text = "FIM";
                    jogar2.Text = "FIM";
                }
                else
                {
                    flagjogar1 = true;
                    flagjogar2 = true;
                    jogar1.Text = "JOGAR!!!";
                    jogar2.Text = "JOGAR!!!";
                }
            }
        }

        private void jogar1_Click(object sender, EventArgs e)
        {
            

            if (flagjogar1)
            {

                valor_Dado1 = rdndado.Next(1, 7);
                switch (valor_Dado1)
                {
                    case 1:
                        Dado1.Image = Properties.Resources.dado0;
                        break;
                    case 2:
                        Dado1.Image = Properties.Resources.dado1;
                        break;
                    case 3:
                        Dado1.Image = Properties.Resources.dado2;
                        break;
                    case 4:
                        Dado1.Image = Properties.Resources.dado3;
                        break;
                    case 5:
                        Dado1.Image = Properties.Resources.dado4;
                        break;
                    case 6:
                        Dado1.Image = Properties.Resources.dado5;
                        break;
                    case 7:
                        Dado1.Image = Properties.Resources.dado6;
                        break;
                }
                flagjogar1 = false;
                jogar1.Text = "OK";
                comparaDados();

            }

        }

        private void jogar2_Click(object sender, EventArgs e)
        {
           
            


            if (flagjogar2) 
            { 
                valor_Dado2 = rdndado.Next(1, 7);
                switch (valor_Dado2)
                {
                case 1:
                    Dados2.Image = Properties.Resources.dado0;
                    break;
                case 2:
                    Dados2.Image = Properties.Resources.dado1;
                    break;
                case 3:
                    Dados2.Image = Properties.Resources.dado2;
                    break;
                case 4:
                    Dados2.Image = Properties.Resources.dado3;
                    break;
                case 5:
                    Dados2.Image = Properties.Resources.dado4;
                    break;
                case 6:
                    Dados2.Image = Properties.Resources.dado5;
                    break;
                case 7:
                    Dados2.Image = Properties.Resources.dado6;
                    break;
                }
                flagjogar2 = false;
                jogar2.Text = "OK";
                comparaDados();
            }

        }

        private void reiniciar_Click(object sender, EventArgs e)
        {
            Dado1.Image = Properties.Resources.dado0;
            Dados2.Image = Properties.Resources.dado0;
            flagjogar1 = true;
            flagjogar2 = true;
            jogar1.Text = "JOGAR!!!";
            jogar2.Text = "JOGAR!!!";
            valorPartida.ReadOnly = false;
            ponto1.Text = valorPartida.Text;
            ponto2.Text = valorPartida.Text;
            
        }

        private void valorPartida_TextChanged(object sender, EventArgs e)
        {
            ponto1.Text = valorPartida.Text;
            ponto2.Text = valorPartida.Text;
        }
    }
}
