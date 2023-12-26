namespace Programming_CW_1
{
    partial class SurgeonDashboard_form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_filter = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txt_searchAppointmentId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(1, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 369);
            this.panel2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 80);
            this.panel1.TabIndex = 23;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(711, 51);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Programming_CW_1.Properties.Resources._360_F_299669045_MqHC52q09Ze8Xg1MXyHd09uU5nLxAL5N;
            this.pictureBox1.Location = new System.Drawing.Point(15, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(615, 15);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(0, 24);
            this.lbl_username.TabIndex = 0;
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(160, 220);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.Size = new System.Drawing.Size(628, 218);
            this.dataGridViewAppointments.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Enter AppointmentId:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_filter);
            this.panel3.Controls.Add(this.dateTimePicker);
            this.panel3.Controls.Add(this.txt_searchAppointmentId);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(161, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(627, 95);
            this.panel3.TabIndex = 26;
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.LightGreen;
            this.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter.Location = new System.Drawing.Point(534, 49);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_filter.TabIndex = 26;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(380, 51);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker.TabIndex = 25;
            // 
            // txt_searchAppointmentId
            // 
            this.txt_searchAppointmentId.Location = new System.Drawing.Point(169, 49);
            this.txt_searchAppointmentId.Name = "txt_searchAppointmentId";
            this.txt_searchAppointmentId.Size = new System.Drawing.Size(100, 20);
            this.txt_searchAppointmentId.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Filter appointments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Enter Date:";
            // 
            // SurgeonDashboard_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.panel3);
            this.Name = "SurgeonDashboard_form";
            this.Text = "SurgeonDashboard_form";
            this.Load += new System.EventHandler(this.SurgeonDashboard_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txt_searchAppointmentId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_logout;
    }
}