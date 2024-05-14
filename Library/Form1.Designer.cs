namespace Library
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
            btnAutor = new Button();
            btnLibro = new Button();
            SuspendLayout();
            // 
            // btnAutor
            // 
            btnAutor.Location = new Point(25, 27);
            btnAutor.Name = "btnAutor";
            btnAutor.Size = new Size(94, 49);
            btnAutor.TabIndex = 0;
            btnAutor.Text = "Autor";
            btnAutor.UseVisualStyleBackColor = true;
            btnAutor.Click += btnAutor_Click;
            // 
            // btnLibro
            // 
            btnLibro.Location = new Point(25, 110);
            btnLibro.Name = "btnLibro";
            btnLibro.Size = new Size(94, 49);
            btnLibro.TabIndex = 1;
            btnLibro.Text = "Libro";
            btnLibro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLibro);
            Controls.Add(btnAutor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAutor;
        private Button btnLibro;
    }
}