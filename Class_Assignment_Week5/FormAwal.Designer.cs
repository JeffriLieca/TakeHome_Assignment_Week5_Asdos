namespace Class_Assignment_Week5
{
    partial class FormAwal
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
            this.components = new System.ComponentModel.Container();
            this.labelHalo = new System.Windows.Forms.Label();
            this.timerKetik = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEnter = new System.Windows.Forms.Label();
            this.timerBlink = new System.Windows.Forms.Timer(this.components);
            this.labelNama = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelHalo
            // 
            this.labelHalo.AutoSize = true;
            this.labelHalo.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHalo.Location = new System.Drawing.Point(71, 59);
            this.labelHalo.Name = "labelHalo";
            this.labelHalo.Size = new System.Drawing.Size(289, 26);
            this.labelHalo.TabIndex = 0;
            this.labelHalo.Text = "Welcome to Blink Shop";
            // 
            // timerKetik
            // 
            this.timerKetik.Tick += new System.EventHandler(this.timerKetik_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(173, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(149, 120);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(135, 15);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Please enter your name";
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Location = new System.Drawing.Point(181, 163);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(83, 16);
            this.labelEnter.TabIndex = 3;
            this.labelEnter.Text = "(press Enter)";
            // 
            // timerBlink
            // 
            this.timerBlink.Tick += new System.EventHandler(this.timerBlink_Tick);
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(95, 109);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(246, 26);
            this.labelNama.TabIndex = 4;
            this.labelNama.Text = "Nama yang diinput";
            this.labelNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(177, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Shop Now!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // buttonSkip
            // 
            this.buttonSkip.BackColor = System.Drawing.Color.Coral;
            this.buttonSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkip.Location = new System.Drawing.Point(386, 3);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(50, 30);
            this.buttonSkip.TabIndex = 6;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = false;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(-9, 225);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(445, 23);
            this.progressBarLoading.TabIndex = 7;
            this.progressBarLoading.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timerProgress
            // 
            this.timerProgress.Interval = 10;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // FormAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(439, 243);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelHalo);
            this.Name = "FormAwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.FormAwal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHalo;
        private System.Windows.Forms.Timer timerKetik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Timer timerBlink;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Timer timerProgress;
    }
}