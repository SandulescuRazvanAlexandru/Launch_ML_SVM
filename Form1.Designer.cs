namespace Lansare_ML_SVM
{
    partial class Form1
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
            this.tbMes = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            this.btnPointsVis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMes
            // 
            this.tbMes.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbMes.Location = new System.Drawing.Point(398, 0);
            this.tbMes.Multiline = true;
            this.tbMes.Name = "tbMes";
            this.tbMes.ReadOnly = true;
            this.tbMes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMes.Size = new System.Drawing.Size(402, 752);
            this.tbMes.TabIndex = 0;
            this.tbMes.TabStop = false;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(38, 41);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(173, 53);
            this.btnTrain.TabIndex = 1;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(38, 100);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(173, 53);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(38, 159);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(173, 53);
            this.btnPredict.TabIndex = 3;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // btnPointsVis
            // 
            this.btnPointsVis.Location = new System.Drawing.Point(35, 218);
            this.btnPointsVis.Name = "btnPointsVis";
            this.btnPointsVis.Size = new System.Drawing.Size(176, 53);
            this.btnPointsVis.TabIndex = 4;
            this.btnPointsVis.Text = "Points Visualization";
            this.btnPointsVis.UseVisualStyleBackColor = true;
            this.btnPointsVis.Click += new System.EventHandler(this.btnPointsVis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Machine Learning (SVM)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 752);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPointsVis);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.tbMes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMes;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Button btnPointsVis;
        private System.Windows.Forms.Label label1;
    }
}

