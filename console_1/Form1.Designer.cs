﻿namespace console_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.manu_bombardier = new System.Windows.Forms.RadioButton();
            this.manu_siemens = new System.Windows.Forms.RadioButton();
            this.manufacturer_gpbox = new System.Windows.Forms.GroupBox();
            this.manu_shinwoo = new System.Windows.Forms.RadioButton();
            this.msgSave_btn = new System.Windows.Forms.Button();
            this.msgClear_btn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.position_gpbox = new System.Windows.Forms.GroupBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.poscode_txt = new System.Windows.Forms.TextBox();
            this.groupcode_txt = new System.Windows.Forms.TextBox();
            this.countrycode_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pos_leu = new System.Windows.Forms.RadioButton();
            this.pos_balise = new System.Windows.Forms.RadioButton();
            this.msgbox = new System.Windows.Forms.RichTextBox();
            this.posread_btn = new System.Windows.Forms.Button();
            this.poswrite_btn = new System.Windows.Forms.Button();
            this.manufacturer_gpbox.SuspendLayout();
            this.position_gpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // manu_bombardier
            // 
            this.manu_bombardier.AutoSize = true;
            this.manu_bombardier.Location = new System.Drawing.Point(6, 19);
            this.manu_bombardier.Name = "manu_bombardier";
            this.manu_bombardier.Size = new System.Drawing.Size(78, 17);
            this.manu_bombardier.TabIndex = 3;
            this.manu_bombardier.Text = "Bombardier";
            this.manu_bombardier.UseVisualStyleBackColor = true;
            this.manu_bombardier.CheckedChanged += new System.EventHandler(this.manu_bombardier_CheckedChanged);
            // 
            // manu_siemens
            // 
            this.manu_siemens.AutoSize = true;
            this.manu_siemens.Location = new System.Drawing.Point(6, 42);
            this.manu_siemens.Name = "manu_siemens";
            this.manu_siemens.Size = new System.Drawing.Size(65, 17);
            this.manu_siemens.TabIndex = 4;
            this.manu_siemens.Text = "Siemens";
            this.manu_siemens.UseVisualStyleBackColor = true;
            this.manu_siemens.CheckedChanged += new System.EventHandler(this.manu_siemens_CheckedChanged);
            // 
            // manufacturer_gpbox
            // 
            this.manufacturer_gpbox.Controls.Add(this.manu_shinwoo);
            this.manufacturer_gpbox.Controls.Add(this.manu_bombardier);
            this.manufacturer_gpbox.Controls.Add(this.manu_siemens);
            this.manufacturer_gpbox.Location = new System.Drawing.Point(12, 12);
            this.manufacturer_gpbox.Name = "manufacturer_gpbox";
            this.manufacturer_gpbox.Size = new System.Drawing.Size(99, 122);
            this.manufacturer_gpbox.TabIndex = 5;
            this.manufacturer_gpbox.TabStop = false;
            this.manufacturer_gpbox.Text = "Manufacturer";
            // 
            // manu_shinwoo
            // 
            this.manu_shinwoo.AutoSize = true;
            this.manu_shinwoo.Checked = true;
            this.manu_shinwoo.Location = new System.Drawing.Point(7, 66);
            this.manu_shinwoo.Name = "manu_shinwoo";
            this.manu_shinwoo.Size = new System.Drawing.Size(69, 17);
            this.manu_shinwoo.TabIndex = 5;
            this.manu_shinwoo.TabStop = true;
            this.manu_shinwoo.Text = "ShinWoo";
            this.manu_shinwoo.UseVisualStyleBackColor = true;
            this.manu_shinwoo.CheckedChanged += new System.EventHandler(this.manu_shinwoo_CheckedChanged);
            // 
            // msgSave_btn
            // 
            this.msgSave_btn.Location = new System.Drawing.Point(453, 357);
            this.msgSave_btn.Name = "msgSave_btn";
            this.msgSave_btn.Size = new System.Drawing.Size(63, 22);
            this.msgSave_btn.TabIndex = 7;
            this.msgSave_btn.Text = "Save";
            this.msgSave_btn.UseVisualStyleBackColor = true;
            // 
            // msgClear_btn
            // 
            this.msgClear_btn.Location = new System.Drawing.Point(453, 329);
            this.msgClear_btn.Name = "msgClear_btn";
            this.msgClear_btn.Size = new System.Drawing.Size(63, 22);
            this.msgClear_btn.TabIndex = 8;
            this.msgClear_btn.Text = "Clear";
            this.msgClear_btn.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 177);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(435, 23);
            this.progressBar.TabIndex = 9;
            // 
            // position_gpbox
            // 
            this.position_gpbox.Controls.Add(this.poswrite_btn);
            this.position_gpbox.Controls.Add(this.posread_btn);
            this.position_gpbox.Controls.Add(this.reset_btn);
            this.position_gpbox.Controls.Add(this.poscode_txt);
            this.position_gpbox.Controls.Add(this.groupcode_txt);
            this.position_gpbox.Controls.Add(this.countrycode_txt);
            this.position_gpbox.Controls.Add(this.label3);
            this.position_gpbox.Controls.Add(this.label2);
            this.position_gpbox.Controls.Add(this.label1);
            this.position_gpbox.Controls.Add(this.pos_leu);
            this.position_gpbox.Controls.Add(this.pos_balise);
            this.position_gpbox.Location = new System.Drawing.Point(117, 12);
            this.position_gpbox.Name = "position_gpbox";
            this.position_gpbox.Size = new System.Drawing.Size(290, 122);
            this.position_gpbox.TabIndex = 10;
            this.position_gpbox.TabStop = false;
            this.position_gpbox.Text = "Position Information";
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(80, 89);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(107, 22);
            this.reset_btn.TabIndex = 8;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // poscode_txt
            // 
            this.poscode_txt.Location = new System.Drawing.Point(150, 63);
            this.poscode_txt.Name = "poscode_txt";
            this.poscode_txt.Size = new System.Drawing.Size(37, 20);
            this.poscode_txt.TabIndex = 7;
            this.poscode_txt.Text = "XXX";
            // 
            // groupcode_txt
            // 
            this.groupcode_txt.Location = new System.Drawing.Point(150, 41);
            this.groupcode_txt.Name = "groupcode_txt";
            this.groupcode_txt.Size = new System.Drawing.Size(37, 20);
            this.groupcode_txt.TabIndex = 6;
            this.groupcode_txt.Text = "XXX";
            // 
            // countrycode_txt
            // 
            this.countrycode_txt.Location = new System.Drawing.Point(150, 18);
            this.countrycode_txt.Name = "countrycode_txt";
            this.countrycode_txt.Size = new System.Drawing.Size(37, 20);
            this.countrycode_txt.TabIndex = 5;
            this.countrycode_txt.Text = "XXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Position code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Group code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country code: ";
            // 
            // pos_leu
            // 
            this.pos_leu.AutoSize = true;
            this.pos_leu.Location = new System.Drawing.Point(6, 42);
            this.pos_leu.Name = "pos_leu";
            this.pos_leu.Size = new System.Drawing.Size(46, 17);
            this.pos_leu.TabIndex = 1;
            this.pos_leu.Text = "LEU";
            this.pos_leu.UseVisualStyleBackColor = true;
            this.pos_leu.CheckedChanged += new System.EventHandler(this.pos_leu_CheckedChanged);
            // 
            // pos_balise
            // 
            this.pos_balise.AutoSize = true;
            this.pos_balise.Checked = true;
            this.pos_balise.Location = new System.Drawing.Point(6, 19);
            this.pos_balise.Name = "pos_balise";
            this.pos_balise.Size = new System.Drawing.Size(53, 17);
            this.pos_balise.TabIndex = 0;
            this.pos_balise.TabStop = true;
            this.pos_balise.Text = "Balise";
            this.pos_balise.UseVisualStyleBackColor = true;
            this.pos_balise.CheckedChanged += new System.EventHandler(this.pos_balise_CheckedChanged);
            // 
            // msgbox
            // 
            this.msgbox.Location = new System.Drawing.Point(12, 206);
            this.msgbox.Name = "msgbox";
            this.msgbox.Size = new System.Drawing.Size(435, 173);
            this.msgbox.TabIndex = 11;
            this.msgbox.Text = "";
            // 
            // posread_btn
            // 
            this.posread_btn.Location = new System.Drawing.Point(203, 59);
            this.posread_btn.Name = "posread_btn";
            this.posread_btn.Size = new System.Drawing.Size(75, 23);
            this.posread_btn.TabIndex = 9;
            this.posread_btn.Text = "Read";
            this.posread_btn.UseVisualStyleBackColor = true;
            this.posread_btn.Click += new System.EventHandler(this.posread_btn_Click);
            // 
            // poswrite_btn
            // 
            this.poswrite_btn.Location = new System.Drawing.Point(203, 88);
            this.poswrite_btn.Name = "poswrite_btn";
            this.poswrite_btn.Size = new System.Drawing.Size(75, 23);
            this.poswrite_btn.TabIndex = 10;
            this.poswrite_btn.Text = "Write";
            this.poswrite_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(649, 405);
            this.Controls.Add(this.msgbox);
            this.Controls.Add(this.position_gpbox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.msgClear_btn);
            this.Controls.Add(this.msgSave_btn);
            this.Controls.Add(this.manufacturer_gpbox);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.manufacturer_gpbox.ResumeLayout(false);
            this.manufacturer_gpbox.PerformLayout();
            this.position_gpbox.ResumeLayout(false);
            this.position_gpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton manu_bombardier;
        private System.Windows.Forms.RadioButton manu_siemens;
        private System.Windows.Forms.GroupBox manufacturer_gpbox;
        private System.Windows.Forms.RadioButton manu_shinwoo;
        private System.Windows.Forms.Button msgSave_btn;
        private System.Windows.Forms.Button msgClear_btn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox position_gpbox;
        private System.Windows.Forms.RichTextBox msgbox;
        private System.Windows.Forms.RadioButton pos_leu;
        private System.Windows.Forms.RadioButton pos_balise;
        private System.Windows.Forms.TextBox poscode_txt;
        private System.Windows.Forms.TextBox groupcode_txt;
        private System.Windows.Forms.TextBox countrycode_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button poswrite_btn;
        private System.Windows.Forms.Button posread_btn;

    }
}

