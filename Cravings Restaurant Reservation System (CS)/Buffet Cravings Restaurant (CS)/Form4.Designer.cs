namespace WindowsFormsApplication1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Records4 = new System.Windows.Forms.Label();
            this.Reservation4 = new System.Windows.Forms.Label();
            this.Create4 = new System.Windows.Forms.Label();
            this.Home4 = new System.Windows.Forms.Label();
            this.btnRecords4 = new System.Windows.Forms.PictureBox();
            this.btnReservation4 = new System.Windows.Forms.PictureBox();
            this.btnCreate4 = new System.Windows.Forms.PictureBox();
            this.btnHome4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecords4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReservation4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreate4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Records4);
            this.panel2.Controls.Add(this.Reservation4);
            this.panel2.Controls.Add(this.Create4);
            this.panel2.Controls.Add(this.Home4);
            this.panel2.Controls.Add(this.btnRecords4);
            this.panel2.Controls.Add(this.btnReservation4);
            this.panel2.Controls.Add(this.btnCreate4);
            this.panel2.Controls.Add(this.btnHome4);
            this.panel2.Location = new System.Drawing.Point(14, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 63);
            this.panel2.TabIndex = 41;
            // 
            // Records4
            // 
            this.Records4.AutoSize = true;
            this.Records4.BackColor = System.Drawing.Color.SandyBrown;
            this.Records4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Records4.Location = new System.Drawing.Point(502, 23);
            this.Records4.Name = "Records4";
            this.Records4.Size = new System.Drawing.Size(60, 18);
            this.Records4.TabIndex = 7;
            this.Records4.Text = "Records";
            this.Records4.Click += new System.EventHandler(this.Records4_Click);
            // 
            // Reservation4
            // 
            this.Reservation4.AutoSize = true;
            this.Reservation4.BackColor = System.Drawing.Color.Wheat;
            this.Reservation4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservation4.Location = new System.Drawing.Point(348, 23);
            this.Reservation4.Name = "Reservation4";
            this.Reservation4.Size = new System.Drawing.Size(76, 18);
            this.Reservation4.TabIndex = 6;
            this.Reservation4.Text = "Reservation";
            this.Reservation4.Click += new System.EventHandler(this.Reservation4_Click);
            // 
            // Create4
            // 
            this.Create4.AutoSize = true;
            this.Create4.BackColor = System.Drawing.Color.Wheat;
            this.Create4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create4.Location = new System.Drawing.Point(224, 23);
            this.Create4.Name = "Create4";
            this.Create4.Size = new System.Drawing.Size(44, 18);
            this.Create4.TabIndex = 5;
            this.Create4.Text = "Create";
            this.Create4.Click += new System.EventHandler(this.Create4_Click);
            // 
            // Home4
            // 
            this.Home4.AutoSize = true;
            this.Home4.BackColor = System.Drawing.Color.Wheat;
            this.Home4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home4.Location = new System.Drawing.Point(81, 23);
            this.Home4.Name = "Home4";
            this.Home4.Size = new System.Drawing.Size(41, 18);
            this.Home4.TabIndex = 4;
            this.Home4.Text = "Home";
            this.Home4.Click += new System.EventHandler(this.Home4_Click);
            // 
            // btnRecords4
            // 
            this.btnRecords4.BackColor = System.Drawing.Color.SandyBrown;
            this.btnRecords4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRecords4.Location = new System.Drawing.Point(452, 12);
            this.btnRecords4.Name = "btnRecords4";
            this.btnRecords4.Size = new System.Drawing.Size(149, 39);
            this.btnRecords4.TabIndex = 3;
            this.btnRecords4.TabStop = false;
            this.btnRecords4.Click += new System.EventHandler(this.btnRecords4_Click);
            // 
            // btnReservation4
            // 
            this.btnReservation4.BackColor = System.Drawing.Color.Wheat;
            this.btnReservation4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnReservation4.Location = new System.Drawing.Point(316, 12);
            this.btnReservation4.Name = "btnReservation4";
            this.btnReservation4.Size = new System.Drawing.Size(149, 39);
            this.btnReservation4.TabIndex = 2;
            this.btnReservation4.TabStop = false;
            this.btnReservation4.Click += new System.EventHandler(this.btnReservation4_Click);
            // 
            // btnCreate4
            // 
            this.btnCreate4.BackColor = System.Drawing.Color.Wheat;
            this.btnCreate4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCreate4.Location = new System.Drawing.Point(172, 12);
            this.btnCreate4.Name = "btnCreate4";
            this.btnCreate4.Size = new System.Drawing.Size(149, 39);
            this.btnCreate4.TabIndex = 1;
            this.btnCreate4.TabStop = false;
            this.btnCreate4.Click += new System.EventHandler(this.btnCreate4_Click);
            // 
            // btnHome4
            // 
            this.btnHome4.BackColor = System.Drawing.Color.Wheat;
            this.btnHome4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHome4.Location = new System.Drawing.Point(28, 12);
            this.btnHome4.Name = "btnHome4";
            this.btnHome4.Size = new System.Drawing.Size(149, 39);
            this.btnHome4.TabIndex = 0;
            this.btnHome4.TabStop = false;
            this.btnHome4.Click += new System.EventHandler(this.btnHome4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(14, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 437);
            this.panel3.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 334);
            this.dataGridView1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "RECORDS OF RESERVATION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.panel23);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 84);
            this.panel1.TabIndex = 40;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(584, 7);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(17, 24);
            this.label29.TabIndex = 43;
            this.label29.Text = "-";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(606, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 19);
            this.label16.TabIndex = 42;
            this.label16.Text = "X";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // panel23
            // 
            this.panel23.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.icon;
            this.panel23.Location = new System.Drawing.Point(149, 7);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(62, 62);
            this.panel23.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "09987654321";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "123 Eybisi St. Straight Ave. Pasay City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cravings Restaurant";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.images_7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 621);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecords4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReservation4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreate4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Records4;
        private System.Windows.Forms.Label Reservation4;
        private System.Windows.Forms.Label Create4;
        private System.Windows.Forms.Label Home4;
        private System.Windows.Forms.PictureBox btnRecords4;
        private System.Windows.Forms.PictureBox btnReservation4;
        private System.Windows.Forms.PictureBox btnCreate4;
        private System.Windows.Forms.PictureBox btnHome4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label16;

    }
}