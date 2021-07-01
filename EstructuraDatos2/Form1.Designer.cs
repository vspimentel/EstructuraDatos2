
namespace EstructuraDatos2
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
            this.txtIn = new System.Windows.Forms.TextBox();
            this.LSEIntOrd = new System.Windows.Forms.Button();
            this.lviewLSE = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(49, 74);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(176, 31);
            this.txtIn.TabIndex = 0;
            // 
            // LSEIntOrd
            // 
            this.LSEIntOrd.Location = new System.Drawing.Point(258, 65);
            this.LSEIntOrd.Name = "LSEIntOrd";
            this.LSEIntOrd.Size = new System.Drawing.Size(220, 40);
            this.LSEIntOrd.TabIndex = 1;
            this.LSEIntOrd.Text = "Insertar Ordenadamente";
            this.LSEIntOrd.UseVisualStyleBackColor = true;
            this.LSEIntOrd.Click += new System.EventHandler(this.LSEIntOrd_Click);
            // 
            // lviewLSE
            // 
            this.lviewLSE.HideSelection = false;
            this.lviewLSE.Location = new System.Drawing.Point(49, 221);
            this.lviewLSE.Name = "lviewLSE";
            this.lviewLSE.Size = new System.Drawing.Size(637, 150);
            this.lviewLSE.TabIndex = 2;
            this.lviewLSE.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 418);
            this.Controls.Add(this.lviewLSE);
            this.Controls.Add(this.LSEIntOrd);
            this.Controls.Add(this.txtIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Button LSEIntOrd;
        private System.Windows.Forms.ListView lviewLSE;
    }
}

