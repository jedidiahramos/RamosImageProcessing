namespace RamosImageProcessing
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
            components = new System.ComponentModel.Container();
            boxB = new PictureBox();
            boxGreen = new PictureBox();
            loadBtn = new Button();
            saveBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            copyBtn = new Button();
            greyBtn = new Button();
            invertBtn = new Button();
            histogramBtn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            sepiaBtn = new Button();
            boxA = new PictureBox();
            backgroundBtn = new Button();
            subtractBtn = new Button();
            openFileDialog2 = new OpenFileDialog();
            webcamBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)boxB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxA).BeginInit();
            SuspendLayout();
            // 
            // boxB
            // 
            boxB.Location = new Point(12, 12);
            boxB.Name = "boxB";
            boxB.Size = new Size(400, 400);
            boxB.SizeMode = PictureBoxSizeMode.StretchImage;
            boxB.TabIndex = 0;
            boxB.TabStop = false;
            // 
            // boxGreen
            // 
            boxGreen.Location = new Point(903, 12);
            boxGreen.Name = "boxGreen";
            boxGreen.Size = new Size(400, 400);
            boxGreen.SizeMode = PictureBoxSizeMode.StretchImage;
            boxGreen.TabIndex = 1;
            boxGreen.TabStop = false;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(134, 418);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(145, 54);
            loadBtn.TabIndex = 2;
            loadBtn.Text = "Load Image";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(1029, 500);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(145, 54);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Save Image";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // copyBtn
            // 
            copyBtn.Location = new Point(134, 500);
            copyBtn.Name = "copyBtn";
            copyBtn.Size = new Size(145, 54);
            copyBtn.TabIndex = 4;
            copyBtn.Text = "Basic Copy";
            copyBtn.UseVisualStyleBackColor = true;
            copyBtn.Click += copyBtn_Click;
            // 
            // greyBtn
            // 
            greyBtn.Location = new Point(314, 500);
            greyBtn.Name = "greyBtn";
            greyBtn.Size = new Size(145, 54);
            greyBtn.TabIndex = 5;
            greyBtn.Text = "Greyscale";
            greyBtn.UseVisualStyleBackColor = true;
            greyBtn.Click += greyBtn_Click;
            // 
            // invertBtn
            // 
            invertBtn.Location = new Point(491, 500);
            invertBtn.Name = "invertBtn";
            invertBtn.Size = new Size(145, 54);
            invertBtn.TabIndex = 6;
            invertBtn.Text = "Color Inversion";
            invertBtn.UseVisualStyleBackColor = true;
            invertBtn.Click += invertBtn_Click;
            // 
            // histogramBtn
            // 
            histogramBtn.Location = new Point(672, 500);
            histogramBtn.Name = "histogramBtn";
            histogramBtn.Size = new Size(145, 54);
            histogramBtn.TabIndex = 7;
            histogramBtn.Text = "Histogram";
            histogramBtn.UseVisualStyleBackColor = true;
            histogramBtn.Click += histogramBtn_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // sepiaBtn
            // 
            sepiaBtn.Location = new Point(851, 500);
            sepiaBtn.Name = "sepiaBtn";
            sepiaBtn.Size = new Size(145, 54);
            sepiaBtn.TabIndex = 8;
            sepiaBtn.Text = "Sepia";
            sepiaBtn.UseVisualStyleBackColor = true;
            sepiaBtn.Click += sepiaBtn_Click;
            // 
            // boxA
            // 
            boxA.Location = new Point(458, 12);
            boxA.Name = "boxA";
            boxA.Size = new Size(400, 400);
            boxA.SizeMode = PictureBoxSizeMode.StretchImage;
            boxA.TabIndex = 9;
            boxA.TabStop = false;
            // 
            // backgroundBtn
            // 
            backgroundBtn.Location = new Point(581, 418);
            backgroundBtn.Name = "backgroundBtn";
            backgroundBtn.Size = new Size(145, 54);
            backgroundBtn.TabIndex = 10;
            backgroundBtn.Text = "Load Background";
            backgroundBtn.UseVisualStyleBackColor = true;
            backgroundBtn.Click += backgroundBtn_Click;
            // 
            // subtractBtn
            // 
            subtractBtn.Location = new Point(1029, 418);
            subtractBtn.Name = "subtractBtn";
            subtractBtn.Size = new Size(145, 54);
            subtractBtn.TabIndex = 11;
            subtractBtn.Text = "Subtract";
            subtractBtn.UseVisualStyleBackColor = true;
            subtractBtn.Click += subtractBtn_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // webcamBtn
            // 
            webcamBtn.Location = new Point(581, 585);
            webcamBtn.Name = "webcamBtn";
            webcamBtn.Size = new Size(145, 54);
            webcamBtn.TabIndex = 12;
            webcamBtn.Text = "WebCam";
            webcamBtn.UseVisualStyleBackColor = true;
            webcamBtn.Click += webcamBtn_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 735);
            Controls.Add(webcamBtn);
            Controls.Add(subtractBtn);
            Controls.Add(backgroundBtn);
            Controls.Add(boxA);
            Controls.Add(sepiaBtn);
            Controls.Add(histogramBtn);
            Controls.Add(invertBtn);
            Controls.Add(greyBtn);
            Controls.Add(copyBtn);
            Controls.Add(saveBtn);
            Controls.Add(loadBtn);
            Controls.Add(boxGreen);
            Controls.Add(boxB);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)boxB).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox boxB;
        private PictureBox boxGreen;
        private Button loadBtn;
        private Button saveBtn;
        private OpenFileDialog openFileDialog1;
        private Button copyBtn;
        private Button greyBtn;
        private Button invertBtn;
        private Button histogramBtn;
        private SaveFileDialog saveFileDialog1;
        private Button sepiaBtn;
        private PictureBox boxA;
        private Button backgroundBtn;
        private Button subtractBtn;
        private OpenFileDialog openFileDialog2;
        private Button webcamBtn;
        private System.Windows.Forms.Timer timer1;
    }
}