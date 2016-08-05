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
        
        //
        //  Manufacturer Group
        // 
        //      Only show Position and Telegram menu when Bombardier is selected.
        //
        private void manu_bombardier_CheckedChanged(object sender, EventArgs e)
        {
            position_gpbox.Visible = true;
        }

        private void manu_siemens_CheckedChanged(object sender, EventArgs e)
        {
            position_gpbox.Visible = false;
            pos_leu.Visible = false;
        }

        private void manu_shinwoo_CheckedChanged(object sender, EventArgs e)
        {
            position_gpbox.Visible = false;
        }

        //
        //  Position Group
        //
        Boolean balise_checked = true;

        //-----------  Checks if Balise is selected
        private void pos_balise_CheckedChanged(object sender, EventArgs e)
        {
            balise_checked = true;
        }

        private void pos_leu_CheckedChanged(object sender, EventArgs e)
        {
            balise_checked = false;
        }

        //-----------  Read, Write, Reset button control
        private void posread_btn_Click(object sender, EventArgs e)
        {
            if (balise_checked)
            {
                MessageBox.Show("Connect Balise Cable", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Connect LEU Cable", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void poswrite_btn_Click(object sender, EventArgs e)
        {
            if (balise_checked)
            {
                MessageBox.Show("Connect Balise Cable", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Connect LEU Cable and Check the LEU Power", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            countrycode_txt.Text = String.Empty;
            groupcode_txt.Text = String.Empty;
            poscode_txt.Text = String.Empty;
        }

        private void telegram_gpbox_Enter(object sender, EventArgs e)
        {

        }

        private void msgClear_btn_Click(object sender, EventArgs e)
        {
            msgbox.Clear();
        }

        private void msgSave_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            // if you don't need to keep the color of the text, use *.txt instead.
            saveFile.Filter = "Rich Text Format (*.rtf)|*.rtf"; 
            saveFile.DefaultExt = "rtf";
            saveFile.AddExtension = true;

            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile.FileName.Length > 0)
            {
                // if you don't need to keep the color of the text, use RichTextBoxStreamType.PlainText
                msgbox.SaveFile(saveFile.FileName, RichTextBoxStreamType.RichText);
            }
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
