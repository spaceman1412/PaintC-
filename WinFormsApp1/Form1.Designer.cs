
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxDashStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonEclipse
            // 
            this.buttonEclipse.Location = new System.Drawing.Point(38, 93);
            this.buttonEclipse.Name = "buttonEclipse";
            this.buttonEclipse.Size = new System.Drawing.Size(109, 35);
            this.buttonEclipse.TabIndex = 1;
            this.buttonEclipse.Text = "Eclipse";
            this.buttonEclipse.UseVisualStyleBackColor = true;
            this.buttonEclipse.Click += new System.EventHandler(this.buttonEclipse_Click);
            // 
            // buttonFilledEclipse
            // 
            this.buttonFilledEclipse.Location = new System.Drawing.Point(38, 134);
            this.buttonFilledEclipse.Name = "buttonFilledEclipse";
            this.buttonFilledEclipse.Size = new System.Drawing.Size(109, 35);
            this.buttonFilledEclipse.TabIndex = 2;
            this.buttonFilledEclipse.Text = "Filled Eclipse";
            this.buttonFilledEclipse.UseVisualStyleBackColor = true;
            this.buttonFilledEclipse.Click += new System.EventHandler(this.buttonFilledEclipse_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(38, 175);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(109, 35);
            this.buttonRectangle.TabIndex = 3;
            this.buttonRectangle.Text = "Rectangle";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
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
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonFilledCircle
            // 
            this.buttonFilledCircle.Location = new System.Drawing.Point(38, 298);
            this.buttonFilledCircle.Name = "buttonFilledCircle";
            this.buttonFilledCircle.Size = new System.Drawing.Size(109, 35);
            this.buttonFilledCircle.TabIndex = 6;
            this.buttonFilledCircle.Text = "Filled Circle";
            this.buttonFilledCircle.UseVisualStyleBackColor = true;
            this.buttonFilledCircle.Click += new System.EventHandler(this.buttonFilledCircle_Click);
            // 
            // buttonArc
            // 
            this.buttonArc.Location = new System.Drawing.Point(38, 339);
            this.buttonArc.Name = "buttonArc";
            this.buttonArc.Size = new System.Drawing.Size(109, 35);
            this.buttonArc.TabIndex = 7;
            this.buttonArc.Text = "Arc";
            this.buttonArc.UseVisualStyleBackColor = true;
            this.buttonArc.Click += new System.EventHandler(this.buttonArc_Click);
            // 
            // buttonPolygon
            // 
            this.buttonPolygon.Location = new System.Drawing.Point(38, 380);
            this.buttonPolygon.Name = "buttonPolygon";
            this.buttonPolygon.Size = new System.Drawing.Size(109, 35);
            this.buttonPolygon.TabIndex = 8;
            this.buttonPolygon.Text = "Polygon";
            this.buttonPolygon.UseVisualStyleBackColor = true;
            this.buttonPolygon.Click += new System.EventHandler(this.buttonPolygon_Click);
            // 
            // buttonFilledPolygon
            // 
            this.buttonFilledPolygon.Location = new System.Drawing.Point(38, 421);
            this.buttonFilledPolygon.Name = "buttonFilledPolygon";
            this.buttonFilledPolygon.Size = new System.Drawing.Size(109, 35);
            this.buttonFilledPolygon.TabIndex = 9;
            this.buttonFilledPolygon.Text = "Filled Polygon";
            this.buttonFilledPolygon.UseVisualStyleBackColor = true;
            this.buttonFilledPolygon.Click += new System.EventHandler(this.buttonFilledPolygon_Click);
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.plMain.Location = new System.Drawing.Point(193, 52);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(698, 404);
            this.plMain.TabIndex = 10;
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            this.plMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseUp);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(964, 364);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 35);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxDashStyle
            // 
            this.comboBoxDashStyle.FormattingEnabled = true;
            this.comboBoxDashStyle.Items.AddRange(new object[] {
            "Solid",
            "Dot",
            "Dash",
            "DashDot",
            "DashDotDot"});
            this.comboBoxDashStyle.Location = new System.Drawing.Point(957, 84);
            this.comboBoxDashStyle.Name = "comboBoxDashStyle";
            this.comboBoxDashStyle.Size = new System.Drawing.Size(134, 23);
            this.comboBoxDashStyle.TabIndex = 12;
            this.comboBoxDashStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxDashStyle_SelectedIndexChanged);
            this.comboBoxDashStyle.SelectedValueChanged += new System.EventHandler(this.comboBoxDashStyle_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(964, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dash Style";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(987, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Color";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Yellow"});
            this.comboBoxColor.Location = new System.Drawing.Point(957, 166);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(134, 23);
            this.comboBoxColor.TabIndex = 16;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            this.comboBoxColor.ValueMemberChanged += new System.EventHandler(this.comboBoxColor_ValueMemberChanged);
            this.comboBoxColor.SelectedValueChanged += new System.EventHandler(this.comboBoxColor_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(987, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Size";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(957, 245);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(134, 23);
            this.textBoxSize.TabIndex = 19;
            this.textBoxSize.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(987, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "Zoom";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(958, 421);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 22;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 20;
            this.trackBar1.Location = new System.Drawing.Point(964, 316);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.SmallChange = 20;
            this.trackBar1.TabIndex = 23;
            this.trackBar1.TickFrequency = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 495);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDashStyle);
            this.Controls.Add(this.buttonDelete);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxDashStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

