
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
            this.txtInLSE = new System.Windows.Forms.TextBox();
            this.LSEIntOrd = new System.Windows.Forms.Button();
            this.lview = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInLDE = new System.Windows.Forms.TextBox();
            this.LDEInt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInLSEC = new System.Windows.Forms.TextBox();
            this.LSECInt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxMul7 = new System.Windows.Forms.ListView();
            this.LSECEli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInLSE
            // 
            this.txtInLSE.Location = new System.Drawing.Point(38, 83);
            this.txtInLSE.Name = "txtInLSE";
            this.txtInLSE.Size = new System.Drawing.Size(176, 31);
            this.txtInLSE.TabIndex = 0;
            this.txtInLSE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIn_KeyPress);
            // 
            // LSEIntOrd
            // 
            this.LSEIntOrd.Location = new System.Drawing.Point(246, 83);
            this.LSEIntOrd.Name = "LSEIntOrd";
            this.LSEIntOrd.Size = new System.Drawing.Size(220, 31);
            this.LSEIntOrd.TabIndex = 1;
            this.LSEIntOrd.Text = "Insertar Ordenadamente";
            this.LSEIntOrd.UseVisualStyleBackColor = true;
            this.LSEIntOrd.Click += new System.EventHandler(this.LSEIntOrd_Click);
            // 
            // lview
            // 
            this.lview.HideSelection = false;
            this.lview.Location = new System.Drawing.Point(38, 464);
            this.lview.Name = "lview";
            this.lview.Size = new System.Drawing.Size(649, 150);
            this.lview.TabIndex = 2;
            this.lview.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista Simplemente Enlazada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista Doblemente Enlazada";
            // 
            // txtInLDE
            // 
            this.txtInLDE.Location = new System.Drawing.Point(38, 184);
            this.txtInLDE.Name = "txtInLDE";
            this.txtInLDE.Size = new System.Drawing.Size(176, 31);
            this.txtInLDE.TabIndex = 5;
            this.txtInLDE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInLDE_KeyPress);
            // 
            // LDEInt
            // 
            this.LDEInt.Location = new System.Drawing.Point(246, 184);
            this.LDEInt.Name = "LDEInt";
            this.LDEInt.Size = new System.Drawing.Size(220, 31);
            this.LDEInt.TabIndex = 6;
            this.LDEInt.Text = "Insertar";
            this.LDEInt.UseVisualStyleBackColor = true;
            this.LDEInt.Click += new System.EventHandler(this.LDEInt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista Simplemente Enlazada Circular";
            // 
            // txtInLSEC
            // 
            this.txtInLSEC.Location = new System.Drawing.Point(38, 286);
            this.txtInLSEC.Name = "txtInLSEC";
            this.txtInLSEC.Size = new System.Drawing.Size(176, 31);
            this.txtInLSEC.TabIndex = 8;
            this.txtInLSEC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInLSEC_KeyPress);
            // 
            // LSECInt
            // 
            this.LSECInt.Location = new System.Drawing.Point(246, 286);
            this.LSECInt.Name = "LSECInt";
            this.LSECInt.Size = new System.Drawing.Size(220, 31);
            this.LSECInt.TabIndex = 9;
            this.LSECInt.Text = "Insertar";
            this.LSECInt.UseVisualStyleBackColor = true;
            this.LSECInt.Click += new System.EventHandler(this.LSECInt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lista Doblemente Enlazada Circular";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 399);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 31);
            this.textBox3.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "Insertar Ordenadamente";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mulitplos de 7:";
            // 
            // BoxMul7
            // 
            this.BoxMul7.HideSelection = false;
            this.BoxMul7.Location = new System.Drawing.Point(608, 184);
            this.BoxMul7.Name = "BoxMul7";
            this.BoxMul7.Size = new System.Drawing.Size(79, 31);
            this.BoxMul7.TabIndex = 15;
            this.BoxMul7.UseCompatibleStateImageBehavior = false;
            this.BoxMul7.View = System.Windows.Forms.View.List;
            // 
            // LSECEli
            // 
            this.LSECEli.Location = new System.Drawing.Point(490, 286);
            this.LSECEli.Name = "LSECEli";
            this.LSECEli.Size = new System.Drawing.Size(220, 31);
            this.LSECEli.TabIndex = 16;
            this.LSECEli.Text = "Eliminar";
            this.LSECEli.UseVisualStyleBackColor = true;
            this.LSECEli.Click += new System.EventHandler(this.LSECEli_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 652);
            this.Controls.Add(this.LSECEli);
            this.Controls.Add(this.BoxMul7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LSECInt);
            this.Controls.Add(this.txtInLSEC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LDEInt);
            this.Controls.Add(this.txtInLDE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lview);
            this.Controls.Add(this.LSEIntOrd);
            this.Controls.Add(this.txtInLSE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInLSE;
        private System.Windows.Forms.Button LSEIntOrd;
        private System.Windows.Forms.ListView lview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInLDE;
        private System.Windows.Forms.Button LDEInt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInLSEC;
        private System.Windows.Forms.Button LSECInt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView BoxMul7;
        private System.Windows.Forms.Button LSECEli;
    }
}

