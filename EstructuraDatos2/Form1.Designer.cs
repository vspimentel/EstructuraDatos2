
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
            this.txtInLDEC = new System.Windows.Forms.TextBox();
            this.LDECInt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxMul7 = new System.Windows.Forms.ListView();
            this.LSECEli = new System.Windows.Forms.Button();
            this.LDECEli = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInLDECC = new System.Windows.Forms.TextBox();
            this.LDECCInt = new System.Windows.Forms.Button();
            this.LDECCEli = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BoxCabeza = new System.Windows.Forms.ListView();
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
            this.lview.Location = new System.Drawing.Point(38, 580);
            this.lview.Name = "lview";
            this.lview.Size = new System.Drawing.Size(672, 150);
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
            // txtInLDEC
            // 
            this.txtInLDEC.Location = new System.Drawing.Point(38, 399);
            this.txtInLDEC.Name = "txtInLDEC";
            this.txtInLDEC.Size = new System.Drawing.Size(176, 31);
            this.txtInLDEC.TabIndex = 11;
            this.txtInLDEC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInLDEC_KeyPress);
            // 
            // LDECInt
            // 
            this.LDECInt.Location = new System.Drawing.Point(246, 399);
            this.LDECInt.Name = "LDECInt";
            this.LDECInt.Size = new System.Drawing.Size(220, 31);
            this.LDECInt.TabIndex = 12;
            this.LDECInt.Text = "Insertar";
            this.LDECInt.UseVisualStyleBackColor = true;
            this.LDECInt.Click += new System.EventHandler(this.LDECInt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mulitplos de 7:";
            // 
            // BoxMul7
            // 
            this.BoxMul7.HideSelection = false;
            this.BoxMul7.Location = new System.Drawing.Point(631, 184);
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
            // LDECEli
            // 
            this.LDECEli.Location = new System.Drawing.Point(490, 399);
            this.LDECEli.Name = "LDECEli";
            this.LDECEli.Size = new System.Drawing.Size(220, 31);
            this.LDECEli.TabIndex = 17;
            this.LDECEli.Text = "Eliminar";
            this.LDECEli.UseVisualStyleBackColor = true;
            this.LDECEli.Click += new System.EventHandler(this.LDECEli_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(383, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Lista Doblemente Enlazada Circular con Cabeza";
            // 
            // txtInLDECC
            // 
            this.txtInLDECC.Location = new System.Drawing.Point(38, 512);
            this.txtInLDECC.Name = "txtInLDECC";
            this.txtInLDECC.Size = new System.Drawing.Size(176, 31);
            this.txtInLDECC.TabIndex = 19;
            this.txtInLDECC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInLDECC_KeyPress);
            // 
            // LDECCInt
            // 
            this.LDECCInt.Location = new System.Drawing.Point(246, 512);
            this.LDECCInt.Name = "LDECCInt";
            this.LDECCInt.Size = new System.Drawing.Size(220, 31);
            this.LDECCInt.TabIndex = 20;
            this.LDECCInt.Text = "Insertar";
            this.LDECCInt.UseVisualStyleBackColor = true;
            this.LDECCInt.Click += new System.EventHandler(this.LDECCInt_Click);
            // 
            // LDECCEli
            // 
            this.LDECCEli.Location = new System.Drawing.Point(490, 512);
            this.LDECCEli.Name = "LDECCEli";
            this.LDECCEli.Size = new System.Drawing.Size(220, 31);
            this.LDECCEli.TabIndex = 21;
            this.LDECCEli.Text = "Eliminar";
            this.LDECCEli.UseVisualStyleBackColor = true;
            this.LDECCEli.Click += new System.EventHandler(this.LDECCEli_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cant. de Elementos:";
            // 
            // BoxCabeza
            // 
            this.BoxCabeza.HideSelection = false;
            this.BoxCabeza.Location = new System.Drawing.Point(631, 460);
            this.BoxCabeza.Name = "BoxCabeza";
            this.BoxCabeza.Size = new System.Drawing.Size(79, 31);
            this.BoxCabeza.TabIndex = 23;
            this.BoxCabeza.UseCompatibleStateImageBehavior = false;
            this.BoxCabeza.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 761);
            this.Controls.Add(this.BoxCabeza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LDECCEli);
            this.Controls.Add(this.LDECCInt);
            this.Controls.Add(this.txtInLDECC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LDECEli);
            this.Controls.Add(this.LSECEli);
            this.Controls.Add(this.BoxMul7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LDECInt);
            this.Controls.Add(this.txtInLDEC);
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
        private System.Windows.Forms.TextBox txtInLDEC;
        private System.Windows.Forms.Button LDECInt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView BoxMul7;
        private System.Windows.Forms.Button LSECEli;
        private System.Windows.Forms.Button LDECEli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInLDECC;
        private System.Windows.Forms.Button LDECCInt;
        private System.Windows.Forms.Button LDECCEli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView BoxCabeza;
    }
}

