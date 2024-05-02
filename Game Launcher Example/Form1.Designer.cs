namespace Game_Launcher_Example
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
            totalProgressBar = new ProgressBar();
            button1 = new Button();
            barProgressFile = new ProgressBar();
            labelProgressFile = new Label();
            labelFilename = new Label();
            labelProgressTotal = new Label();
            SuspendLayout();
            // 
            // totalProgressBar
            // 
            totalProgressBar.BackColor = SystemColors.Control;
            totalProgressBar.Location = new Point(14, 515);
            totalProgressBar.Margin = new Padding(3, 4, 3, 4);
            totalProgressBar.Name = "totalProgressBar";
            totalProgressBar.Size = new Size(621, 31);
            totalProgressBar.TabIndex = 0;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(738, 515);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(162, 69);
            button1.TabIndex = 1;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // barProgressFile
            // 
            barProgressFile.Location = new Point(14, 553);
            barProgressFile.Margin = new Padding(3, 4, 3, 4);
            barProgressFile.Name = "barProgressFile";
            barProgressFile.Size = new Size(621, 31);
            barProgressFile.TabIndex = 2;
            // 
            // labelProgressFile
            // 
            labelProgressFile.BackColor = Color.Transparent;
            labelProgressFile.ForeColor = Color.White;
            labelProgressFile.Location = new Point(641, 553);
            labelProgressFile.Name = "labelProgressFile";
            labelProgressFile.Size = new Size(90, 31);
            labelProgressFile.TabIndex = 3;
            labelProgressFile.Text = "0%";
            labelProgressFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelFilename
            // 
            labelFilename.BackColor = Color.Transparent;
            labelFilename.ForeColor = Color.White;
            labelFilename.Location = new Point(14, 480);
            labelFilename.Name = "labelFilename";
            labelFilename.Size = new Size(621, 31);
            labelFilename.TabIndex = 4;
            labelFilename.Text = "n/a";
            labelFilename.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProgressTotal
            // 
            labelProgressTotal.BackColor = Color.Transparent;
            labelProgressTotal.ForeColor = Color.White;
            labelProgressTotal.Location = new Point(641, 515);
            labelProgressTotal.Name = "labelProgressTotal";
            labelProgressTotal.Size = new Size(90, 31);
            labelProgressTotal.TabIndex = 5;
            labelProgressTotal.Text = "n/a";
            labelProgressTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Linus_Selfie_Wallpaper_1080_T_D_png_981a6c9517151c812ba4e160592840d4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(labelProgressTotal);
            Controls.Add(labelFilename);
            Controls.Add(labelProgressFile);
            Controls.Add(barProgressFile);
            Controls.Add(button1);
            Controls.Add(totalProgressBar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Game Launcher";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar totalProgressBar;
        private Button button1;
        private ProgressBar barProgressFile;
        private Label labelProgressFile;
        private Label labelFilename;
        private Label labelProgressTotal;
    }
}
