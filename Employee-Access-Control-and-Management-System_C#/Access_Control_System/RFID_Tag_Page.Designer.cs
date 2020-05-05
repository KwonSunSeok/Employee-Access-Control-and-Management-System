namespace Access_Control_System
{
    partial class RFID_Tag_Page
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.avr_SerialPort_Re = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\kccistc\\Desktop\\Access_Control_System\\Access_Control_System_Image\\RFID_T" +
    "ag_Image.png";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // avr_SerialPort_Re
            // 
            this.avr_SerialPort_Re.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.avr_SerialPort_Re_DataReceived);
            // 
            // RFID_Tag_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 536);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RFID_Tag_Page";
            this.Text = "RFID_Tag_Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RFID_Tag_Page_FormClosed);
            this.Load += new System.EventHandler(this.RFID_Tag_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort avr_SerialPort_Re;
    }
}