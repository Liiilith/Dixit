﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiXit
{
    public partial class Form3 : Form
    {
        // deklaracja zmiennych dla Ekranu 3
        Player player1 = new Player("22","11");        // to tak naprawdę zostanie stworzone wyżej


        public Form3()
        {
            InitializeComponent();
            buttonsLook();         // nazwy buttonów i inne




        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (player1.getType() == playerType.challanger)


            {

                // tu if jesteś serverem to odpalaj server a inaczej klienta

                // startujemy nową forme 4, z ustawianiami w zależności od typu gracza 


            }

            else if (player1.getType() == playerType.guesser)
            {

                // jw  

            }


        }





        private void button3_Click(object sender, EventArgs e)
        {
            player1.setTyp(playerType.guesser);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player1.setTyp(playerType.challanger);
        }


        private void buttonsLook()
        {
            button1.Text = "Start";
            button2.Text = "CHALLANGE";
            button3.Text = "GUESS";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }

}
