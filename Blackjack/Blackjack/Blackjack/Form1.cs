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
