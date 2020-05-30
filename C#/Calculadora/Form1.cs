using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string visor = "0";
        char operacaoAtual;
        bool operacaoUso;
        bool operacaoUso1;
        bool operacaoUso2;
        bool pontoUso = false;
        bool igualClique;
        double num1;
        double num2;
        double Result;
        double memoResult;

        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void TestaOperacaoLimpaVisor() 
        { 
            if ((operacaoUso == true) || (visor.Equals("0"))) 
            { 
                operacaoUso = false; 
                visor = ""; 
                LblVisor.Text = (""); 
            } 
        }
 
        public void ExecutaOperacao()
        { 
            if (operacaoUso2 == false) 
            {
                if (operacaoUso1 == true) 
                {  
                    num2 = Double.Parse(LblVisor.Text);
                    
                    switch (operacaoAtual) 
                    { 
                        case '/':
                            Result = num1 + num2; 
                            LblVisor.Text = Convert.ToString(Result); 
                            
                            if (num2 == 0)
                            { 
                                LblVisor.Text = "ERROR"; 
                                operacaoUso = true; 
                            }else if (num1 != 0) 
                            {
                                Result = num1 / num2; 
                                LblVisor.Text=Convert.ToString(Result);
                            } 
                            break;
                        
                        case '-':
                            Result = num1 - num2; 
                            LblVisor.Text=Convert.ToString(Result); 
                            break;

                        case '+':
                            Result = num1 + num2;
                            LblVisor.Text = Convert.ToString(Result);
                            break;
                        
                        case '*':
                            Result = num1 * num2; 
                            LblVisor.Text = Convert.ToString(Result);
                            break;
                    }
                    num1 = Result;
                }else if (operacaoUso1 == false) 
                { 
                    num1 = double.Parse(LblVisor.Text); 
                } 
                operacaoUso2 = true;
            } 
            operacaoUso1 = true; 
            operacaoUso = true; 
            pontoUso = false;
        }

        public void Memoria()
        { 
            if (operacaoUso1 == true)
            { 
                num2 = Double.Parse(LblVisor.Text); 
                switch (operacaoAtual) 
                { 
                    case '+': 
                        memoResult = num1 + num2;
                        LblVisor.Text = Convert.ToString(memoResult);
                        break; 
                    case '-':
                        memoResult = num1 - num2;
                        LblVisor.Text = Convert.ToString(memoResult); 
                        break;
                    case '/': 
                        if (num2 == 0) 
                    { 
                        LblVisor.Text ="ERROR";
                        operacaoUso = true; 
                    }else if (num1 != 0) 
                    {
                        memoResult = num1 / num2;
                        LblVisor.Text = Convert.ToString(memoResult);
                    }
                        break;
                    case '*':
                        memoResult = num1 * num2;
                        LblVisor.Text = Convert.ToString(memoResult); 
                        break;         
                }
            } 
            operacaoUso = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculadora";
            LblVisor.Text = "";
        }

        public void VerificaStatusCalculadora()
        {
            if (BtnDesliga.Text == "ON")
            {
                BtnDesliga.Text = "OFF";
                Timer1.Enabled = true;
                Timer1.Start();
            }
            else
            {
                BtnDesliga.Text = "ON";
                CalcStatusTxtBox.Text = "Status: OFF";
                LblVisor.Text = "";
                CalcStatusTxtBox.Visible = false;
                LigandoCalcTxtBox.Text = "Calculadora desligada:" + Environment.NewLine + "Clique no botão 'ON' para ligar a calculadora";
                CalcOffPanel.Visible = true;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            count += 1;
            LigandoCalcTxtBox.Text = "Ligando Calculadora...";
            if (count == 10)
            {
                count = 0;
                LblVisor.Text = "0";
                CalcStatusTxtBox.Text = "Status: ON";
                CalcStatusTxtBox.Visible = true;
                CalcOffPanel.Visible = false;
                Timer1.Enabled = false;
                Timer1.Stop();
            }
        }    

        private void BtnDesliga_Click(object sender, EventArgs e)
        {
            VerificaStatusCalculadora();
        }

        private void SobreCalculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutApp AboutApp = new AboutApp();
            AboutApp.Show();
        }

        private void EncerrarCalculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TestaOperacaoLimpaVisor();
            visor = LblVisor.Text; 
            visor = visor + "0"; 
            LblVisor.Text = Convert.ToString(visor);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TestaOperacaoLimpaVisor();
            visor = LblVisor.Text;
            visor = visor + "1";
            LblVisor.Text = Convert.ToString(visor);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TestaOperacaoLimpaVisor();
            visor = LblVisor.Text;
            visor = visor + "2";
            LblVisor.Text = Convert.ToString(visor);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TestaOperacaoLimpaVisor();
            visor = LblVisor.Text;
            visor = visor + "3";
            LblVisor.Text = Convert.ToString(visor);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TestaOperacaoLimpaVisor();
            visor = LblVisor.Text;
            visor = visor + "4";
            LblVisor.Text = Convert.ToString(visor);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TestaOperacaoLimpaVisor();
            visor = LblVisor.Text;
            visor = visor + "5";
            LblVisor.Text = Convert.ToString(visor);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TestaOperacaoLimpaVisor();
            visor = LblVisor.Text;
            visor = visor + "6";
            LblVisor.Text = Convert.ToString(visor);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TestaOperacaoLimpaVisor();
            visor = LblVisor.Text;
            visor = visor + "7";
            LblVisor.Text = Convert.ToString(visor);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TestaOperacaoLimpaVisor();
            visor = LblVisor.Text;
            visor = visor + "8";
            LblVisor.Text = Convert.ToString(visor);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TestaOperacaoLimpaVisor();
            visor = LblVisor.Text;
            visor = visor + "9";
            LblVisor.Text = Convert.ToString(visor);
        }

        private void BtnPonto_Click(object sender, EventArgs e)
        {
            TestaOperacaoLimpaVisor(); 
            visor = LblVisor.Text; 
            if (pontoUso == false) 
            { 
                if ((visor.Equals("0"))||(visor.Equals(""))) 
                { 
                    visor = "0."; 
                    LblVisor.Text = visor; 
                }else 
                {
                    visor = LblVisor.Text; 
                    visor = visor +"."; 
                    LblVisor.Text = visor;
                } 
                pontoUso = true;
            }
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            ExecutaOperacao(); 
            operacaoAtual = '+';
        }

        private void BtnSubtrai_Click(object sender, EventArgs e)
        {
            ExecutaOperacao();
            operacaoAtual = '-';
        }

        private void BtnMultiplica_Click(object sender, EventArgs e)
        {
            ExecutaOperacao();
            operacaoAtual = '*';
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            ExecutaOperacao();
            operacaoAtual = '/';
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (operacaoUso1 == true) 
            {  
                if (igualClique == false) 
                { 
                    num2 = double.Parse(LblVisor.Text); 
                    igualClique = true; 
                }
                switch (operacaoAtual) 
                {
                    case '+': 
                        Result = num1 + num2;
                        LblVisor.Text = Convert.ToString(Result); 
                        break;
                    case '/': 
                        if (num2 == 0) 
                        { 
                            LblVisor.Text = "ERROR"; 
                            operacaoUso = true;
                        }else if
                            (num1 != 0) 
                        { 
                            Result = num1 / num2;
                            LblVisor.Text = Convert.ToString(Result); 
                        } break;
                    case '-':
                        Result = num1 - num2;
                        LblVisor.Text = Convert.ToString(Result);
                        break;
                    case '*':
                        Result = num1 * num2;
                        LblVisor.Text = Convert.ToString(Result); 
                        break;         
                }
                num1 = Result;
            }else if (operacaoUso1 == false)
            {  
                num1 = double.Parse(LblVisor.Text); 
            }

            operacaoUso=true; 
            operacaoUso1=true; 
            pontoUso=false; 
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LblVisor.Text = "0";
            visor = "0"; 
            operacaoUso = false; 
            operacaoUso1 = false;
            operacaoUso2 = false; 
            igualClique = false; 
            pontoUso = false;
            num1 = 0; 
            num2 = 0;
            Result = 0; 
            operacaoAtual = ' ';
        }

        private void BtnPorcent_Click(object sender, EventArgs e)
        {
            if (operacaoUso2 == false) 
            { 
                if (operacaoUso1 == true) 
                { 
                    num2 = Double.Parse(LblVisor.Text); 
                    switch (operacaoAtual) 
                    { 
                        case '+':
                            Result = num1 + (num1 * (num2 / 100));
                            LblVisor.Text = Convert.ToString(Result);
                            break; 
                        case '/': if (num2 == 0) 
                        { 
                            LblVisor.Text = "ERROR"; 
                            operacaoUso = true; 
                        }else if (num1 != 0) 
                        {
                            Result = num1 / (num2 / 100);
                            LblVisor.Text = Convert.ToString(Result); 
                        } 
                        break; 
                        case '-':
                        Result = num1 - (num1 * (num2 / 100));
                        LblVisor.Text = Convert.ToString(Result); 
                            break; 
                        case '*':
                            Result = num1 * (num2 / 100);
                            LblVisor.Text = Convert.ToString(Result); 
                            break; 
                    } 
                    num1 = Result; 
                }else if (operacaoUso1 == false) 
                { 
                    num1 = Double.Parse(LblVisor.Text); 
                } 
                operacaoUso2 = true; 
            } 
            operacaoUso1 = true;
            operacaoUso = true;
            pontoUso = false;
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(LblVisor.Text);
            Result = Math.Pow(num1, 2);
            operacaoUso = true; 
            LblVisor.Text = Convert.ToString(Result);
        }

        private void BtnRaiz_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(LblVisor.Text); 
            Result = Math.Sqrt(num1);
            operacaoUso = true; 
            LblVisor.Text = Convert.ToString(Result);
        }

        private void BtnCorrige_Click(object sender, EventArgs e)
        {
            if (operacaoUso == false) 
            { 
                visor = LblVisor.Text; 
                if (visor.Length > 0) 
                { 
                    visor = visor.Substring(0, visor.Length - 1);
                } 
                LblVisor.Text = visor; 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operacaoUso == false)
            {
                visor = LblVisor.Text;
                if (visor.Length > 0)
                {
                    visor = visor.Substring(0, visor.Length - 1);
                }
                LblVisor.Text = visor;
            }
        }

        private void BtnMMais_Click(object sender, EventArgs e)
        {
            Memoria();
            memoResult = memoResult + memoResult;
        }

        private void BtnMMenos_Click(object sender, EventArgs e)
        {
            Memoria();
            memoResult = memoResult - memoResult;
        }

        private void BtnMMostra_Click(object sender, EventArgs e)
        {
            LblVisor.Text = Convert.ToString(memoResult); 
            operacaoUso = true;
        }

        private void BtnMLimpa_Click(object sender, EventArgs e)
        {
            memoResult = 0;  
        }              
    }
}
