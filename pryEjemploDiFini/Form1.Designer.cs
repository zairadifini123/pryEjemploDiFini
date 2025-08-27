namespace pryEjemploDiFini
{
    partial class GitHub
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
            lblTexto = new Label();
            btnAceptar = new Button();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(85, 30);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(32, 15);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Hola";
            lblTexto.Click += label1_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(42, 48);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(123, 30);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 50);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // GitHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 149);
            Controls.Add(pictureBox);
            Controls.Add(btnAceptar);
            Controls.Add(lblTexto);
            Name = "GitHub";
            Text = "GitHub";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private Button btnAceptar;
        private PictureBox pictureBox;
    }
}
