﻿namespace Prediction
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rb128 = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbABC = new System.Windows.Forms.RadioButton();
            this.rbABC2 = new System.Windows.Forms.RadioButton();
            this.rbBAC = new System.Windows.Forms.RadioButton();
            this.rbAB = new System.Windows.Forms.RadioButton();
            this.rbJpegLS = new System.Windows.Forms.RadioButton();
            this.rbOriginal = new System.Windows.Forms.RadioButton();
            this.rbError = new System.Windows.Forms.RadioButton();
            this.rbDecoded = new System.Windows.Forms.RadioButton();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnErrorMatrix = new System.Windows.Forms.Button();
            this.btnLoadEncoded = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnSaveDecoded = new System.Windows.Forms.Button();
            this.btnHistogram = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // rb128
            // 
            this.rb128.AutoSize = true;
            this.rb128.Location = new System.Drawing.Point(32, 269);
            this.rb128.Name = "rb128";
            this.rb128.Size = new System.Drawing.Size(53, 21);
            this.rb128.TabIndex = 12;
            this.rb128.TabStop = true;
            this.rb128.Text = "128";
            this.rb128.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(32, 296);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(38, 21);
            this.rbA.TabIndex = 13;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(32, 323);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(38, 21);
            this.rbB.TabIndex = 14;
            this.rbB.TabStop = true;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(32, 350);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(38, 21);
            this.rbC.TabIndex = 15;
            this.rbC.TabStop = true;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbABC
            // 
            this.rbABC.AutoSize = true;
            this.rbABC.Location = new System.Drawing.Point(32, 377);
            this.rbABC.Name = "rbABC";
            this.rbABC.Size = new System.Drawing.Size(72, 21);
            this.rbABC.TabIndex = 16;
            this.rbABC.TabStop = true;
            this.rbABC.Text = "A+B+C";
            this.rbABC.UseVisualStyleBackColor = true;
            // 
            // rbABC2
            // 
            this.rbABC2.AutoSize = true;
            this.rbABC2.Location = new System.Drawing.Point(32, 404);
            this.rbABC2.Name = "rbABC2";
            this.rbABC2.Size = new System.Drawing.Size(91, 21);
            this.rbABC2.TabIndex = 17;
            this.rbABC2.TabStop = true;
            this.rbABC2.Text = "A+(B-C)/2";
            this.rbABC2.UseVisualStyleBackColor = true;
            // 
            // rbBAC
            // 
            this.rbBAC.AutoSize = true;
            this.rbBAC.Location = new System.Drawing.Point(32, 431);
            this.rbBAC.Name = "rbBAC";
            this.rbBAC.Size = new System.Drawing.Size(91, 21);
            this.rbBAC.TabIndex = 18;
            this.rbBAC.TabStop = true;
            this.rbBAC.Text = "B+(A-C)/2";
            this.rbBAC.UseVisualStyleBackColor = true;
            // 
            // rbAB
            // 
            this.rbAB.AutoSize = true;
            this.rbAB.Location = new System.Drawing.Point(32, 458);
            this.rbAB.Name = "rbAB";
            this.rbAB.Size = new System.Drawing.Size(77, 21);
            this.rbAB.TabIndex = 19;
            this.rbAB.TabStop = true;
            this.rbAB.Text = "(A+B)/2";
            this.rbAB.UseVisualStyleBackColor = true;
            // 
            // rbJpegLS
            // 
            this.rbJpegLS.AutoSize = true;
            this.rbJpegLS.Location = new System.Drawing.Point(32, 485);
            this.rbJpegLS.Name = "rbJpegLS";
            this.rbJpegLS.Size = new System.Drawing.Size(73, 21);
            this.rbJpegLS.TabIndex = 20;
            this.rbJpegLS.TabStop = true;
            this.rbJpegLS.Text = "jpegLS";
            this.rbJpegLS.UseVisualStyleBackColor = true;
            // 
            // rbOriginal
            // 
            this.rbOriginal.AutoSize = true;
            this.rbOriginal.Location = new System.Drawing.Point(222, 269);
            this.rbOriginal.Name = "rbOriginal";
            this.rbOriginal.Size = new System.Drawing.Size(78, 21);
            this.rbOriginal.TabIndex = 21;
            this.rbOriginal.TabStop = true;
            this.rbOriginal.Text = "Original";
            this.rbOriginal.UseVisualStyleBackColor = true;
            // 
            // rbError
            // 
            this.rbError.AutoSize = true;
            this.rbError.Location = new System.Drawing.Point(222, 296);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(127, 21);
            this.rbError.TabIndex = 22;
            this.rbError.TabStop = true;
            this.rbError.Text = "Error prediction";
            this.rbError.UseVisualStyleBackColor = true;
            // 
            // rbDecoded
            // 
            this.rbDecoded.AutoSize = true;
            this.rbDecoded.Location = new System.Drawing.Point(222, 323);
            this.rbDecoded.Name = "rbDecoded";
            this.rbDecoded.Size = new System.Drawing.Size(86, 21);
            this.rbDecoded.TabIndex = 23;
            this.rbDecoded.TabStop = true;
            this.rbDecoded.Text = "Decoded";
            this.rbDecoded.UseVisualStyleBackColor = true;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(29, 196);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(94, 23);
            this.btnLoadImage.TabIndex = 24;
            this.btnLoadImage.Text = "Load image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(129, 196);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(94, 23);
            this.btnPredict.TabIndex = 25;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(229, 196);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(94, 23);
            this.btnStore.TabIndex = 26;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = true;
            // 
            // btnErrorMatrix
            // 
            this.btnErrorMatrix.Location = new System.Drawing.Point(491, 196);
            this.btnErrorMatrix.Name = "btnErrorMatrix";
            this.btnErrorMatrix.Size = new System.Drawing.Size(138, 23);
            this.btnErrorMatrix.TabIndex = 27;
            this.btnErrorMatrix.Text = "Show error matrix";
            this.btnErrorMatrix.UseVisualStyleBackColor = true;
            // 
            // btnLoadEncoded
            // 
            this.btnLoadEncoded.Location = new System.Drawing.Point(662, 196);
            this.btnLoadEncoded.Name = "btnLoadEncoded";
            this.btnLoadEncoded.Size = new System.Drawing.Size(121, 23);
            this.btnLoadEncoded.TabIndex = 28;
            this.btnLoadEncoded.Text = "Load encoded";
            this.btnLoadEncoded.UseVisualStyleBackColor = true;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(789, 196);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(121, 23);
            this.btnDecode.TabIndex = 29;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            // 
            // btnSaveDecoded
            // 
            this.btnSaveDecoded.Location = new System.Drawing.Point(916, 196);
            this.btnSaveDecoded.Name = "btnSaveDecoded";
            this.btnSaveDecoded.Size = new System.Drawing.Size(121, 23);
            this.btnSaveDecoded.TabIndex = 30;
            this.btnSaveDecoded.Text = "Save decoded";
            this.btnSaveDecoded.UseVisualStyleBackColor = true;
            // 
            // btnHistogram
            // 
            this.btnHistogram.Location = new System.Drawing.Point(225, 359);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(124, 66);
            this.btnHistogram.TabIndex = 31;
            this.btnHistogram.Text = "Show histogram";
            this.btnHistogram.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(422, 274);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(673, 231);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(679, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 172);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(361, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 172);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(40, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(268, 172);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 530);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnHistogram);
            this.Controls.Add(this.btnSaveDecoded);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnLoadEncoded);
            this.Controls.Add(this.btnErrorMatrix);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.rbDecoded);
            this.Controls.Add(this.rbError);
            this.Controls.Add(this.rbOriginal);
            this.Controls.Add(this.rbJpegLS);
            this.Controls.Add(this.rbAB);
            this.Controls.Add(this.rbBAC);
            this.Controls.Add(this.rbABC2);
            this.Controls.Add(this.rbABC);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.rb128);
            this.Name = "Form1";
            this.Text = "Prediction";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rb128;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbABC;
        private System.Windows.Forms.RadioButton rbABC2;
        private System.Windows.Forms.RadioButton rbBAC;
        private System.Windows.Forms.RadioButton rbAB;
        private System.Windows.Forms.RadioButton rbJpegLS;
        private System.Windows.Forms.RadioButton rbOriginal;
        private System.Windows.Forms.RadioButton rbError;
        private System.Windows.Forms.RadioButton rbDecoded;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnErrorMatrix;
        private System.Windows.Forms.Button btnLoadEncoded;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnSaveDecoded;
        private System.Windows.Forms.Button btnHistogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

