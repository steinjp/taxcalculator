
namespace 税計算機
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exitButton = new System.Windows.Forms.Button();
            this.ValueInput = new System.Windows.Forms.TextBox();
            this.tenPercOut = new System.Windows.Forms.TextBox();
            this.sagakuTen = new System.Windows.Forms.TextBox();
            this.eightPercOut = new System.Windows.Forms.TextBox();
            this.sagakuEight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.no_taxradioButton = new System.Windows.Forms.RadioButton();
            this.yes_taxradioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(145, 108);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 28);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "終了";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ValueInput
            // 
            this.ValueInput.Location = new System.Drawing.Point(64, 6);
            this.ValueInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValueInput.Name = "ValueInput";
            this.ValueInput.Size = new System.Drawing.Size(156, 22);
            this.ValueInput.TabIndex = 1;
            // 
            // tenPercOut
            // 
            this.tenPercOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenPercOut.Location = new System.Drawing.Point(341, 84);
            this.tenPercOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tenPercOut.Name = "tenPercOut";
            this.tenPercOut.ReadOnly = true;
            this.tenPercOut.Size = new System.Drawing.Size(100, 22);
            this.tenPercOut.TabIndex = 2;
            // 
            // sagakuTen
            // 
            this.sagakuTen.Location = new System.Drawing.Point(341, 114);
            this.sagakuTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sagakuTen.Name = "sagakuTen";
            this.sagakuTen.ReadOnly = true;
            this.sagakuTen.Size = new System.Drawing.Size(100, 22);
            this.sagakuTen.TabIndex = 3;
            // 
            // eightPercOut
            // 
            this.eightPercOut.Location = new System.Drawing.Point(341, 6);
            this.eightPercOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eightPercOut.Name = "eightPercOut";
            this.eightPercOut.ReadOnly = true;
            this.eightPercOut.Size = new System.Drawing.Size(100, 22);
            this.eightPercOut.TabIndex = 4;
            // 
            // sagakuEight
            // 
            this.sagakuEight.Location = new System.Drawing.Point(341, 36);
            this.sagakuEight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sagakuEight.Name = "sagakuEight";
            this.sagakuEight.ReadOnly = true;
            this.sagakuEight.Size = new System.Drawing.Size(100, 22);
            this.sagakuEight.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "金額：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "10%消費税：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "8%消費税：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "内、10%消費税：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "内、8%消費税：";
            // 
            // no_taxradioButton
            // 
            this.no_taxradioButton.AutoSize = true;
            this.no_taxradioButton.Location = new System.Drawing.Point(64, 39);
            this.no_taxradioButton.Name = "no_taxradioButton";
            this.no_taxradioButton.Size = new System.Drawing.Size(127, 20);
            this.no_taxradioButton.TabIndex = 13;
            this.no_taxradioButton.TabStop = true;
            this.no_taxradioButton.Text = "税抜金額を計算";
            this.no_taxradioButton.UseVisualStyleBackColor = true;
            // 
            // yes_taxradioButton
            // 
            this.yes_taxradioButton.AutoSize = true;
            this.yes_taxradioButton.Location = new System.Drawing.Point(64, 65);
            this.yes_taxradioButton.Name = "yes_taxradioButton";
            this.yes_taxradioButton.Size = new System.Drawing.Size(127, 20);
            this.yes_taxradioButton.TabIndex = 14;
            this.yes_taxradioButton.TabStop = true;
            this.yes_taxradioButton.Text = "税込金額を計算";
            this.yes_taxradioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 146);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yes_taxradioButton);
            this.Controls.Add(this.no_taxradioButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sagakuEight);
            this.Controls.Add(this.eightPercOut);
            this.Controls.Add(this.sagakuTen);
            this.Controls.Add(this.tenPercOut);
            this.Controls.Add(this.ValueInput);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "税計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox ValueInput;
        private System.Windows.Forms.TextBox tenPercOut;
        private System.Windows.Forms.TextBox sagakuTen;
        private System.Windows.Forms.TextBox eightPercOut;
        private System.Windows.Forms.TextBox sagakuEight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton no_taxradioButton;
        private System.Windows.Forms.RadioButton yes_taxradioButton;
        private System.Windows.Forms.Button button1;
    }
}

