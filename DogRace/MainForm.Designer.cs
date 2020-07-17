namespace DogRace
{
    partial class MainForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGurlal = new System.Windows.Forms.Label();
            this.lblSukhpal = new System.Windows.Forms.Label();
            this.lblShivam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRace = new System.Windows.Forms.Button();
            this.udBoxDog = new System.Windows.Forms.NumericUpDown();
            this.udBoxBet = new System.Windows.Forms.NumericUpDown();
            this.btnBet = new System.Windows.Forms.Button();
            this.rbGurlal = new System.Windows.Forms.RadioButton();
            this.rbSukhpal = new System.Windows.Forms.RadioButton();
            this.rbShivam = new System.Windows.Forms.RadioButton();
            this.pbDog2 = new System.Windows.Forms.PictureBox();
            this.pbDog3 = new System.Windows.Forms.PictureBox();
            this.pbDog4 = new System.Windows.Forms.PictureBox();
            this.pbDog1 = new System.Windows.Forms.PictureBox();
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            this.lblBettor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.BackgroundImage = global::DogRace.MainResource.wallpaper;
            this.groupBox1.Controls.Add(this.lblBettor);
            this.groupBox1.Controls.Add(this.lblGurlal);
            this.groupBox1.Controls.Add(this.lblSukhpal);
            this.groupBox1.Controls.Add(this.lblShivam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRace);
            this.groupBox1.Controls.Add(this.udBoxDog);
            this.groupBox1.Controls.Add(this.udBoxBet);
            this.groupBox1.Controls.Add(this.btnBet);
            this.groupBox1.Controls.Add(this.rbGurlal);
            this.groupBox1.Controls.Add(this.rbSukhpal);
            this.groupBox1.Controls.Add(this.rbShivam);
            this.groupBox1.Location = new System.Drawing.Point(-1, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 179);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblGurlal
            // 
            this.lblGurlal.AutoSize = true;
            this.lblGurlal.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGurlal.Location = new System.Drawing.Point(232, 70);
            this.lblGurlal.Name = "lblGurlal";
            this.lblGurlal.Size = new System.Drawing.Size(111, 26);
            this.lblGurlal.TabIndex = 12;
            this.lblGurlal.Text = "Bettor Name";
            // 
            // lblSukhpal
            // 
            this.lblSukhpal.AutoSize = true;
            this.lblSukhpal.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSukhpal.Location = new System.Drawing.Point(232, 35);
            this.lblSukhpal.Name = "lblSukhpal";
            this.lblSukhpal.Size = new System.Drawing.Size(111, 26);
            this.lblSukhpal.TabIndex = 11;
            this.lblSukhpal.Text = "Bettor Name";
            // 
            // lblShivam
            // 
            this.lblShivam.AutoSize = true;
            this.lblShivam.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShivam.Location = new System.Drawing.Point(232, 0);
            this.lblShivam.Name = "lblShivam";
            this.lblShivam.Size = new System.Drawing.Size(111, 26);
            this.lblShivam.TabIndex = 10;
            this.lblShivam.Text = "Bettor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dog  #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(219, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bet  $";
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.SystemColors.Info;
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.Location = new System.Drawing.Point(613, 51);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(176, 98);
            this.btnRace.TabIndex = 6;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // udBoxDog
            // 
            this.udBoxDog.Location = new System.Drawing.Point(290, 146);
            this.udBoxDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udBoxDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udBoxDog.Name = "udBoxDog";
            this.udBoxDog.Size = new System.Drawing.Size(120, 22);
            this.udBoxDog.TabIndex = 5;
            this.udBoxDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udBoxBet
            // 
            this.udBoxBet.Location = new System.Drawing.Point(290, 118);
            this.udBoxBet.Name = "udBoxBet";
            this.udBoxBet.Size = new System.Drawing.Size(120, 22);
            this.udBoxBet.TabIndex = 4;
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.SystemColors.Info;
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.Location = new System.Drawing.Point(473, 118);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(125, 31);
            this.btnBet.TabIndex = 3;
            this.btnBet.Text = "Place Bet!";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // rbGurlal
            // 
            this.rbGurlal.AutoSize = true;
            this.rbGurlal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGurlal.Location = new System.Drawing.Point(40, 105);
            this.rbGurlal.Name = "rbGurlal";
            this.rbGurlal.Size = new System.Drawing.Size(73, 21);
            this.rbGurlal.TabIndex = 2;
            this.rbGurlal.TabStop = true;
            this.rbGurlal.Text = "Gurlal";
            this.rbGurlal.UseVisualStyleBackColor = true;
            // 
            // rbSukhpal
            // 
            this.rbSukhpal.AutoSize = true;
            this.rbSukhpal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSukhpal.Location = new System.Drawing.Point(40, 78);
            this.rbSukhpal.Name = "rbSukhpal";
            this.rbSukhpal.Size = new System.Drawing.Size(87, 21);
            this.rbSukhpal.TabIndex = 1;
            this.rbSukhpal.TabStop = true;
            this.rbSukhpal.Text = "Sukhpal";
            this.rbSukhpal.UseVisualStyleBackColor = true;
            // 
            // rbShivam
            // 
            this.rbShivam.AutoSize = true;
            this.rbShivam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbShivam.Location = new System.Drawing.Point(40, 51);
            this.rbShivam.Name = "rbShivam";
            this.rbShivam.Size = new System.Drawing.Size(81, 21);
            this.rbShivam.TabIndex = 0;
            this.rbShivam.TabStop = true;
            this.rbShivam.Text = "Shivam";
            this.rbShivam.UseVisualStyleBackColor = true;
            // 
            // pbDog2
            // 
            this.pbDog2.Image = global::DogRace.MainResource.Dog2;
            this.pbDog2.Location = new System.Drawing.Point(12, 68);
            this.pbDog2.Name = "pbDog2";
            this.pbDog2.Size = new System.Drawing.Size(100, 50);
            this.pbDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog2.TabIndex = 3;
            this.pbDog2.TabStop = false;
            // 
            // pbDog3
            // 
            this.pbDog3.Image = global::DogRace.MainResource.Dog3;
            this.pbDog3.Location = new System.Drawing.Point(12, 124);
            this.pbDog3.Name = "pbDog3";
            this.pbDog3.Size = new System.Drawing.Size(100, 50);
            this.pbDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog3.TabIndex = 2;
            this.pbDog3.TabStop = false;
            // 
            // pbDog4
            // 
            this.pbDog4.Image = global::DogRace.MainResource.Dog4;
            this.pbDog4.Location = new System.Drawing.Point(12, 180);
            this.pbDog4.Name = "pbDog4";
            this.pbDog4.Size = new System.Drawing.Size(100, 50);
            this.pbDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog4.TabIndex = 1;
            this.pbDog4.TabStop = false;
            // 
            // pbDog1
            // 
            this.pbDog1.Image = global::DogRace.MainResource.Dog1;
            this.pbDog1.Location = new System.Drawing.Point(12, 12);
            this.pbDog1.Name = "pbDog1";
            this.pbDog1.Size = new System.Drawing.Size(100, 50);
            this.pbDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog1.TabIndex = 0;
            this.pbDog1.TabStop = false;
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.BackgroundImage = global::DogRace.MainResource.racetrack;
            this.pbRaceTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRaceTrack.Location = new System.Drawing.Point(-1, -44);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(801, 382);
            this.pbRaceTrack.TabIndex = 6;
            this.pbRaceTrack.TabStop = false;
            // 
            // lblBettor
            // 
            this.lblBettor.AutoSize = true;
            this.lblBettor.BackColor = System.Drawing.SystemColors.Info;
            this.lblBettor.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBettor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBettor.Location = new System.Drawing.Point(45, 9);
            this.lblBettor.Name = "lblBettor";
            this.lblBettor.Size = new System.Drawing.Size(76, 30);
            this.lblBettor.TabIndex = 13;
            this.lblBettor.Text = "Bettors";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbDog2);
            this.Controls.Add(this.pbDog3);
            this.Controls.Add(this.pbDog4);
            this.Controls.Add(this.pbDog1);
            this.Controls.Add(this.pbRaceTrack);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDog1;
        private System.Windows.Forms.PictureBox pbDog4;
        private System.Windows.Forms.PictureBox pbDog3;
        private System.Windows.Forms.PictureBox pbDog2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGurlal;
        private System.Windows.Forms.Label lblSukhpal;
        private System.Windows.Forms.Label lblShivam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.NumericUpDown udBoxDog;
        private System.Windows.Forms.NumericUpDown udBoxBet;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.RadioButton rbGurlal;
        private System.Windows.Forms.RadioButton rbSukhpal;
        private System.Windows.Forms.RadioButton rbShivam;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.Label lblBettor;
    }
}

