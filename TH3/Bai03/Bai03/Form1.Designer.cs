namespace Bai03
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnChangeColor;

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
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(150, 120);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(120, 30);
            this.btnChangeColor.TabIndex = 0;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 280);
            this.Controls.Add(this.btnChangeColor);
            this.Name = "Form1";
            this.Text = "Change Background Color";
            this.ResumeLayout(false);

        }
    }
}
