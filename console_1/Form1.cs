using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace console_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //msgbox.AppendText("HI\n");
            //msgbox.AppendText("Hello", Color.Green);
            position_gpbox.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void manu_bombardier_CheckedChanged(object sender, EventArgs e)
        {
            position_gpbox.Visible = true;
        }

        private void manu_siemens_CheckedChanged(object sender, EventArgs e)
        {
            position_gpbox.Visible = false;
        }

        private void manu_shinwoo_CheckedChanged(object sender, EventArgs e)
        {
            position_gpbox.Visible = false;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            countrycode_txt.Text = String.Empty;
            groupcode_txt.Text = String.Empty;
            poscode_txt.Text = String.Empty;
        }

        Boolean balise_checked = true;

        private void pos_balise_CheckedChanged(object sender, EventArgs e)
        {
            balise_checked = true;
        }

        private void pos_leu_CheckedChanged(object sender, EventArgs e)
        {
            balise_checked = false;
        }

        private void posread_btn_Click(object sender, EventArgs e)
        {
            if (balise_checked)
                MessageBox.Show("Balise");
            else
                MessageBox.Show("LEU");
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }


}
