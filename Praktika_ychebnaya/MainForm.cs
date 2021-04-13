using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_ychebnaya
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRaschet_Click(object sender, EventArgs e)
        {
            double  stavka, raznica, stavkaProc = 0, n = 0, a, b, pereplata = 0;
            int creditE = 0, nedvizgimost, vznos, creditFull = 0;
            string srok;
            nedvizgimost = Convert.ToInt32(tbxNedvizgimost.Text);
            vznos = Convert.ToInt32(tbxVznos.Text);
            stavka = Convert.ToDouble(tbxStavka.Text);
            srok = cmbxSrok.Text;
            raznica = nedvizgimost - vznos;
            if (srok == "1 год") { stavkaProc += (stavka/100)/12; n += 12; }
            else if (srok == "2 года") { stavkaProc += ((stavka / 100) / 12); n += 24; }
            else if (srok == "4 года") { stavkaProc += ((stavka / 100) / 12); n += (12 * 4); }
            else if (srok == "5 лет") { stavkaProc += ((stavka / 100) / 12); n += (12 * 5); }
            else if (srok == "10 лет") { stavkaProc += ((stavka / 100) / 12); n += (12 * 10); }
            else if (srok == "15 лет") { stavkaProc += ((stavka / 100) / 12); n += (12 * 15); }
            else if (srok == "20 лет") { stavkaProc += ((stavka / 100) / 12); n += (12 * 20); }
            else if (srok == "25 лет") { stavkaProc += ((stavka / 100) / 12); n += (12 * 25); }
            else if (srok == "30 лет") { stavkaProc += ((stavka / 100) / 12); n += (12 * 30); }

            //для расчет ежемесячного платежа
            a = stavkaProc * Math.Pow((1 + stavkaProc), n);
            b = Math.Pow((1 + stavkaProc), n) - 1;
            creditE = Convert.ToInt32(raznica * (a/b));

            //за все время переплата
            creditFull += Convert.ToInt32((creditE * n) - raznica);

            //общая выплата
            pereplata += raznica + creditFull;

            rtbxInfo.Text = "Сумма кредита: " + Convert.ToString(raznica) + "\n" + "Ежемесячный платеж: " + Convert.ToString(creditE) + "\n" +  "Переплата по кредиту: " + Convert.ToString(creditFull) + "\n" + "Общая выплата: " + Convert.ToString(pereplata);
        }
    }
}