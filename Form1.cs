using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaletteCouleur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<GroupBox> groupbox = new List<GroupBox>();
            List<Label> labels = new List<Label>();
            List<Button> buttons = new List<Button>();
            for (int i = 1; i < 10; i++) {
                Button newButton = new Button();
                buttons.Add(newButton);
                this.Controls.Add(newButton);
                this.buttonStyle(newButton);
            }

        }

        private void buttonStyle(System.Windows.Forms.Button b)
        {
            b.BackColor = System.Drawing.Color.Red;
            b.FlatAppearance.BorderSize = 0;
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            b.ForeColor = System.Drawing.Color.White;
            b.Location = new System.Drawing.Point(568, 44);
            b.Name = "button5";
            b.Size = new System.Drawing.Size(187, 135);
            b.TabIndex = 4;
            b.Text = "#1234\r\nrgb(255,255,,255)\r\nCMJN( 2,2,2,2)\r\n";
            b.UseVisualStyleBackColor = false;
        }

        private void Recherche_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e) 
        {
            Button b = sender as Button;
            b.Text = "#1234 \nrgb(255,255,,255)\nCMJN( 2,2,2,2)";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

    }
}
