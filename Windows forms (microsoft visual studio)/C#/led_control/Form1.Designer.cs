namespace led_control
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
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.btnBlink = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btnOn
            // 
            this.btnOn.BackColor = System.Drawing.Color.LightGray;
            this.btnOn.Location = new System.Drawing.Point(12, 26);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(167, 80);
            this.btnOn.TabIndex = 0;
            this.btnOn.Text = "Turn On";
            this.btnOn.UseVisualStyleBackColor = false;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.LightGray;
            this.btnOff.Location = new System.Drawing.Point(212, 26);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(167, 80);
            this.btnOff.TabIndex = 0;
            this.btnOff.Text = "Turn Off";
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of blinks :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Blinking speed (ms) :";
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCount.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCount.Location = new System.Drawing.Point(232, 133);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(347, 41);
            this.txtCount.TabIndex = 2;
            // 
            // txtSpeed
            // 
            this.txtSpeed.BackColor = System.Drawing.Color.White;
            this.txtSpeed.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSpeed.Location = new System.Drawing.Point(232, 195);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(347, 41);
            this.txtSpeed.TabIndex = 2;
            // 
            // btnBlink
            // 
            this.btnBlink.BackColor = System.Drawing.Color.LightGray;
            this.btnBlink.Location = new System.Drawing.Point(412, 26);
            this.btnBlink.Name = "btnBlink";
            this.btnBlink.Size = new System.Drawing.Size(167, 80);
            this.btnBlink.TabIndex = 0;
            this.btnBlink.Text = "Blink";
            this.btnBlink.UseVisualStyleBackColor = false;
            this.btnBlink.Click += new System.EventHandler(this.btnBlink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(591, 266);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBlink);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LED Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Button btnBlink;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

