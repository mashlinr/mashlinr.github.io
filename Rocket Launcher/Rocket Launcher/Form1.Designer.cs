namespace Rocket_Launcher
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pBoxRocket = new System.Windows.Forms.PictureBox();
            this.lblRocketTitle = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.tmrLaunch = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRocket)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Yes",
            "No",
            "Maybe"});
            this.listBox1.Location = new System.Drawing.Point(76, 198);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(76, 81);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(200, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Would you like to launch the rocket?";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // pBoxRocket
            // 
            this.pBoxRocket.ErrorImage = null;
            this.pBoxRocket.Image = ((System.Drawing.Image)(resources.GetObject("pBoxRocket.Image")));
            this.pBoxRocket.InitialImage = ((System.Drawing.Image)(resources.GetObject("pBoxRocket.InitialImage")));
            this.pBoxRocket.Location = new System.Drawing.Point(369, 355);
            this.pBoxRocket.Margin = new System.Windows.Forms.Padding(1);
            this.pBoxRocket.Name = "pBoxRocket";
            this.pBoxRocket.Size = new System.Drawing.Size(72, 85);
            this.pBoxRocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxRocket.TabIndex = 11;
            this.pBoxRocket.TabStop = false;
            this.pBoxRocket.Click += new System.EventHandler(this.pBoxRocket_Click);
            // 
            // lblRocketTitle
            // 
            this.lblRocketTitle.AutoSize = true;
            this.lblRocketTitle.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRocketTitle.Location = new System.Drawing.Point(277, 11);
            this.lblRocketTitle.Name = "lblRocketTitle";
            this.lblRocketTitle.Size = new System.Drawing.Size(269, 38);
            this.lblRocketTitle.TabIndex = 10;
            this.lblRocketTitle.Text = "Rocket Launcher";
            this.lblRocketTitle.Click += new System.EventHandler(this.lblRocketTitle_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(613, 223);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 70);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(613, 106);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLaunch.Size = new System.Drawing.Size(111, 74);
            this.btnLaunch.TabIndex = 8;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // tmrLaunch
            // 
            this.tmrLaunch.Tick += new System.EventHandler(this.tmrLaunch_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.pBoxRocket);
            this.Controls.Add(this.lblRocketTitle);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnLaunch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRocket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pBoxRocket;
        private System.Windows.Forms.Label lblRocketTitle;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Timer tmrLaunch;
    }
}

