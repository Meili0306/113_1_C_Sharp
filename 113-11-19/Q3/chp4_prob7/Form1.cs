using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chp4_prob7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal income;    //收入
            decimal taxrate;   //稅率
            decimal payable;   //應交稅額
            decimal netIncome; //淨收入


            //以下作答
            income = decimal.Parse(incomeTextBox.Text);
            taxrate = 0;

            if (income <= 590000)
            {
                taxrate = 0.05m;
                payable = income * taxrate ;
            }
            else if (income <= 1330000)
            {
                taxrate = 0.12m;
                payable = 590000 * 0.05m + (income - 590000) * 0.12m;
            }
            else if (income <= 2660000)
            {
                payable = 590000 * 0.05m + (1330000 - 590000) * 0.12m + (income - 1330000) * 0.20m;
            }
            else if (income <= 4980000)
            {
                payable = 590000 * 0.05m + (1330000 - 590000) * 0.12m + (2660000 - 1330000) * 0.20m + (income - 2660000) * 0.30m;
            }
            else
            {
                payable = 590000 * 0.05m + (1330000 - 590000) * 0.12m + (2660000 - 1330000) * 0.20m + (4980000 - 2660000) * 0.30m + (income - 4980000) * 0.40m;
            }

            netIncome = income - payable;

            lblPayable.Text = "Payable Tax:" + payable.ToString("c");   
            lblNetIncome.Text = "NetIncome:" + netIncome.ToString("c");
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
            
        }

        

      
      
    

