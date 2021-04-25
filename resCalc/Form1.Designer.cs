namespace resCalc
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_source = new System.Windows.Forms.TextBox();
            this.lbl_volt = new System.Windows.Forms.Label();
            this.lbl_power = new System.Windows.Forms.Label();
            this.txt_power = new System.Windows.Forms.TextBox();
            this.lbl_currentPart = new System.Windows.Forms.Label();
            this.txt_currentPart = new System.Windows.Forms.TextBox();
            this.cmd_calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_source
            // 
            this.txt_source.Location = new System.Drawing.Point(180, 19);
            this.txt_source.Name = "txt_source";
            this.txt_source.Size = new System.Drawing.Size(103, 26);
            this.txt_source.TabIndex = 0;
            // 
            // lbl_volt
            // 
            this.lbl_volt.AutoSize = true;
            this.lbl_volt.Location = new System.Drawing.Point(22, 22);
            this.lbl_volt.Name = "lbl_volt";
            this.lbl_volt.Size = new System.Drawing.Size(139, 20);
            this.lbl_volt.TabIndex = 1;
            this.lbl_volt.Text = "Source current (V)";
            // 
            // lbl_power
            // 
            this.lbl_power.AutoSize = true;
            this.lbl_power.Location = new System.Drawing.Point(22, 54);
            this.lbl_power.Name = "lbl_power";
            this.lbl_power.Size = new System.Drawing.Size(133, 20);
            this.lbl_power.TabIndex = 3;
            this.lbl_power.Text = "Power of Part (W)";
            // 
            // txt_power
            // 
            this.txt_power.Location = new System.Drawing.Point(180, 51);
            this.txt_power.Name = "txt_power";
            this.txt_power.Size = new System.Drawing.Size(103, 26);
            this.txt_power.TabIndex = 2;
            // 
            // lbl_currentPart
            // 
            this.lbl_currentPart.AutoSize = true;
            this.lbl_currentPart.Location = new System.Drawing.Point(22, 86);
            this.lbl_currentPart.Name = "lbl_currentPart";
            this.lbl_currentPart.Size = new System.Drawing.Size(120, 20);
            this.lbl_currentPart.TabIndex = 4;
            this.lbl_currentPart.Text = "Current Part (V)";
            // 
            // txt_currentPart
            // 
            this.txt_currentPart.Location = new System.Drawing.Point(180, 83);
            this.txt_currentPart.Name = "txt_currentPart";
            this.txt_currentPart.Size = new System.Drawing.Size(103, 26);
            this.txt_currentPart.TabIndex = 5;
            // 
            // cmd_calc
            // 
            this.cmd_calc.Location = new System.Drawing.Point(26, 115);
            this.cmd_calc.Name = "cmd_calc";
            this.cmd_calc.Size = new System.Drawing.Size(257, 32);
            this.cmd_calc.TabIndex = 6;
            this.cmd_calc.Text = "Calculate!";
            this.cmd_calc.UseVisualStyleBackColor = true;
            this.cmd_calc.Click += new System.EventHandler(this.cmd_calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 165);
            this.Controls.Add(this.cmd_calc);
            this.Controls.Add(this.txt_currentPart);
            this.Controls.Add(this.lbl_currentPart);
            this.Controls.Add(this.lbl_power);
            this.Controls.Add(this.txt_power);
            this.Controls.Add(this.lbl_volt);
            this.Controls.Add(this.txt_source);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_source;
        private System.Windows.Forms.Label lbl_volt;
        private System.Windows.Forms.Label lbl_power;
        private System.Windows.Forms.TextBox txt_power;
        private System.Windows.Forms.Label lbl_currentPart;
        private System.Windows.Forms.TextBox txt_currentPart;
        private System.Windows.Forms.Button cmd_calc;
    }
}

