namespace Tarea_5_pts
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.rbnota = new System.Windows.Forms.RadioButton();
            this.rbfig = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbfact = new System.Windows.Forms.RadioButton();
            this.rbestudiante = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbestudiante);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.btnaceptar);
            this.groupBox1.Controls.Add(this.rbnota);
            this.groupBox1.Controls.Add(this.rbfig);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbfact);
            this.groupBox1.Location = new System.Drawing.Point(89, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(152, 268);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 33);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnaceptar.Location = new System.Drawing.Point(325, 268);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(94, 34);
            this.btnaceptar.TabIndex = 4;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // rbnota
            // 
            this.rbnota.AutoSize = true;
            this.rbnota.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.rbnota.Location = new System.Drawing.Point(196, 174);
            this.rbnota.Name = "rbnota";
            this.rbnota.Size = new System.Drawing.Size(175, 31);
            this.rbnota.TabIndex = 3;
            this.rbnota.TabStop = true;
            this.rbnota.Text = "Promedio notas";
            this.rbnota.UseVisualStyleBackColor = true;
            // 
            // rbfig
            // 
            this.rbfig.AutoSize = true;
            this.rbfig.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.rbfig.Location = new System.Drawing.Point(196, 125);
            this.rbfig.Name = "rbfig";
            this.rbfig.Size = new System.Drawing.Size(135, 31);
            this.rbfig.TabIndex = 2;
            this.rbfig.TabStop = true;
            this.rbfig.Text = "Area figura";
            this.rbfig.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(193, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la opcion que desee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbfact
            // 
            this.rbfact.AutoSize = true;
            this.rbfact.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.rbfact.Location = new System.Drawing.Point(196, 76);
            this.rbfact.Name = "rbfact";
            this.rbfact.Size = new System.Drawing.Size(111, 31);
            this.rbfact.TabIndex = 0;
            this.rbfact.TabStop = true;
            this.rbfact.Text = "Factorial";
            this.rbfact.UseVisualStyleBackColor = true;
            // 
            // rbestudiante
            // 
            this.rbestudiante.AutoSize = true;
            this.rbestudiante.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.rbestudiante.Location = new System.Drawing.Point(196, 217);
            this.rbestudiante.Name = "rbestudiante";
            this.rbestudiante.Size = new System.Drawing.Size(187, 31);
            this.rbestudiante.TabIndex = 6;
            this.rbestudiante.TabStop = true;
            this.rbestudiante.Text = "Datos estudiante";
            this.rbestudiante.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.RadioButton rbnota;
        private System.Windows.Forms.RadioButton rbfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbfact;
        private System.Windows.Forms.RadioButton rbestudiante;
    }
}