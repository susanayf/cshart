namespace tarea5
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
            label1 = new Label();
            txtperfil = new TextBox();
            txtclave = new TextBox();
            label2 = new Label();
            btnlogin = new Button();
            lblperfil = new Label();
            lblacceso = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 81);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Perfil:";
            // 
            // txtperfil
            // 
            txtperfil.Location = new Point(342, 78);
            txtperfil.Name = "txtperfil";
            txtperfil.Size = new Size(164, 23);
            txtperfil.TabIndex = 1;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(342, 141);
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(164, 23);
            txtclave.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 144);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(342, 201);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(107, 46);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // lblperfil
            // 
            lblperfil.AutoSize = true;
            lblperfil.Location = new Point(382, 281);
            lblperfil.Name = "lblperfil";
            lblperfil.Size = new Size(37, 15);
            lblperfil.TabIndex = 5;
            lblperfil.Text = "Perfil:";
            // 
            // lblacceso
            // 
            lblacceso.AutoSize = true;
            lblacceso.Location = new Point(382, 306);
            lblacceso.Name = "lblacceso";
            lblacceso.Size = new Size(45, 15);
            lblacceso.TabIndex = 6;
            lblacceso.Text = "Acceso";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblacceso);
            Controls.Add(lblperfil);
            Controls.Add(btnlogin);
            Controls.Add(txtclave);
            Controls.Add(label2);
            Controls.Add(txtperfil);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtperfil;
        private TextBox txtclave;
        private Label label2;
        private Button btnlogin;
        private Label lblperfil;
        private Label lblacceso;
    }
}
