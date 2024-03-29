using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_CPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string GenerateCpf()
        {
            Random rng = new Random();
            string cpf = String.Empty;
            int sum1 = 0;
            int sum2 = 0;
            int findVerifyDigit = 10;
            int validationVerifyDigit = 11;

            do
            {
                for (int i = 0; i < 10; i++)
                {
                    int number = rng.Next(0, 10);
                    sum1 += number * (findVerifyDigit - i);
                    sum2 += number * (validationVerifyDigit - i);
                    cpf += number;
                }
            } while (
                cpf == "000000000" || cpf == "111111111" || cpf == "222222222" || cpf == "333333333" || cpf == "444444444"
                || cpf == "555555555" || cpf == "666666666" || cpf == "777777777" || cpf == "888888888" || cpf == "999999999"
                );

            int verifyDigit = sum1 % 11;

            if (verifyDigit < 2)
            {
                verifyDigit = 0;
            }
            else
            {
                verifyDigit -= 11;
            }

            sum2 += verifyDigit * 2;
            int verifyDigit2 = sum2 % 11;

            if (verifyDigit2 < 2)
            {
                verifyDigit2 = 0;
            }
            else
            {
                verifyDigit2 -= 11;
            }
            
            return $"{cpf}{verifyDigit}{verifyDigit2}";
        }

        private void GenerateCpfBtn_Click(object sender, EventArgs e)
        {
            CpfValueMasked.Text = GenerateCpf();
        }
    }
}