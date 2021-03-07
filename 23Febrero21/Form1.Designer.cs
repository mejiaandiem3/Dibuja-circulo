
namespace _23Febrero21
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trcBrVertical = new System.Windows.Forms.TrackBar();
            this.trcBrHorizontal = new System.Windows.Forms.TrackBar();
            this.lblTrackVertical = new System.Windows.Forms.Label();
            this.lblTrackHorizontal = new System.Windows.Forms.Label();
            this.trcBrVerticalY = new System.Windows.Forms.TrackBar();
            this.trcBrHorizontalX = new System.Windows.Forms.TrackBar();
            this.lblTrackHorizontalX = new System.Windows.Forms.Label();
            this.lblTrackVerticalY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBrVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBrHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBrVerticalY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBrHorizontalX)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(127, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trcBrVertical
            // 
            this.trcBrVertical.Location = new System.Drawing.Point(76, 41);
            this.trcBrVertical.Name = "trcBrVertical";
            this.trcBrVertical.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcBrVertical.Size = new System.Drawing.Size(45, 450);
            this.trcBrVertical.TabIndex = 1;
            this.trcBrVertical.Scroll += new System.EventHandler(this.trcBrVertical_Scroll);
            // 
            // trcBrHorizontal
            // 
            this.trcBrHorizontal.Location = new System.Drawing.Point(135, 508);
            this.trcBrHorizontal.Name = "trcBrHorizontal";
            this.trcBrHorizontal.Size = new System.Drawing.Size(592, 45);
            this.trcBrHorizontal.TabIndex = 2;
            this.trcBrHorizontal.Scroll += new System.EventHandler(this.trcBrHorizontal_Scroll);
            // 
            // lblTrackVertical
            // 
            this.lblTrackVertical.AutoSize = true;
            this.lblTrackVertical.Location = new System.Drawing.Point(73, 494);
            this.lblTrackVertical.Name = "lblTrackVertical";
            this.lblTrackVertical.Size = new System.Drawing.Size(13, 13);
            this.lblTrackVertical.TabIndex = 3;
            this.lblTrackVertical.Text = "0";
            // 
            // lblTrackHorizontal
            // 
            this.lblTrackHorizontal.AutoSize = true;
            this.lblTrackHorizontal.Location = new System.Drawing.Point(399, 540);
            this.lblTrackHorizontal.Name = "lblTrackHorizontal";
            this.lblTrackHorizontal.Size = new System.Drawing.Size(13, 13);
            this.lblTrackHorizontal.TabIndex = 4;
            this.lblTrackHorizontal.Text = "0";
            // 
            // trcBrVerticalY
            // 
            this.trcBrVerticalY.Location = new System.Drawing.Point(12, 41);
            this.trcBrVerticalY.Name = "trcBrVerticalY";
            this.trcBrVerticalY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcBrVerticalY.Size = new System.Drawing.Size(45, 450);
            this.trcBrVerticalY.TabIndex = 5;
            this.trcBrVerticalY.Scroll += new System.EventHandler(this.trcBrVerticalY_Scroll);
            // 
            // trcBrHorizontalX
            // 
            this.trcBrHorizontalX.Location = new System.Drawing.Point(135, 556);
            this.trcBrHorizontalX.Name = "trcBrHorizontalX";
            this.trcBrHorizontalX.Size = new System.Drawing.Size(592, 45);
            this.trcBrHorizontalX.TabIndex = 6;
            this.trcBrHorizontalX.Scroll += new System.EventHandler(this.trcBrHorizontalX_Scroll);
            // 
            // lblTrackHorizontalX
            // 
            this.lblTrackHorizontalX.AutoSize = true;
            this.lblTrackHorizontalX.Location = new System.Drawing.Point(399, 588);
            this.lblTrackHorizontalX.Name = "lblTrackHorizontalX";
            this.lblTrackHorizontalX.Size = new System.Drawing.Size(13, 13);
            this.lblTrackHorizontalX.TabIndex = 7;
            this.lblTrackHorizontalX.Text = "0";
            // 
            // lblTrackVerticalY
            // 
            this.lblTrackVerticalY.AutoSize = true;
            this.lblTrackVerticalY.Location = new System.Drawing.Point(9, 494);
            this.lblTrackVerticalY.Name = "lblTrackVerticalY";
            this.lblTrackVerticalY.Size = new System.Drawing.Size(13, 13);
            this.lblTrackVerticalY.TabIndex = 8;
            this.lblTrackVerticalY.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.lblTrackVerticalY);
            this.Controls.Add(this.lblTrackHorizontalX);
            this.Controls.Add(this.trcBrHorizontalX);
            this.Controls.Add(this.trcBrVerticalY);
            this.Controls.Add(this.lblTrackHorizontal);
            this.Controls.Add(this.lblTrackVertical);
            this.Controls.Add(this.trcBrHorizontal);
            this.Controls.Add(this.trcBrVertical);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Circulo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBrVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBrHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBrVerticalY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBrHorizontalX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trcBrVertical;
        private System.Windows.Forms.TrackBar trcBrHorizontal;
        private System.Windows.Forms.Label lblTrackVertical;
        private System.Windows.Forms.Label lblTrackHorizontal;
        private System.Windows.Forms.TrackBar trcBrVerticalY;
        private System.Windows.Forms.TrackBar trcBrHorizontalX;
        private System.Windows.Forms.Label lblTrackHorizontalX;
        private System.Windows.Forms.Label lblTrackVerticalY;
    }
}

