namespace Bai06
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Panel panelMemory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.panelMemory = new System.Windows.Forms.Panel();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.panelMemory.SuspendLayout();
            this.SuspendLayout();

            // txtDisplay
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.txtDisplay.Location = new System.Drawing.Point(25, 50);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(490, 38);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0.";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.BackColor = System.Drawing.Color.White;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            // panelMemory (indicator area - empty box on left)
            this.panelMemory.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelMemory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMemory.Location = new System.Drawing.Point(25, 110);
            this.panelMemory.Name = "panelMemory";
            this.panelMemory.Size = new System.Drawing.Size(65, 50);
            this.panelMemory.TabIndex = 28;

            // btnBackspace
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
            this.btnBackspace.Location = new System.Drawing.Point(110, 110);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(125, 50);
            this.btnBackspace.TabIndex = 1;
            this.btnBackspace.Text = "Backspace";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.ForeColor = System.Drawing.Color.Red;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);

            // btnCE
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCE.Location = new System.Drawing.Point(255, 110);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(125, 50);
            this.btnCE.TabIndex = 2;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.ForeColor = System.Drawing.Color.Red;
            this.btnCE.Click += new System.EventHandler(this.btnClearEntry_Click);

            // btnC
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnC.Location = new System.Drawing.Point(400, 110);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(115, 50);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.ForeColor = System.Drawing.Color.Red;
            this.btnC.Click += new System.EventHandler(this.btnClear_Click);

            // Row 1: MC, 7, 8, 9, /, sqrt
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMC.Location = new System.Drawing.Point(25, 180);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(65, 50);
            this.btnMC.TabIndex = 4;
            this.btnMC.Text = "MC";
            this.btnMC.Tag = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.ForeColor = System.Drawing.Color.Red;
            this.btnMC.Click += new System.EventHandler(this.Memory_Click);

            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn7.Location = new System.Drawing.Point(110, 180);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 50);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.ForeColor = System.Drawing.Color.Blue;
            this.btn7.Click += new System.EventHandler(this.Digit_Click);

            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(190, 180);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 50);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.ForeColor = System.Drawing.Color.Blue;
            this.btn8.Click += new System.EventHandler(this.Digit_Click);

            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn9.Location = new System.Drawing.Point(270, 180);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 50);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.ForeColor = System.Drawing.Color.Blue;
            this.btn9.Click += new System.EventHandler(this.Digit_Click);

            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDivide.Location = new System.Drawing.Point(350, 180);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 50);
            this.btnDivide.TabIndex = 11;
            this.btnDivide.Text = "/";
            this.btnDivide.Tag = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.ForeColor = System.Drawing.Color.Red;
            this.btnDivide.Click += new System.EventHandler(this.Operator_Click);

            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSqrt.Location = new System.Drawing.Point(430, 180);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(85, 50);
            this.btnSqrt.TabIndex = 12;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.ForeColor = System.Drawing.Color.Blue;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);

            // Row 2: MR, 4, 5, 6, *, %
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMR.Location = new System.Drawing.Point(25, 250);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(65, 50);
            this.btnMR.TabIndex = 5;
            this.btnMR.Text = "MR";
            this.btnMR.Tag = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.ForeColor = System.Drawing.Color.Red;
            this.btnMR.Click += new System.EventHandler(this.Memory_Click);

            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(110, 250);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 50);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.ForeColor = System.Drawing.Color.Blue;
            this.btn4.Click += new System.EventHandler(this.Digit_Click);

            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(190, 250);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 50);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.ForeColor = System.Drawing.Color.Blue;
            this.btn5.Click += new System.EventHandler(this.Digit_Click);

            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(270, 250);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 50);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.ForeColor = System.Drawing.Color.Blue;
            this.btn6.Click += new System.EventHandler(this.Digit_Click);

            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMultiply.Location = new System.Drawing.Point(350, 250);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 50);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "*";
            this.btnMultiply.Tag = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.ForeColor = System.Drawing.Color.Red;
            this.btnMultiply.Click += new System.EventHandler(this.Operator_Click);

            this.btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPercent.Location = new System.Drawing.Point(430, 250);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(85, 50);
            this.btnPercent.TabIndex = 17;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.ForeColor = System.Drawing.Color.Blue;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);

            // Row 3: MS, 1, 2, 3, -, 1/x
            this.btnMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMS.Location = new System.Drawing.Point(25, 320);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(65, 50);
            this.btnMS.TabIndex = 6;
            this.btnMS.Text = "MS";
            this.btnMS.Tag = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.ForeColor = System.Drawing.Color.Red;
            this.btnMS.Click += new System.EventHandler(this.Memory_Click);

            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(110, 320);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 50);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.ForeColor = System.Drawing.Color.Blue;
            this.btn1.Click += new System.EventHandler(this.Digit_Click);

            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(190, 320);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 50);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.ForeColor = System.Drawing.Color.Blue;
            this.btn2.Click += new System.EventHandler(this.Digit_Click);

            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(270, 320);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 50);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.ForeColor = System.Drawing.Color.Blue;
            this.btn3.Click += new System.EventHandler(this.Digit_Click);

            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinus.Location = new System.Drawing.Point(350, 320);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(60, 50);
            this.btnMinus.TabIndex = 21;
            this.btnMinus.Text = "-";
            this.btnMinus.Tag = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.ForeColor = System.Drawing.Color.Red;
            this.btnMinus.Click += new System.EventHandler(this.Operator_Click);

            this.btnReciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnReciprocal.Location = new System.Drawing.Point(430, 320);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(85, 50);
            this.btnReciprocal.TabIndex = 22;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.ForeColor = System.Drawing.Color.Blue;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);

            // Row 4: M+, 0, +/-, ., +, =
            this.btnMPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMPlus.Location = new System.Drawing.Point(25, 390);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(65, 50);
            this.btnMPlus.TabIndex = 7;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.Tag = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.ForeColor = System.Drawing.Color.Red;
            this.btnMPlus.Click += new System.EventHandler(this.Memory_Click);

            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn0.Location = new System.Drawing.Point(110, 390);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 50);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.ForeColor = System.Drawing.Color.Blue;
            this.btn0.Click += new System.EventHandler(this.Digit_Click);

            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnPlusMinus.Location = new System.Drawing.Point(190, 390);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(60, 50);
            this.btnPlusMinus.TabIndex = 24;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.ForeColor = System.Drawing.Color.Blue;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);

            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDot.Location = new System.Drawing.Point(270, 390);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(60, 50);
            this.btnDot.TabIndex = 25;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.ForeColor = System.Drawing.Color.Blue;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);

            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlus.Location = new System.Drawing.Point(350, 390);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(60, 50);
            this.btnPlus.TabIndex = 26;
            this.btnPlus.Text = "+";
            this.btnPlus.Tag = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.ForeColor = System.Drawing.Color.Red;
            this.btnPlus.Click += new System.EventHandler(this.Operator_Click);

            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEquals.Location = new System.Drawing.Point(430, 390);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(85, 50);
            this.btnEquals.TabIndex = 27;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.ForeColor = System.Drawing.Color.Red;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 465);
            this.Controls.Add(this.panelMemory);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEquals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelMemory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}