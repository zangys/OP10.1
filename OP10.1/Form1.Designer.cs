namespace TrapezoidAreaCalculator
{
    partial class MainForm
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.baseATextBox = new System.Windows.Forms.TextBox();
            this.baseBTextBox = new System.Windows.Forms.TextBox();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // baseATextBox
            // 
            this.baseATextBox.Location = new System.Drawing.Point(150, 50);
            this.baseATextBox.Name = "baseATextBox";
            this.baseATextBox.Size = new System.Drawing.Size(100, 20);
            this.baseATextBox.TabIndex = 0;
            // 
            // baseBTextBox
            // 
            this.baseBTextBox.Location = new System.Drawing.Point(150, 100);
            this.baseBTextBox.Name = "baseBTextBox";
            this.baseBTextBox.Size = new System.Drawing.Size(100, 20);
            this.baseBTextBox.TabIndex = 1;
            // 
            // angleTextBox
            // 
            this.angleTextBox.Location = new System.Drawing.Point(150, 150);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(100, 20);
            this.angleTextBox.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(150, 200);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 30);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Основание а (a):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Основание b (b):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Угол при x (угол):";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.angleTextBox);
            this.Controls.Add(this.baseBTextBox);
            this.Controls.Add(this.baseATextBox);
            this.Name = "MainForm";
            this.Text = "Площадь трапеции";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox baseATextBox;
        private System.Windows.Forms.TextBox baseBTextBox;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
