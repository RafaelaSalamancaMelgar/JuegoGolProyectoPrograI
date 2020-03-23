namespace JuegoGol
{
    partial class WinJuegoGol
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
            this.components = new System.ComponentModel.Container();
            this.pbCancha = new System.Windows.Forms.PictureBox();
            this.botonSalir = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.botonComenzar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancha)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCancha
            // 
            this.pbCancha.Location = new System.Drawing.Point(6, 5);
            this.pbCancha.Name = "pbCancha";
            this.pbCancha.Size = new System.Drawing.Size(800, 450);
            this.pbCancha.TabIndex = 0;
            this.pbCancha.TabStop = false;
            this.pbCancha.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCancha_Paint);
            // 
            // botonSalir
            // 
            this.botonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.Location = new System.Drawing.Point(737, 461);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(70, 25);
            this.botonSalir.TabIndex = 1;
            this.botonSalir.Text = "Salir";
            this.botonSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // botonComenzar
            // 
            this.botonComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonComenzar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonComenzar.Location = new System.Drawing.Point(653, 461);
            this.botonComenzar.Name = "botonComenzar";
            this.botonComenzar.Size = new System.Drawing.Size(75, 25);
            this.botonComenzar.TabIndex = 2;
            this.botonComenzar.Text = "Comenzar";
            this.botonComenzar.UseVisualStyleBackColor = true;
            this.botonComenzar.Click += new System.EventHandler(this.botonComenzar_Click);
            // 
            // WinJuegoGol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 491);
            this.Controls.Add(this.botonComenzar);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.pbCancha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WinJuegoGol";
            this.Text = "Juego Gol";
            ((System.ComponentModel.ISupportInitialize)(this.pbCancha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCancha;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button botonComenzar;
    }
}

