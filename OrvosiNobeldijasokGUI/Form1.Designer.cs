namespace OrvosiNobeldijasokGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NevTextBox = new System.Windows.Forms.TextBox();
            this.SzH_TextBox = new System.Windows.Forms.TextBox();
            this.OrszagTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EvNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.EvNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(65, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Év:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(65, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(65, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sz/H:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(65, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ország:";
            // 
            // NevTextBox
            // 
            this.NevTextBox.Location = new System.Drawing.Point(131, 70);
            this.NevTextBox.Name = "NevTextBox";
            this.NevTextBox.Size = new System.Drawing.Size(151, 20);
            this.NevTextBox.TabIndex = 5;
            // 
            // SzH_TextBox
            // 
            this.SzH_TextBox.Location = new System.Drawing.Point(131, 117);
            this.SzH_TextBox.Name = "SzH_TextBox";
            this.SzH_TextBox.Size = new System.Drawing.Size(151, 20);
            this.SzH_TextBox.TabIndex = 6;
            // 
            // OrszagTextBox
            // 
            this.OrszagTextBox.Location = new System.Drawing.Point(135, 154);
            this.OrszagTextBox.Name = "OrszagTextBox";
            this.OrszagTextBox.Size = new System.Drawing.Size(147, 20);
            this.OrszagTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adatok mentése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EvNumericUpDown
            // 
            this.EvNumericUpDown.Location = new System.Drawing.Point(131, 33);
            this.EvNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.EvNumericUpDown.Name = "EvNumericUpDown";
            this.EvNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.EvNumericUpDown.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EvNumericUpDown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrszagTextBox);
            this.Controls.Add(this.SzH_TextBox);
            this.Controls.Add(this.NevTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Orvosi Nobel-díjasok";
            ((System.ComponentModel.ISupportInitialize)(this.EvNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NevTextBox;
        private System.Windows.Forms.TextBox SzH_TextBox;
        private System.Windows.Forms.TextBox OrszagTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown EvNumericUpDown;
    }
}

