using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string[] Cartas = new string[52];
            Cartas[0] = "2decopas";
            Cartas[1] = "2deespada";
            Cartas[2] = "2deouro";
            Cartas[3] = "2depaus";
            Cartas[4] = "3decopas";
            Cartas[5] = "3deespada";
            Cartas[6] = "3deouro";
            Cartas[7] = "3depaus";
            Cartas[8] = "4decopas";
            Cartas[9] = "4deespada";
            Cartas[10] = "4deouro";
            Cartas[11] = "4depaus";
            Cartas[12] = "5decopas";
            Cartas[13] = "5deespada";
            Cartas[14] = "5deouro";
            Cartas[15] = "5depaus";
            Cartas[16] = "6decopas";
            Cartas[17] = "6deespada";
            Cartas[18] = "6deouro";
            Cartas[19] = "6depaus";
            Cartas[20] = "7decopas";
            Cartas[21] = "7deespada";
            Cartas[22] = "7deouro";
            Cartas[23] = "7depaus";
            Cartas[24] = "8decopas";
            Cartas[25] = "8deespada";
            Cartas[26] = "8deouro";
            Cartas[27] = "8depaus";
            Cartas[28] = "9deouro";
            Cartas[29] = "9depaus";
            Cartas[30] = "9decopas";
            Cartas[31] = "9deespada";
            Cartas[32] = "10deouro";
            Cartas[33] = "10depaus";
            Cartas[34] = "10decopas";
            Cartas[35] = "10deespadas";
            Cartas[36] = "ASdeouro";
            Cartas[37] = "ASdepaus";
            Cartas[38] = "ASdecopas";
            Cartas[39] = "ASdeespadas";
            Cartas[40] = "Kdeouro";
            Cartas[41] = "Kdepaus";
            Cartas[42] = "Kdecopas";
            Cartas[43] = "Kdeespada";
            Cartas[44] = "Jdeouro";
            Cartas[45] = "Jdepaus";
            Cartas[46] = "Jdecopas";
            Cartas[47] = "Jdeespada";
            Cartas[48] = "Qdeouro";
            Cartas[49] = "Qdepaus";
            Cartas[50] = "Qdecopas";
            Cartas[51] = "Qdeespada";

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            Random indice = new Random();
            indice.Next(51);


        }
    }
}
