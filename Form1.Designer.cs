namespace ClickerApp
{
    partial class FirstButton
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
            this.buttonfirst = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonfirst
            // 
            this.buttonfirst.BackColor = System.Drawing.Color.Crimson;
            this.buttonfirst.Location = new System.Drawing.Point(183, 165);
            this.buttonfirst.Name = "buttonfirst";
            this.buttonfirst.Size = new System.Drawing.Size(200, 150);
            this.buttonfirst.TabIndex = 0;
            this.buttonfirst.Text = "Click me";
            this.buttonfirst.UseVisualStyleBackColor = false;
            this.buttonfirst.Click += new System.EventHandler(this.buttonfirst_Click);
            this.buttonfirst.MouseEnter += new System.EventHandler(this.buttonfirst_MouseEnter);
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(637, 165);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(75, 23);
            this.closebutton.TabIndex = 1;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            this.closebutton.MouseEnter += new System.EventHandler(this.closebutton_MouseEnter);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(169, 78);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(75, 23);
            this.resetbutton.TabIndex = 2;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            
            // 
            // FirstButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.buttonfirst);
            this.Name = "FirstButton";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonfirst;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button resetbutton;
    }
}

