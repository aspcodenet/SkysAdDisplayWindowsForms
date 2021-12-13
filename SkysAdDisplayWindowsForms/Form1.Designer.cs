namespace SkysAdDisplayWindowsForms
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.rad1 = new System.Windows.Forms.Label();
            this.rad2 = new System.Windows.Forms.Label();
            this.rad3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rad1.Location = new System.Drawing.Point(-3, 0);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(242, 75);
            this.rad1.TabIndex = 0;
            this.rad1.Text = "label1";
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rad2.Location = new System.Drawing.Point(-3, 75);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(242, 75);
            this.rad2.TabIndex = 1;
            this.rad2.Text = "label2";
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rad3.Location = new System.Drawing.Point(-3, 150);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(242, 75);
            this.rad3.TabIndex = 2;
            this.rad3.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 228);
            this.Controls.Add(this.rad3);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rad1;
        private System.Windows.Forms.Label rad2;
        private System.Windows.Forms.Label rad3;
        private System.Windows.Forms.Timer timer1;
    }
}
