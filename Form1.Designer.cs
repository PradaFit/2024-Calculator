namespace _2024_Calculator
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPerc = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClrCurnt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSquared = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEqu = new System.Windows.Forms.Button();
            this.btnNeg = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(12, 12);
            this.txtTotal.MaxLength = 999999;
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTotal.Size = new System.Drawing.Size(317, 54);
            this.txtTotal.TabIndex = 0;
            // 
            // btnPerc
            // 
            this.btnPerc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPerc.Location = new System.Drawing.Point(12, 72);
            this.btnPerc.Name = "btnPerc";
            this.btnPerc.Size = new System.Drawing.Size(75, 61);
            this.btnPerc.TabIndex = 1;
            this.btnPerc.Text = "%";
            this.btnPerc.UseVisualStyleBackColor = true;
            this.btnPerc.Click += new System.EventHandler(this.btnPerc_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(255, 72);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(74, 61);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClrCurnt
            // 
            this.btnClrCurnt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClrCurnt.Location = new System.Drawing.Point(93, 72);
            this.btnClrCurnt.Name = "btnClrCurnt";
            this.btnClrCurnt.Size = new System.Drawing.Size(75, 61);
            this.btnClrCurnt.TabIndex = 3;
            this.btnClrCurnt.Text = "CE";
            this.btnClrCurnt.UseVisualStyleBackColor = true;
            this.btnClrCurnt.Click += new System.EventHandler(this.btnClrCurnt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(174, 72);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 61);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSqrt.Location = new System.Drawing.Point(174, 139);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(75, 61);
            this.btnSqrt.TabIndex = 8;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnSquared
            // 
            this.btnSquared.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSquared.Location = new System.Drawing.Point(93, 139);
            this.btnSquared.Name = "btnSquared";
            this.btnSquared.Size = new System.Drawing.Size(75, 61);
            this.btnSquared.TabIndex = 7;
            this.btnSquared.Text = "x²";
            this.btnSquared.UseVisualStyleBackColor = true;
            this.btnSquared.Click += new System.EventHandler(this.btnSquared_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(255, 139);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(74, 61);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(12, 139);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 61);
            this.button8.TabIndex = 5;
            this.button8.Text = "1/x";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(174, 206);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 61);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(93, 206);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 61);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(255, 206);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(74, 61);
            this.btnMultiply.TabIndex = 10;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(12, 206);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 61);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(174, 273);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 61);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(93, 273);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 61);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(255, 273);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(74, 61);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(12, 273);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 61);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(174, 340);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 61);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(255, 340);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(74, 61);
            this.btnPlus.TabIndex = 18;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(12, 340);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 61);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDec.Location = new System.Drawing.Point(174, 407);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(75, 61);
            this.btnDec.TabIndex = 24;
            this.btnDec.Text = ".";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(93, 407);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 61);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnEqu
            // 
            this.btnEqu.BackColor = System.Drawing.Color.Blue;
            this.btnEqu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEqu.Location = new System.Drawing.Point(255, 407);
            this.btnEqu.Name = "btnEqu";
            this.btnEqu.Size = new System.Drawing.Size(74, 61);
            this.btnEqu.TabIndex = 22;
            this.btnEqu.Text = "=";
            this.btnEqu.UseVisualStyleBackColor = false;
            this.btnEqu.Click += new System.EventHandler(this.btnEqu_Click);
            // 
            // btnNeg
            // 
            this.btnNeg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNeg.Location = new System.Drawing.Point(12, 407);
            this.btnNeg.Name = "btnNeg";
            this.btnNeg.Size = new System.Drawing.Size(75, 61);
            this.btnNeg.TabIndex = 21;
            this.btnNeg.Text = "+/-";
            this.btnNeg.UseVisualStyleBackColor = true;
            this.btnNeg.Click += new System.EventHandler(this.btnNeg_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(93, 340);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 61);
            this.btn2.TabIndex = 25;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(341, 476);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnEqu);
            this.Controls.Add(this.btnNeg);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnSquared);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClrCurnt);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnPerc);
            this.Controls.Add(this.txtTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Calculator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTotal;
        private Button btnPerc;
        private Button btnDel;
        private Button btnClrCurnt;
        private Button btnClear;
        private Button btnSqrt;
        private Button btnSquared;
        private Button btnDivide;
        private Button button8;
        private Button btn9;
        private Button btn8;
        private Button btnMultiply;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btnMinus;
        private Button btn4;
        private Button btn3;
        private Button btnPlus;
        private Button btn1;
        private Button btnDec;
        private Button btn0;
        private Button btnEqu;
        private Button btnNeg;
        private Button btn2;
    }
}