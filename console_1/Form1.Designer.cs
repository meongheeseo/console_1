namespace console_1
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
            this.poswrite_btn = new System.Windows.Forms.Button();
            this.posread_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.poscode_txt = new System.Windows.Forms.TextBox();
            this.groupcode_txt = new System.Windows.Forms.TextBox();
            this.countrycode_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msgbox = new System.Windows.Forms.RichTextBox();
            this.pos_leu = new System.Windows.Forms.RadioButton();
            this.pos_balise = new System.Windows.Forms.RadioButton();
            this.telegram_gpbox = new System.Windows.Forms.GroupBox();
            this.verify_btn = new System.Windows.Forms.Button();
            this.upload_btn = new System.Windows.Forms.Button();
            this.download_btn = new System.Windows.Forms.Button();
            this.device_gpbox = new System.Windows.Forms.GroupBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.manufacturer_gpbox.SuspendLayout();
            this.position_gpbox.SuspendLayout();
            this.telegram_gpbox.SuspendLayout();
            this.device_gpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // manu_bombardier
            // 
            this.manu_bombardier.AutoSize = true;
            this.manu_bombardier.Location = new System.Drawing.Point(247, 33);
            this.manu_bombardier.Name = "manu_bombardier";
            this.manu_bombardier.Size = new System.Drawing.Size(88, 16);
            this.manu_bombardier.TabIndex = 3;
            this.manu_bombardier.Text = "Bombardier";
            this.manu_bombardier.UseVisualStyleBackColor = true;
            this.manu_bombardier.CheckedChanged += new System.EventHandler(this.manu_bombardier_CheckedChanged);
            // 
            // manu_siemens
            // 
            this.manu_siemens.AutoSize = true;
            this.manu_siemens.Location = new System.Drawing.Point(518, 33);
            this.manu_siemens.Name = "manu_siemens";
            this.manu_siemens.Size = new System.Drawing.Size(73, 16);
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
            this.manufacturer_gpbox.Location = new System.Drawing.Point(14, 11);
            this.manufacturer_gpbox.Name = "manufacturer_gpbox";
            this.manufacturer_gpbox.Size = new System.Drawing.Size(640, 75);
            this.manufacturer_gpbox.TabIndex = 5;
            this.manufacturer_gpbox.TabStop = false;
            this.manufacturer_gpbox.Text = "Manufacturer";
            // 
            // manu_shinwoo
            // 
            this.manu_shinwoo.AutoSize = true;
            this.manu_shinwoo.Checked = true;
            this.manu_shinwoo.Location = new System.Drawing.Point(28, 33);
            this.manu_shinwoo.Name = "manu_shinwoo";
            this.manu_shinwoo.Size = new System.Drawing.Size(72, 16);
            this.manu_shinwoo.TabIndex = 5;
            this.manu_shinwoo.TabStop = true;
            this.manu_shinwoo.Text = "ShinWoo";
            this.manu_shinwoo.UseVisualStyleBackColor = true;
            this.manu_shinwoo.CheckedChanged += new System.EventHandler(this.manu_shinwoo_CheckedChanged);
            // 
            // msgSave_btn
            // 
            this.msgSave_btn.Location = new System.Drawing.Point(500, 432);
            this.msgSave_btn.Name = "msgSave_btn";
            this.msgSave_btn.Size = new System.Drawing.Size(73, 20);
            this.msgSave_btn.TabIndex = 7;
            this.msgSave_btn.Text = "Save";
            this.msgSave_btn.UseVisualStyleBackColor = true;
            this.msgSave_btn.Click += new System.EventHandler(this.msgSave_btn_Click);
            // 
            // msgClear_btn
            // 
            this.msgClear_btn.Location = new System.Drawing.Point(581, 432);
            this.msgClear_btn.Name = "msgClear_btn";
            this.msgClear_btn.Size = new System.Drawing.Size(73, 20);
            this.msgClear_btn.TabIndex = 8;
            this.msgClear_btn.Text = "Clear";
            this.msgClear_btn.UseVisualStyleBackColor = true;
            this.msgClear_btn.Click += new System.EventHandler(this.msgClear_btn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(14, 240);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(601, 21);
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
            this.position_gpbox.Location = new System.Drawing.Point(14, 91);
            this.position_gpbox.Name = "position_gpbox";
            this.position_gpbox.Size = new System.Drawing.Size(338, 143);
            this.position_gpbox.TabIndex = 10;
            this.position_gpbox.TabStop = false;
            this.position_gpbox.Text = "Position Information";
            // 
            // poswrite_btn
            // 
            this.poswrite_btn.Location = new System.Drawing.Point(125, 105);
            this.poswrite_btn.Name = "poswrite_btn";
            this.poswrite_btn.Size = new System.Drawing.Size(90, 21);
            this.poswrite_btn.TabIndex = 10;
            this.poswrite_btn.Text = "Write";
            this.poswrite_btn.UseVisualStyleBackColor = true;
            this.poswrite_btn.Click += new System.EventHandler(this.poswrite_btn_Click);
            // 
            // posread_btn
            // 
            this.posread_btn.Location = new System.Drawing.Point(28, 105);
            this.posread_btn.Name = "posread_btn";
            this.posread_btn.Size = new System.Drawing.Size(90, 21);
            this.posread_btn.TabIndex = 9;
            this.posread_btn.Text = "Read";
            this.posread_btn.UseVisualStyleBackColor = true;
            this.posread_btn.Click += new System.EventHandler(this.posread_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(222, 105);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(90, 21);
            this.reset_btn.TabIndex = 8;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // poscode_txt
            // 
            this.poscode_txt.Location = new System.Drawing.Point(149, 70);
            this.poscode_txt.Name = "poscode_txt";
            this.poscode_txt.Size = new System.Drawing.Size(161, 21);
            this.poscode_txt.TabIndex = 7;
            this.poscode_txt.Text = "XXX";
            // 
            // groupcode_txt
            // 
            this.groupcode_txt.Location = new System.Drawing.Point(149, 50);
            this.groupcode_txt.Name = "groupcode_txt";
            this.groupcode_txt.Size = new System.Drawing.Size(161, 21);
            this.groupcode_txt.TabIndex = 6;
            this.groupcode_txt.Text = "XXX";
            // 
            // countrycode_txt
            // 
            this.countrycode_txt.Location = new System.Drawing.Point(149, 29);
            this.countrycode_txt.Name = "countrycode_txt";
            this.countrycode_txt.Size = new System.Drawing.Size(161, 21);
            this.countrycode_txt.TabIndex = 5;
            this.countrycode_txt.Text = "XXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Position code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Group code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country code: ";
            // 
            // msgbox
            // 
            this.msgbox.Location = new System.Drawing.Point(16, 267);
            this.msgbox.Name = "msgbox";
            this.msgbox.Size = new System.Drawing.Size(640, 160);
            this.msgbox.TabIndex = 11;
            this.msgbox.Text = "";
            // 
            // pos_leu
            // 
            this.pos_leu.AutoSize = true;
            this.pos_leu.Location = new System.Drawing.Point(161, 22);
            this.pos_leu.Name = "pos_leu";
            this.pos_leu.Size = new System.Drawing.Size(46, 16);
            this.pos_leu.TabIndex = 1;
            this.pos_leu.Text = "LEU";
            this.pos_leu.UseVisualStyleBackColor = true;
            this.pos_leu.CheckedChanged += new System.EventHandler(this.pos_leu_CheckedChanged);
            // 
            // pos_balise
            // 
            this.pos_balise.AutoSize = true;
            this.pos_balise.Checked = true;
            this.pos_balise.Location = new System.Drawing.Point(45, 22);
            this.pos_balise.Name = "pos_balise";
            this.pos_balise.Size = new System.Drawing.Size(58, 16);
            this.pos_balise.TabIndex = 0;
            this.pos_balise.TabStop = true;
            this.pos_balise.Text = "Balise";
            this.pos_balise.UseVisualStyleBackColor = true;
            this.pos_balise.CheckedChanged += new System.EventHandler(this.pos_balise_CheckedChanged);
            // 
            // telegram_gpbox
            // 
            this.telegram_gpbox.Controls.Add(this.verify_btn);
            this.telegram_gpbox.Controls.Add(this.upload_btn);
            this.telegram_gpbox.Controls.Add(this.download_btn);
            this.telegram_gpbox.Controls.Add(this.device_gpbox);
            this.telegram_gpbox.Location = new System.Drawing.Point(363, 91);
            this.telegram_gpbox.Name = "telegram_gpbox";
            this.telegram_gpbox.Size = new System.Drawing.Size(292, 143);
            this.telegram_gpbox.TabIndex = 12;
            this.telegram_gpbox.TabStop = false;
            this.telegram_gpbox.Text = "Telegram";
            this.telegram_gpbox.Enter += new System.EventHandler(this.telegram_gpbox_Enter);
            // 
            // verify_btn
            // 
            this.verify_btn.Location = new System.Drawing.Point(194, 105);
            this.verify_btn.Name = "verify_btn";
            this.verify_btn.Size = new System.Drawing.Size(82, 21);
            this.verify_btn.TabIndex = 12;
            this.verify_btn.Text = "Verify";
            this.verify_btn.UseVisualStyleBackColor = true;
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(105, 105);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(82, 21);
            this.upload_btn.TabIndex = 11;
            this.upload_btn.Text = "Upload";
            this.upload_btn.UseVisualStyleBackColor = true;
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(16, 105);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(82, 21);
            this.download_btn.TabIndex = 10;
            this.download_btn.Text = "Download";
            this.download_btn.UseVisualStyleBackColor = true;
            // 
            // device_gpbox
            // 
            this.device_gpbox.Controls.Add(this.pos_balise);
            this.device_gpbox.Controls.Add(this.pos_leu);
            this.device_gpbox.Location = new System.Drawing.Point(13, 32);
            this.device_gpbox.Name = "device_gpbox";
            this.device_gpbox.Size = new System.Drawing.Size(267, 54);
            this.device_gpbox.TabIndex = 0;
            this.device_gpbox.TabStop = false;
            this.device_gpbox.Text = "Device";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.progressLabel.Location = new System.Drawing.Point(615, 244);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(14, 13);
            this.progressLabel.TabIndex = 13;
            this.progressLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(639, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(668, 457);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.telegram_gpbox);
            this.Controls.Add(this.msgbox);
            this.Controls.Add(this.position_gpbox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.msgClear_btn);
            this.Controls.Add(this.msgSave_btn);
            this.Controls.Add(this.manufacturer_gpbox);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Universal Balise/LEU Programmer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.manufacturer_gpbox.ResumeLayout(false);
            this.manufacturer_gpbox.PerformLayout();
            this.position_gpbox.ResumeLayout(false);
            this.position_gpbox.PerformLayout();
            this.telegram_gpbox.ResumeLayout(false);
            this.device_gpbox.ResumeLayout(false);
            this.device_gpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox poscode_txt;
        private System.Windows.Forms.TextBox groupcode_txt;
        private System.Windows.Forms.TextBox countrycode_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button poswrite_btn;
        private System.Windows.Forms.Button posread_btn;
        private System.Windows.Forms.RadioButton pos_leu;
        private System.Windows.Forms.RadioButton pos_balise;
        private System.Windows.Forms.GroupBox telegram_gpbox;
        private System.Windows.Forms.GroupBox device_gpbox;
        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.Button verify_btn;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label label4;

    }
}

