﻿namespace AMX_Word_Permutations
{
    partial class AMXWordPermutations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMXWordPermutations));
            this.tbMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbChars = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.wc = new System.Windows.Forms.Label();
            this.twc = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.rtbWords = new System.Windows.Forms.RichTextBox();
            this.tbMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.ColumnCount = 1;
            this.tbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tbMain.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tbMain.Controls.Add(this.rtbWords, 0, 1);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.RowCount = 3;
            this.tbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tbMain.Size = new System.Drawing.Size(966, 565);
            this.tbMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.Controls.Add(this.cc, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbChars, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.wc, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.twc, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 39);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cc.Location = new System.Drawing.Point(387, 0);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(109, 39);
            this.cc.TabIndex = 3;
            this.cc.Text = "Characters: 0";
            this.cc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter characters:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbChars
            // 
            this.tbChars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChars.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbChars.Location = new System.Drawing.Point(147, 3);
            this.tbChars.MaxLength = 8;
            this.tbChars.Name = "tbChars";
            this.tbChars.Size = new System.Drawing.Size(186, 29);
            this.tbChars.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.White;
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(339, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(42, 33);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // wc
            // 
            this.wc.AutoSize = true;
            this.wc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wc.Location = new System.Drawing.Point(502, 0);
            this.wc.Name = "wc";
            this.wc.Size = new System.Drawing.Size(224, 39);
            this.wc.TabIndex = 4;
            this.wc.Text = "Unique Permutations: 0";
            this.wc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // twc
            // 
            this.twc.AutoSize = true;
            this.twc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twc.Location = new System.Drawing.Point(732, 0);
            this.twc.Name = "twc";
            this.twc.Size = new System.Drawing.Size(225, 39);
            this.twc.TabIndex = 5;
            this.twc.Text = "Total Permutations: 0";
            this.twc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblT2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblT1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkLabel1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 539);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(960, 23);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblT2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2.Location = new System.Drawing.Point(243, 0);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(234, 23);
            this.lblT2.TabIndex = 6;
            this.lblT2.Text = "Time (Print): 0 Ticks";
            this.lblT2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblT1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT1.Location = new System.Drawing.Point(3, 0);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(234, 23);
            this.lblT1.TabIndex = 5;
            this.lblT1.Text = "Time (Permute): 0 Ticks";
            this.lblT1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(483, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(474, 23);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copyright © 2016 Afaan Bilal, AMX Infinity (https://www.amxinfinity.ml)";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCopyright_LinkClicked);
            // 
            // rtbWords
            // 
            this.rtbWords.BackColor = System.Drawing.Color.Black;
            this.rtbWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbWords.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbWords.ForeColor = System.Drawing.Color.Lime;
            this.rtbWords.Location = new System.Drawing.Point(3, 48);
            this.rtbWords.Name = "rtbWords";
            this.rtbWords.Size = new System.Drawing.Size(960, 485);
            this.rtbWords.TabIndex = 3;
            this.rtbWords.Text = "";
            // 
            // AMXWordPermutations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 565);
            this.Controls.Add(this.tbMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AMXWordPermutations";
            this.Text = "AMX Word Permutations";
            this.tbMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbChars;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label cc;
        private System.Windows.Forms.Label twc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label wc;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox rtbWords;

    }
}

