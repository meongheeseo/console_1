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
