
namespace WinFormsApp1
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
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonEclipse = new System.Windows.Forms.Button();
            this.buttonFilledEclipse = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonFilledRectangle = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonFilledCircle = new System.Windows.Forms.Button();
            this.buttonArc = new System.Windows.Forms.Button();
            this.buttonPolygon = new System.Windows.Forms.Button();
            this.buttonFilledPolygon = new System.Windows.Forms.Button();
            this.plMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(38, 52);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(109, 35);
            this.buttonLine.TabIndex = 0;
            this.buttonLine.Text = "Line";
            this.buttonLine.UseVisualStyleBackColor = true;
            // 
            // buttonEclipse
            // 
            this.buttonEclipse.Location = new System.Drawing.Point(38, 93);
            this.buttonEclipse.Name = "buttonEclipse";
            this.buttonEclipse.Size = new System.Drawing.Size(109, 35);
            this.buttonEclipse.TabIndex = 1;
            this.buttonEclipse.Text = "Eclipse";
            this.buttonEclipse.UseVisualStyleBackColor = true;
            // 
            // buttonFilledEclipse
            // 
            this.buttonFilledEclipse.Location = new System.Drawing.Point(38, 134);
            this.buttonFilledEclipse.Name = "buttonFilledEclipse";
            this.buttonFilledEclipse.Size = new System.Drawing.Size(109, 35);
            this.buttonFilledEclipse.TabIndex = 2;
            this.buttonFilledEclipse.Text = "Filled Eclipse";
            this.buttonFilledEclipse.UseVisualStyleBackColor = true;
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(38, 175);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(109, 35);
            this.buttonRectangle.TabIndex = 3;
            this.buttonRectangle.Text = "Rectangle";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            // 
            // buttonFilledRectangle
            // 
            this.buttonFilledRectangle.Location = new System.Drawing.Point(38, 216);
            this.buttonFilledRectangle.Name = "buttonFilledRectangle";
            this.buttonFilledRectangle.Size = new System.Drawing.Size(109, 35);
            this.buttonFilledRectangle.TabIndex = 4;
            this.buttonFilledRectangle.Text = "Filled Rectangle";
            this.buttonFilledRectangle.UseVisualStyleBackColor = true;
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(38, 257);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(109, 35);
            this.buttonCircle.TabIndex = 5;
            this.buttonCircle.Text = "Circle";
            this.buttonCircle.UseVisualStyleBackColor = true;
            // 
            // buttonFilledCircle
            // 
            this.buttonFilledCircle.Location = new System.Drawing.Point(38, 298);
            this.buttonFilledCircle.Name = "buttonFilledCircle";
            this.buttonFilledCircle.Size = new System.Drawing.Size(109, 35);
            this.buttonFilledCircle.TabIndex = 6;
            this.buttonFilledCircle.Text = "Filled Circle";
            this.buttonFilledCircle.UseVisualStyleBackColor = true;
            // 
            // buttonArc
            // 
            this.buttonArc.Location = new System.Drawing.Point(38, 339);
            this.buttonArc.Name = "buttonArc";
            this.buttonArc.Size = new System.Drawing.Size(109, 35);
            this.buttonArc.TabIndex = 7;
            this.buttonArc.Text = "Arc";
            this.buttonArc.UseVisualStyleBackColor = true;
            // 
            // buttonPolygon
            // 
            this.buttonPolygon.Location = new System.Drawing.Point(38, 380);
            this.buttonPolygon.Name = "buttonPolygon";
            this.buttonPolygon.Size = new System.Drawing.Size(109, 35);
            this.buttonPolygon.TabIndex = 8;
            this.buttonPolygon.Text = "Polygon";
            this.buttonPolygon.UseVisualStyleBackColor = true;
            // 
            // buttonFilledPolygon
            // 
            this.buttonFilledPolygon.Location = new System.Drawing.Point(38, 421);
            this.buttonFilledPolygon.Name = "buttonFilledPolygon";
            this.buttonFilledPolygon.Size = new System.Drawing.Size(109, 35);
            this.buttonFilledPolygon.TabIndex = 9;
            this.buttonFilledPolygon.Text = "Filled Polygon";
            this.buttonFilledPolygon.UseVisualStyleBackColor = true;
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.plMain.Location = new System.Drawing.Point(193, 52);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(698, 404);
            this.plMain.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 495);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.buttonFilledPolygon);
            this.Controls.Add(this.buttonPolygon);
            this.Controls.Add(this.buttonArc);
            this.Controls.Add(this.buttonFilledCircle);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonFilledRectangle);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonFilledEclipse);
            this.Controls.Add(this.buttonEclipse);
            this.Controls.Add(this.buttonLine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonEclipse;
        private System.Windows.Forms.Button buttonFilledEclipse;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonFilledRectangle;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonFilledCircle;
        private System.Windows.Forms.Button buttonArc;
        private System.Windows.Forms.Button buttonPolygon;
        private System.Windows.Forms.Button buttonFilledPolygon;
        private System.Windows.Forms.Panel plMain;
    }
}

