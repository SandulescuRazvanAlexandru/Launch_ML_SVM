
namespace Lansare_ML_SVM
{
    partial class VizualizareFunctii
    {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setariGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonFunctie1 = new System.Windows.Forms.RadioButton();
            this.radioButtonFunctie2 = new System.Windows.Forms.RadioButton();
            this.radioButtonFunctie3 = new System.Windows.Forms.RadioButton();
            this.grafic = new ControlUtilizator.ControlGrafic();
            this.radioBtnParabola3D = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setariGraficToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setariGraficToolStripMenuItem
            // 
            this.setariGraficToolStripMenuItem.Name = "setariGraficToolStripMenuItem";
            this.setariGraficToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.setariGraficToolStripMenuItem.Text = "Setari grafic";
            this.setariGraficToolStripMenuItem.Click += new System.EventHandler(this.setariGraficToolStripMenuItem_Click);
            // 
            // radioButtonFunctie1
            // 
            this.radioButtonFunctie1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonFunctie1.AutoSize = true;
            this.radioButtonFunctie1.Location = new System.Drawing.Point(697, 177);
            this.radioButtonFunctie1.Name = "radioButtonFunctie1";
            this.radioButtonFunctie1.Size = new System.Drawing.Size(78, 17);
            this.radioButtonFunctie1.TabIndex = 2;
            this.radioButtonFunctie1.TabStop = true;
            this.radioButtonFunctie1.Text = "x^2-2xy+2y";
            this.radioButtonFunctie1.UseVisualStyleBackColor = true;
            this.radioButtonFunctie1.CheckedChanged += new System.EventHandler(this.radioButtonFunctie1_CheckedChanged);
            // 
            // radioButtonFunctie2
            // 
            this.radioButtonFunctie2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonFunctie2.AutoSize = true;
            this.radioButtonFunctie2.Location = new System.Drawing.Point(697, 216);
            this.radioButtonFunctie2.Name = "radioButtonFunctie2";
            this.radioButtonFunctie2.Size = new System.Drawing.Size(102, 17);
            this.radioButtonFunctie2.TabIndex = 3;
            this.radioButtonFunctie2.TabStop = true;
            this.radioButtonFunctie2.Text = "sinx * siny / (x*y)";
            this.radioButtonFunctie2.UseVisualStyleBackColor = true;
            this.radioButtonFunctie2.CheckedChanged += new System.EventHandler(this.radioButtonFunctie2_CheckedChanged);
            // 
            // radioButtonFunctie3
            // 
            this.radioButtonFunctie3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonFunctie3.AutoSize = true;
            this.radioButtonFunctie3.Location = new System.Drawing.Point(699, 250);
            this.radioButtonFunctie3.Name = "radioButtonFunctie3";
            this.radioButtonFunctie3.Size = new System.Drawing.Size(111, 17);
            this.radioButtonFunctie3.TabIndex = 4;
            this.radioButtonFunctie3.TabStop = true;
            this.radioButtonFunctie3.Text = "-xy * exp(-x^2-y^2)";
            this.radioButtonFunctie3.UseVisualStyleBackColor = true;
            this.radioButtonFunctie3.CheckedChanged += new System.EventHandler(this.radioButtonFunctie3_CheckedChanged);
            // 
            // grafic
            // 
            this.grafic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grafic.BackColor = System.Drawing.Color.White;
            this.grafic.Location = new System.Drawing.Point(12, 27);
            this.grafic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grafic.Name = "grafic";
            this.grafic.Size = new System.Drawing.Size(670, 534);
            this.grafic.TabIndex = 0;
            // 
            // radioBtnParabola3D
            // 
            this.radioBtnParabola3D.AutoSize = true;
            this.radioBtnParabola3D.Location = new System.Drawing.Point(702, 273);
            this.radioBtnParabola3D.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnParabola3D.Name = "radioBtnParabola3D";
            this.radioBtnParabola3D.Size = new System.Drawing.Size(65, 17);
            this.radioBtnParabola3D.TabIndex = 5;
            this.radioBtnParabola3D.TabStop = true;
            this.radioBtnParabola3D.Text = "x^2+y^2";
            this.radioBtnParabola3D.UseVisualStyleBackColor = true;
            this.radioBtnParabola3D.CheckedChanged += new System.EventHandler(this.radioBtnParabola3D_CheckedChanged);
            // 
            // VizualizareFunctii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 586);
            this.Controls.Add(this.radioBtnParabola3D);
            this.Controls.Add(this.radioButtonFunctie3);
            this.Controls.Add(this.radioButtonFunctie2);
            this.Controls.Add(this.radioButtonFunctie1);
            this.Controls.Add(this.grafic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VizualizareFunctii";
            this.Text = "Vizualizare Functii";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlUtilizator.ControlGrafic grafic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setariGraficToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonFunctie1;
        private System.Windows.Forms.RadioButton radioButtonFunctie2;
        private System.Windows.Forms.RadioButton radioButtonFunctie3;
        private System.Windows.Forms.RadioButton radioBtnParabola3D;
    }
}