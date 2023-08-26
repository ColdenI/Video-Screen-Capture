namespace Video_Screen_Capture
{
    partial class WebcamSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebcamSettingsForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox_webcmDev = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_usingWebcam = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_posY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_posX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_sizeY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_sizeX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_posY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_posX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sizeX)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(489, 290);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // comboBox_webcmDev
            // 
            this.comboBox_webcmDev.FormattingEnabled = true;
            this.comboBox_webcmDev.Location = new System.Drawing.Point(181, 7);
            this.comboBox_webcmDev.Name = "comboBox_webcmDev";
            this.comboBox_webcmDev.Size = new System.Drawing.Size(187, 24);
            this.comboBox_webcmDev.TabIndex = 1;
            this.comboBox_webcmDev.SelectedIndexChanged += new System.EventHandler(this.comboBox_webcmDev_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Устройство веб-камера";
            // 
            // checkBox_usingWebcam
            // 
            this.checkBox_usingWebcam.AutoSize = true;
            this.checkBox_usingWebcam.Location = new System.Drawing.Point(374, 11);
            this.checkBox_usingWebcam.Name = "checkBox_usingWebcam";
            this.checkBox_usingWebcam.Size = new System.Drawing.Size(102, 20);
            this.checkBox_usingWebcam.TabIndex = 20;
            this.checkBox_usingWebcam.Text = "Вебкамера";
            this.checkBox_usingWebcam.UseVisualStyleBackColor = true;
            this.checkBox_usingWebcam.CheckedChanged += new System.EventHandler(this.checkBox_usingWebcam_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_posY);
            this.groupBox1.Controls.Add(this.numericUpDown_posX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 85);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Позиция";
            // 
            // numericUpDown_posY
            // 
            this.numericUpDown_posY.Location = new System.Drawing.Point(39, 53);
            this.numericUpDown_posY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_posY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_posY.Name = "numericUpDown_posY";
            this.numericUpDown_posY.Size = new System.Drawing.Size(173, 22);
            this.numericUpDown_posY.TabIndex = 3;
            this.numericUpDown_posY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_posY.ValueChanged += new System.EventHandler(this.numericUpDown_posY_ValueChanged);
            // 
            // numericUpDown_posX
            // 
            this.numericUpDown_posX.Location = new System.Drawing.Point(39, 22);
            this.numericUpDown_posX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_posX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_posX.Name = "numericUpDown_posX";
            this.numericUpDown_posX.Size = new System.Drawing.Size(173, 22);
            this.numericUpDown_posX.TabIndex = 2;
            this.numericUpDown_posX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_posX.ValueChanged += new System.EventHandler(this.numericUpDown_posX_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown_sizeY);
            this.groupBox2.Controls.Add(this.numericUpDown_sizeX);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(254, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 85);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размер";
            // 
            // numericUpDown_sizeY
            // 
            this.numericUpDown_sizeY.Location = new System.Drawing.Point(39, 53);
            this.numericUpDown_sizeY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_sizeY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_sizeY.Name = "numericUpDown_sizeY";
            this.numericUpDown_sizeY.Size = new System.Drawing.Size(173, 22);
            this.numericUpDown_sizeY.TabIndex = 3;
            this.numericUpDown_sizeY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_sizeY.ValueChanged += new System.EventHandler(this.numericUpDown_sizeY_ValueChanged);
            // 
            // numericUpDown_sizeX
            // 
            this.numericUpDown_sizeX.Location = new System.Drawing.Point(39, 22);
            this.numericUpDown_sizeX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_sizeX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_sizeX.Name = "numericUpDown_sizeX";
            this.numericUpDown_sizeX.Size = new System.Drawing.Size(173, 22);
            this.numericUpDown_sizeX.TabIndex = 2;
            this.numericUpDown_sizeX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_sizeX.ValueChanged += new System.EventHandler(this.numericUpDown_sizeX_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "X:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.comboBox_webcmDev);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.checkBox_usingWebcam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 132);
            this.panel1.TabIndex = 23;
            // 
            // WebcamSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 422);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WebcamSettingsForm";
            this.Text = "VSC - Настройки веб-камеры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebcamSettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.WebcamSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_posY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_posX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sizeX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboBox_webcmDev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_usingWebcam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_posX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown_sizeY;
        private System.Windows.Forms.NumericUpDown numericUpDown_sizeX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown_posY;
    }
}