﻿namespace FormTest
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIniRange = new System.Windows.Forms.TextBox();
            this.txtEndRange = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblComercial = new System.Windows.Forms.Label();
            this.lblResidencial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 99);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtIniRange
            // 
            this.txtIniRange.Location = new System.Drawing.Point(70, 208);
            this.txtIniRange.Name = "txtIniRange";
            this.txtIniRange.Size = new System.Drawing.Size(212, 31);
            this.txtIniRange.TabIndex = 3;
            // 
            // txtEndRange
            // 
            this.txtEndRange.Location = new System.Drawing.Point(70, 257);
            this.txtEndRange.Name = "txtEndRange";
            this.txtEndRange.Size = new System.Drawing.Size(212, 31);
            this.txtEndRange.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(449, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(498, 204);
            this.listBox1.TabIndex = 5;
            this.listBox1.DoubleClick += new System.EventHandler(this.ListBox1_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(759, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 31);
            this.textBox1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(70, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 96);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lblComercial
            // 
            this.lblComercial.AutoSize = true;
            this.lblComercial.Location = new System.Drawing.Point(65, 548);
            this.lblComercial.Name = "lblComercial";
            this.lblComercial.Size = new System.Drawing.Size(108, 25);
            this.lblComercial.TabIndex = 8;
            this.lblComercial.Text = "Comercial";
            // 
            // lblResidencial
            // 
            this.lblResidencial.AutoSize = true;
            this.lblResidencial.Location = new System.Drawing.Point(69, 610);
            this.lblResidencial.Name = "lblResidencial";
            this.lblResidencial.Size = new System.Drawing.Size(124, 25);
            this.lblResidencial.TabIndex = 9;
            this.lblResidencial.Text = "Residencial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 766);
            this.Controls.Add(this.lblResidencial);
            this.Controls.Add(this.lblComercial);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtEndRange);
            this.Controls.Add(this.txtIniRange);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIniRange;
        private System.Windows.Forms.TextBox txtEndRange;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblComercial;
        private System.Windows.Forms.Label lblResidencial;
    }
}

