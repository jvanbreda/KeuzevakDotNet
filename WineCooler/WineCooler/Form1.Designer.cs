namespace WineCooler {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label_curr_temp = new System.Windows.Forms.Label();
            this.button_open_door = new System.Windows.Forms.Button();
            this.button_close_door = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_new_default_temp = new System.Windows.Forms.TextBox();
            this.label_default_temp = new System.Windows.Forms.Label();
            this.button_change_default_temp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.current_temp = new System.Windows.Forms.Label();
            this.default_temp = new System.Windows.Forms.Label();
            this.wineCoolerImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wineCoolerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label_curr_temp
            // 
            this.label_curr_temp.AutoSize = true;
            this.label_curr_temp.Location = new System.Drawing.Point(12, 33);
            this.label_curr_temp.Name = "label_curr_temp";
            this.label_curr_temp.Size = new System.Drawing.Size(103, 13);
            this.label_curr_temp.TabIndex = 0;
            this.label_curr_temp.Text = "Current temperature:";
            // 
            // button_open_door
            // 
            this.button_open_door.Location = new System.Drawing.Point(329, 33);
            this.button_open_door.Name = "button_open_door";
            this.button_open_door.Size = new System.Drawing.Size(75, 23);
            this.button_open_door.TabIndex = 1;
            this.button_open_door.Text = "Open door";
            this.button_open_door.UseVisualStyleBackColor = true;
            this.button_open_door.Click += new System.EventHandler(this.openDoor);
            // 
            // button_close_door
            // 
            this.button_close_door.Location = new System.Drawing.Point(329, 62);
            this.button_close_door.Name = "button_close_door";
            this.button_close_door.Size = new System.Drawing.Size(75, 23);
            this.button_close_door.TabIndex = 2;
            this.button_close_door.Text = "Close door";
            this.button_close_door.UseVisualStyleBackColor = true;
            this.button_close_door.Click += new System.EventHandler(this.closeDoor);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Change default temperature";
            // 
            // textbox_new_default_temp
            // 
            this.textbox_new_default_temp.Location = new System.Drawing.Point(329, 151);
            this.textbox_new_default_temp.Name = "textbox_new_default_temp";
            this.textbox_new_default_temp.Size = new System.Drawing.Size(100, 20);
            this.textbox_new_default_temp.TabIndex = 4;
            // 
            // label_default_temp
            // 
            this.label_default_temp.AutoSize = true;
            this.label_default_temp.Location = new System.Drawing.Point(12, 62);
            this.label_default_temp.Name = "label_default_temp";
            this.label_default_temp.Size = new System.Drawing.Size(141, 13);
            this.label_default_temp.TabIndex = 5;
            this.label_default_temp.Text = "Current default temperature: ";
            // 
            // button_change_default_temp
            // 
            this.button_change_default_temp.Location = new System.Drawing.Point(329, 177);
            this.button_change_default_temp.Name = "button_change_default_temp";
            this.button_change_default_temp.Size = new System.Drawing.Size(75, 23);
            this.button_change_default_temp.TabIndex = 6;
            this.button_change_default_temp.Text = "Change";
            this.button_change_default_temp.UseVisualStyleBackColor = true;
            this.button_change_default_temp.Click += new System.EventHandler(this.changeDefaultTemp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // current_temp
            // 
            this.current_temp.AutoSize = true;
            this.current_temp.Location = new System.Drawing.Point(121, 33);
            this.current_temp.Name = "current_temp";
            this.current_temp.Size = new System.Drawing.Size(35, 13);
            this.current_temp.TabIndex = 8;
            this.current_temp.Text = "label1";
            // 
            // default_temp
            // 
            this.default_temp.AutoSize = true;
            this.default_temp.Location = new System.Drawing.Point(159, 62);
            this.default_temp.Name = "default_temp";
            this.default_temp.Size = new System.Drawing.Size(35, 13);
            this.default_temp.TabIndex = 9;
            this.default_temp.Text = "label1";
            // 
            // wineCoolerImage
            // 
            this.wineCoolerImage.Location = new System.Drawing.Point(15, 110);
            this.wineCoolerImage.Name = "wineCoolerImage";
            this.wineCoolerImage.Size = new System.Drawing.Size(305, 217);
            this.wineCoolerImage.TabIndex = 10;
            this.wineCoolerImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 339);
            this.Controls.Add(this.wineCoolerImage);
            this.Controls.Add(this.default_temp);
            this.Controls.Add(this.current_temp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_change_default_temp);
            this.Controls.Add(this.label_default_temp);
            this.Controls.Add(this.textbox_new_default_temp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_close_door);
            this.Controls.Add(this.button_open_door);
            this.Controls.Add(this.label_curr_temp);
            this.Name = "Form1";
            this.Text = "Wine Cooler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wineCoolerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_curr_temp;
        private System.Windows.Forms.Button button_open_door;
        private System.Windows.Forms.Button button_close_door;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_new_default_temp;
        private System.Windows.Forms.Label label_default_temp;
        private System.Windows.Forms.Button button_change_default_temp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label current_temp;
        private System.Windows.Forms.Label default_temp;
        private System.Windows.Forms.PictureBox wineCoolerImage;
    }
}

