namespace Divis_edhouse
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.description = new System.Windows.Forms.Label();
            this.rotationButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.helpDescription1 = new System.Windows.Forms.Label();
            this.helpActPictureID = new System.Windows.Forms.Label();
            this.helpDescription3 = new System.Windows.Forms.Label();
            this.helpMap1 = new System.Windows.Forms.Label();
            this.helpMap2 = new System.Windows.Forms.Label();
            this.helpMap3 = new System.Windows.Forms.Label();
            this.helpCountOfRotation = new System.Windows.Forms.Label();
            this.helpDescription2 = new System.Windows.Forms.Label();
            this.helpRotation3 = new System.Windows.Forms.Label();
            this.helpRotation2 = new System.Windows.Forms.Label();
            this.helpRotation1 = new System.Windows.Forms.Label();
            this.leftArrowButton = new System.Windows.Forms.Button();
            this.downArrowButton = new System.Windows.Forms.Button();
            this.rightArrowButton = new System.Windows.Forms.Button();
            this.upArrowButton = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.description.Location = new System.Drawing.Point(960, 20);
            this.description.MinimumSize = new System.Drawing.Size(980, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(980, 46);
            this.description.TabIndex = 9;
            this.description.Text = "Popis";
            // 
            // rotationButton
            // 
            this.rotationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.rotationButton.Location = new System.Drawing.Point(968, 134);
            this.rotationButton.Name = "rotationButton";
            this.rotationButton.Size = new System.Drawing.Size(276, 70);
            this.rotationButton.TabIndex = 10;
            this.rotationButton.Text = "Rotovat";
            this.rotationButton.UseVisualStyleBackColor = true;
            this.rotationButton.Click += new System.EventHandler(this.rotationButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.helpButton.Location = new System.Drawing.Point(979, 469);
            this.helpButton.MinimumSize = new System.Drawing.Size(120, 0);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(276, 120);
            this.helpButton.TabIndex = 15;
            this.helpButton.Text = "Zobrazit nápovědu";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // helpDescription1
            // 
            this.helpDescription1.AutoSize = true;
            this.helpDescription1.Cursor = System.Windows.Forms.Cursors.Default;
            this.helpDescription1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.helpDescription1.Location = new System.Drawing.Point(989, 623);
            this.helpDescription1.Name = "helpDescription1";
            this.helpDescription1.Size = new System.Drawing.Size(434, 36);
            this.helpDescription1.TabIndex = 16;
            this.helpDescription1.Text = "Zde je číslo aktuálního obrázku:";
            // 
            // helpActPictureID
            // 
            this.helpActPictureID.AutoSize = true;
            this.helpActPictureID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.helpActPictureID.ForeColor = System.Drawing.Color.Red;
            this.helpActPictureID.Location = new System.Drawing.Point(1429, 604);
            this.helpActPictureID.Name = "helpActPictureID";
            this.helpActPictureID.Size = new System.Drawing.Size(51, 55);
            this.helpActPictureID.TabIndex = 17;
            this.helpActPictureID.Text = "0";
            // 
            // helpDescription3
            // 
            this.helpDescription3.AutoSize = true;
            this.helpDescription3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.helpDescription3.Location = new System.Drawing.Point(989, 749);
            this.helpDescription3.Name = "helpDescription3";
            this.helpDescription3.Size = new System.Drawing.Size(938, 36);
            this.helpDescription3.TabIndex = 18;
            this.helpDescription3.Text = "a zde je správné umístění jednotlivých obrázků a správný počet rotací:";
            // 
            // helpMap1
            // 
            this.helpMap1.AutoSize = true;
            this.helpMap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.helpMap1.Location = new System.Drawing.Point(989, 817);
            this.helpMap1.Name = "helpMap1";
            this.helpMap1.Size = new System.Drawing.Size(82, 36);
            this.helpMap1.TabIndex = 19;
            this.helpMap1.Text = "2 5 8";
            // 
            // helpMap2
            // 
            this.helpMap2.AutoSize = true;
            this.helpMap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.helpMap2.Location = new System.Drawing.Point(989, 853);
            this.helpMap2.Name = "helpMap2";
            this.helpMap2.Size = new System.Drawing.Size(82, 36);
            this.helpMap2.TabIndex = 20;
            this.helpMap2.Text = "6 3 7";
            // 
            // helpMap3
            // 
            this.helpMap3.AutoSize = true;
            this.helpMap3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.helpMap3.Location = new System.Drawing.Point(989, 889);
            this.helpMap3.Name = "helpMap3";
            this.helpMap3.Size = new System.Drawing.Size(82, 36);
            this.helpMap3.TabIndex = 21;
            this.helpMap3.Text = "9 4 1";
            // 
            // helpCountOfRotation
            // 
            this.helpCountOfRotation.AutoSize = true;
            this.helpCountOfRotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.helpCountOfRotation.ForeColor = System.Drawing.Color.Red;
            this.helpCountOfRotation.Location = new System.Drawing.Point(1429, 668);
            this.helpCountOfRotation.Name = "helpCountOfRotation";
            this.helpCountOfRotation.Size = new System.Drawing.Size(51, 55);
            this.helpCountOfRotation.TabIndex = 22;
            this.helpCountOfRotation.Text = "0";
            // 
            // helpDescription2
            // 
            this.helpDescription2.AutoSize = true;
            this.helpDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.helpDescription2.Location = new System.Drawing.Point(989, 687);
            this.helpDescription2.Name = "helpDescription2";
            this.helpDescription2.Size = new System.Drawing.Size(349, 36);
            this.helpDescription2.TabIndex = 23;
            this.helpDescription2.Text = "počet provedených rotací";
            // 
            // helpRotation3
            // 
            this.helpRotation3.AutoSize = true;
            this.helpRotation3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.helpRotation3.Location = new System.Drawing.Point(1508, 889);
            this.helpRotation3.Name = "helpRotation3";
            this.helpRotation3.Size = new System.Drawing.Size(82, 36);
            this.helpRotation3.TabIndex = 26;
            this.helpRotation3.Text = "3 1 1";
            // 
            // helpRotation2
            // 
            this.helpRotation2.AutoSize = true;
            this.helpRotation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.helpRotation2.Location = new System.Drawing.Point(1508, 853);
            this.helpRotation2.Name = "helpRotation2";
            this.helpRotation2.Size = new System.Drawing.Size(82, 36);
            this.helpRotation2.TabIndex = 25;
            this.helpRotation2.Text = "0 2 1";
            // 
            // helpRotation1
            // 
            this.helpRotation1.AutoSize = true;
            this.helpRotation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.helpRotation1.Location = new System.Drawing.Point(1508, 817);
            this.helpRotation1.Name = "helpRotation1";
            this.helpRotation1.Size = new System.Drawing.Size(82, 36);
            this.helpRotation1.TabIndex = 24;
            this.helpRotation1.Text = "2 2 0";
            // 
            // leftArrowButton
            // 
            this.leftArrowButton.Image = ((System.Drawing.Image)(resources.GetObject("leftArrowButton.Image")));
            this.leftArrowButton.Location = new System.Drawing.Point(968, 318);
            this.leftArrowButton.Name = "leftArrowButton";
            this.leftArrowButton.Size = new System.Drawing.Size(85, 85);
            this.leftArrowButton.TabIndex = 14;
            this.leftArrowButton.UseVisualStyleBackColor = true;
            this.leftArrowButton.Click += new System.EventHandler(this.leftArrowButton_Click);
            // 
            // downArrowButton
            // 
            this.downArrowButton.Image = ((System.Drawing.Image)(resources.GetObject("downArrowButton.Image")));
            this.downArrowButton.Location = new System.Drawing.Point(1059, 318);
            this.downArrowButton.Name = "downArrowButton";
            this.downArrowButton.Size = new System.Drawing.Size(85, 85);
            this.downArrowButton.TabIndex = 13;
            this.downArrowButton.UseVisualStyleBackColor = true;
            this.downArrowButton.Click += new System.EventHandler(this.downArrowButton_Click);
            // 
            // rightArrowButton
            // 
            this.rightArrowButton.Image = ((System.Drawing.Image)(resources.GetObject("rightArrowButton.Image")));
            this.rightArrowButton.Location = new System.Drawing.Point(1150, 318);
            this.rightArrowButton.Name = "rightArrowButton";
            this.rightArrowButton.Size = new System.Drawing.Size(85, 85);
            this.rightArrowButton.TabIndex = 12;
            this.rightArrowButton.UseVisualStyleBackColor = true;
            this.rightArrowButton.Click += new System.EventHandler(this.rightArrowButton_Click);
            // 
            // upArrowButton
            // 
            this.upArrowButton.Image = ((System.Drawing.Image)(resources.GetObject("upArrowButton.Image")));
            this.upArrowButton.Location = new System.Drawing.Point(1059, 227);
            this.upArrowButton.Name = "upArrowButton";
            this.upArrowButton.Size = new System.Drawing.Size(85, 85);
            this.upArrowButton.TabIndex = 11;
            this.upArrowButton.UseVisualStyleBackColor = true;
            this.upArrowButton.Click += new System.EventHandler(this.upArrowButton_click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Divis_edhouse.Properties.Resources._9;
            this.pictureBox9.Location = new System.Drawing.Point(606, 616);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(298, 298);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Divis_edhouse.Properties.Resources._8;
            this.pictureBox8.Location = new System.Drawing.Point(308, 616);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(298, 298);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Divis_edhouse.Properties.Resources._7;
            this.pictureBox7.Location = new System.Drawing.Point(10, 616);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(298, 298);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Divis_edhouse.Properties.Resources._6;
            this.pictureBox6.Location = new System.Drawing.Point(606, 318);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(298, 298);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Divis_edhouse.Properties.Resources._5;
            this.pictureBox5.Location = new System.Drawing.Point(308, 318);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(298, 298);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Divis_edhouse.Properties.Resources._4;
            this.pictureBox4.Location = new System.Drawing.Point(10, 318);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(298, 298);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Divis_edhouse.Properties.Resources._3;
            this.pictureBox3.Location = new System.Drawing.Point(606, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(298, 298);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Divis_edhouse.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(308, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 298);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Divis_edhouse.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1978, 1144);
            this.Controls.Add(this.helpRotation3);
            this.Controls.Add(this.helpRotation2);
            this.Controls.Add(this.helpRotation1);
            this.Controls.Add(this.helpDescription2);
            this.Controls.Add(this.helpCountOfRotation);
            this.Controls.Add(this.helpMap3);
            this.Controls.Add(this.helpMap2);
            this.Controls.Add(this.helpMap1);
            this.Controls.Add(this.helpDescription3);
            this.Controls.Add(this.helpActPictureID);
            this.Controls.Add(this.helpDescription1);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.leftArrowButton);
            this.Controls.Add(this.downArrowButton);
            this.Controls.Add(this.rightArrowButton);
            this.Controls.Add(this.upArrowButton);
            this.Controls.Add(this.rotationButton);
            this.Controls.Add(this.description);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Hlavolam";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button rotationButton;
        private System.Windows.Forms.Button upArrowButton;
        private System.Windows.Forms.Button rightArrowButton;
        private System.Windows.Forms.Button downArrowButton;
        private System.Windows.Forms.Button leftArrowButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label helpDescription1;
        private System.Windows.Forms.Label helpActPictureID;
        private System.Windows.Forms.Label helpDescription3;
        private System.Windows.Forms.Label helpMap1;
        private System.Windows.Forms.Label helpMap2;
        private System.Windows.Forms.Label helpMap3;
        private System.Windows.Forms.Label helpCountOfRotation;
        private System.Windows.Forms.Label helpDescription2;
        private System.Windows.Forms.Label helpRotation3;
        private System.Windows.Forms.Label helpRotation2;
        private System.Windows.Forms.Label helpRotation1;
    }
}

