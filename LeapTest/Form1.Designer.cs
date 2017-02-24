namespace LeapTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPitch = new System.Windows.Forms.TextBox();
            this.txtYaw = new System.Windows.Forms.TextBox();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.txtGrab = new System.Windows.Forms.TextBox();
            this.txtDuim = new System.Windows.Forms.TextBox();
            this.txtWijsvinger = new System.Windows.Forms.TextBox();
            this.txtMiddelvinger = new System.Windows.Forms.TextBox();
            this.txtRingvinger = new System.Windows.Forms.TextBox();
            this.txtPink = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTekst = new System.Windows.Forms.Label();
            this.txtTekst = new System.Windows.Forms.TextBox();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.btnBeginner = new System.Windows.Forms.Button();
            this.btnExpert = new System.Windows.Forms.Button();
            this.lblOefenLetter = new System.Windows.Forms.Label();
            this.lblScoreTekst = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrUitlezen = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblInfoTimer = new System.Windows.Forms.Label();
            this.pctJuist = new System.Windows.Forms.PictureBox();
            this.pctHand = new System.Windows.Forms.PictureBox();
            this.pctGebaren = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrJuist = new System.Windows.Forms.Timer(this.components);
            this.lblBeginnerVoorbeeld = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctJuist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGebaren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(172, 166);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pitch:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yaw:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Roll:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Grab:";
            this.label4.Visible = false;
            // 
            // txtPitch
            // 
            this.txtPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPitch.Location = new System.Drawing.Point(279, 25);
            this.txtPitch.Name = "txtPitch";
            this.txtPitch.Size = new System.Drawing.Size(100, 27);
            this.txtPitch.TabIndex = 5;
            this.txtPitch.Visible = false;
            // 
            // txtYaw
            // 
            this.txtYaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYaw.Location = new System.Drawing.Point(279, 66);
            this.txtYaw.Name = "txtYaw";
            this.txtYaw.Size = new System.Drawing.Size(100, 27);
            this.txtYaw.TabIndex = 6;
            this.txtYaw.Visible = false;
            // 
            // txtRoll
            // 
            this.txtRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoll.Location = new System.Drawing.Point(279, 110);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(100, 27);
            this.txtRoll.TabIndex = 7;
            this.txtRoll.Visible = false;
            // 
            // txtGrab
            // 
            this.txtGrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrab.Location = new System.Drawing.Point(279, 152);
            this.txtGrab.Name = "txtGrab";
            this.txtGrab.Size = new System.Drawing.Size(100, 27);
            this.txtGrab.TabIndex = 8;
            this.txtGrab.Visible = false;
            // 
            // txtDuim
            // 
            this.txtDuim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuim.Location = new System.Drawing.Point(150, 309);
            this.txtDuim.Name = "txtDuim";
            this.txtDuim.Size = new System.Drawing.Size(229, 27);
            this.txtDuim.TabIndex = 9;
            this.txtDuim.Visible = false;
            // 
            // txtWijsvinger
            // 
            this.txtWijsvinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWijsvinger.Location = new System.Drawing.Point(150, 350);
            this.txtWijsvinger.Name = "txtWijsvinger";
            this.txtWijsvinger.Size = new System.Drawing.Size(229, 27);
            this.txtWijsvinger.TabIndex = 10;
            this.txtWijsvinger.Visible = false;
            // 
            // txtMiddelvinger
            // 
            this.txtMiddelvinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddelvinger.Location = new System.Drawing.Point(150, 401);
            this.txtMiddelvinger.Name = "txtMiddelvinger";
            this.txtMiddelvinger.Size = new System.Drawing.Size(229, 27);
            this.txtMiddelvinger.TabIndex = 11;
            this.txtMiddelvinger.Visible = false;
            // 
            // txtRingvinger
            // 
            this.txtRingvinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRingvinger.Location = new System.Drawing.Point(150, 457);
            this.txtRingvinger.Name = "txtRingvinger";
            this.txtRingvinger.Size = new System.Drawing.Size(229, 27);
            this.txtRingvinger.TabIndex = 12;
            this.txtRingvinger.Visible = false;
            // 
            // txtPink
            // 
            this.txtPink.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPink.Location = new System.Drawing.Point(150, 505);
            this.txtPink.Name = "txtPink";
            this.txtPink.Size = new System.Drawing.Size(229, 27);
            this.txtPink.TabIndex = 13;
            this.txtPink.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Afstanden handpalm naar tip";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Duim:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Pink:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ringvinger:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Middelvinger";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 22);
            this.label10.TabIndex = 21;
            this.label10.Text = "Wijsvinger:";
            this.label10.Visible = false;
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTekst.Location = new System.Drawing.Point(750, 366);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(0, 181);
            this.lblTekst.TabIndex = 23;
            this.lblTekst.Visible = false;
            // 
            // txtTekst
            // 
            this.txtTekst.Location = new System.Drawing.Point(394, 25);
            this.txtTekst.Name = "txtTekst";
            this.txtTekst.Size = new System.Drawing.Size(699, 20);
            this.txtTekst.TabIndex = 24;
            this.txtTekst.Visible = false;
            // 
            // txtResultaat
            // 
            this.txtResultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultaat.Location = new System.Drawing.Point(305, 191);
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.ReadOnly = true;
            this.txtResultaat.Size = new System.Drawing.Size(734, 30);
            this.txtResultaat.TabIndex = 25;
            this.txtResultaat.Visible = false;
            this.txtResultaat.TextChanged += new System.EventHandler(this.txtResultaat_TextChanged);
            // 
            // btnBeginner
            // 
            this.btnBeginner.Location = new System.Drawing.Point(13, 230);
            this.btnBeginner.Name = "btnBeginner";
            this.btnBeginner.Size = new System.Drawing.Size(115, 33);
            this.btnBeginner.TabIndex = 28;
            this.btnBeginner.Text = "Beginner";
            this.btnBeginner.UseVisualStyleBackColor = true;
            this.btnBeginner.Visible = false;
            this.btnBeginner.Click += new System.EventHandler(this.btnBeginner_Click);
            // 
            // btnExpert
            // 
            this.btnExpert.Location = new System.Drawing.Point(184, 230);
            this.btnExpert.Name = "btnExpert";
            this.btnExpert.Size = new System.Drawing.Size(115, 33);
            this.btnExpert.TabIndex = 29;
            this.btnExpert.Text = "Expert";
            this.btnExpert.UseVisualStyleBackColor = true;
            this.btnExpert.Visible = false;
            this.btnExpert.Click += new System.EventHandler(this.btnExpert_Click);
            // 
            // lblOefenLetter
            // 
            this.lblOefenLetter.AutoSize = true;
            this.lblOefenLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOefenLetter.Location = new System.Drawing.Point(644, 80);
            this.lblOefenLetter.Name = "lblOefenLetter";
            this.lblOefenLetter.Size = new System.Drawing.Size(0, 76);
            this.lblOefenLetter.TabIndex = 30;
            // 
            // lblScoreTekst
            // 
            this.lblScoreTekst.AutoSize = true;
            this.lblScoreTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTekst.Location = new System.Drawing.Point(776, 342);
            this.lblScoreTekst.Name = "lblScoreTekst";
            this.lblScoreTekst.Size = new System.Drawing.Size(70, 25);
            this.lblScoreTekst.TabIndex = 31;
            this.lblScoreTekst.Text = "Score:";
            this.lblScoreTekst.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(852, 337);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(36, 39);
            this.lblScore.TabIndex = 32;
            this.lblScore.Text = "0";
            this.lblScore.Visible = false;
            // 
            // tmrUitlezen
            // 
            this.tmrUitlezen.Interval = 1000;
            this.tmrUitlezen.Tick += new System.EventHandler(this.tmrUitlezen_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(631, 98);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 39);
            this.lblTimer.TabIndex = 35;
            // 
            // lblInfoTimer
            // 
            this.lblInfoTimer.AutoSize = true;
            this.lblInfoTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTimer.Location = new System.Drawing.Point(389, 55);
            this.lblInfoTimer.Name = "lblInfoTimer";
            this.lblInfoTimer.Size = new System.Drawing.Size(597, 25);
            this.lblInfoTimer.TabIndex = 34;
            this.lblInfoTimer.Text = "Hand uitlezen, Gelieve uw hand gespreid te houden (zie afbeelding)";
            // 
            // pctJuist
            // 
            this.pctJuist.Image = global::LeapTest.Properties.Resources.juist;
            this.pctJuist.Location = new System.Drawing.Point(855, 98);
            this.pctJuist.Name = "pctJuist";
            this.pctJuist.Size = new System.Drawing.Size(184, 184);
            this.pctJuist.TabIndex = 36;
            this.pctJuist.TabStop = false;
            this.pctJuist.Visible = false;
            // 
            // pctHand
            // 
            this.pctHand.Image = global::LeapTest.Properties.Resources.hand;
            this.pctHand.Location = new System.Drawing.Point(455, 227);
            this.pctHand.Name = "pctHand";
            this.pctHand.Size = new System.Drawing.Size(391, 400);
            this.pctHand.TabIndex = 33;
            this.pctHand.TabStop = false;
            // 
            // pctGebaren
            // 
            this.pctGebaren.Location = new System.Drawing.Point(604, 288);
            this.pctGebaren.MaximumSize = new System.Drawing.Size(140, 140);
            this.pctGebaren.Name = "pctGebaren";
            this.pctGebaren.Size = new System.Drawing.Size(140, 140);
            this.pctGebaren.TabIndex = 27;
            this.pctGebaren.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 198);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // tmrJuist
            // 
            this.tmrJuist.Interval = 1000;
            this.tmrJuist.Tick += new System.EventHandler(this.tmrJuist_Tick);
            // 
            // lblBeginnerVoorbeeld
            // 
            this.lblBeginnerVoorbeeld.AutoSize = true;
            this.lblBeginnerVoorbeeld.Location = new System.Drawing.Point(603, 269);
            this.lblBeginnerVoorbeeld.Name = "lblBeginnerVoorbeeld";
            this.lblBeginnerVoorbeeld.Size = new System.Drawing.Size(58, 13);
            this.lblBeginnerVoorbeeld.TabIndex = 37;
            this.lblBeginnerVoorbeeld.Text = "Voorbeeld:";
            this.lblBeginnerVoorbeeld.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 619);
            this.Controls.Add(this.lblBeginnerVoorbeeld);
            this.Controls.Add(this.pctJuist);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblInfoTimer);
            this.Controls.Add(this.pctHand);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreTekst);
            this.Controls.Add(this.lblOefenLetter);
            this.Controls.Add(this.btnExpert);
            this.Controls.Add(this.btnBeginner);
            this.Controls.Add(this.pctGebaren);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.txtTekst);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPink);
            this.Controls.Add(this.txtRingvinger);
            this.Controls.Add(this.txtMiddelvinger);
            this.Controls.Add(this.txtWijsvinger);
            this.Controls.Add(this.txtDuim);
            this.Controls.Add(this.txtGrab);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.txtYaw);
            this.Controls.Add(this.txtPitch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mila Speaks";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctJuist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGebaren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPitch;
        private System.Windows.Forms.TextBox txtYaw;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.TextBox txtGrab;
        private System.Windows.Forms.TextBox txtDuim;
        private System.Windows.Forms.TextBox txtWijsvinger;
        private System.Windows.Forms.TextBox txtMiddelvinger;
        private System.Windows.Forms.TextBox txtRingvinger;
        private System.Windows.Forms.TextBox txtPink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.TextBox txtTekst;
        private System.Windows.Forms.TextBox txtResultaat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctGebaren;
        private System.Windows.Forms.Button btnBeginner;
        private System.Windows.Forms.Button btnExpert;
        private System.Windows.Forms.Label lblOefenLetter;
        private System.Windows.Forms.Label lblScoreTekst;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrUitlezen;
        private System.Windows.Forms.PictureBox pctHand;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblInfoTimer;
        private System.Windows.Forms.PictureBox pctJuist;
        private System.Windows.Forms.Timer tmrJuist;
        private System.Windows.Forms.Label lblBeginnerVoorbeeld;
    }
}

