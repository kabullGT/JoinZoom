namespace JoinZoom
{
    partial class ZoomLay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoomLay));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMeetingId = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnJoinMeeting = new System.Windows.Forms.Button();
            this.btnExitMeeting = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUiMessages = new System.Windows.Forms.TextBox();
            this.pboxOverlayWait = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOverlayWait)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meeting #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // txtMeetingId
            // 
            this.txtMeetingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeetingId.Location = new System.Drawing.Point(28, 48);
            this.txtMeetingId.Name = "txtMeetingId";
            this.txtMeetingId.Size = new System.Drawing.Size(153, 35);
            this.txtMeetingId.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(225, 47);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(153, 32);
            this.txtUserName.TabIndex = 3;
            // 
            // btnJoinMeeting
            // 
            this.btnJoinMeeting.BackColor = System.Drawing.Color.Lime;
            this.btnJoinMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinMeeting.Location = new System.Drawing.Point(28, 147);
            this.btnJoinMeeting.Name = "btnJoinMeeting";
            this.btnJoinMeeting.Size = new System.Drawing.Size(106, 51);
            this.btnJoinMeeting.TabIndex = 4;
            this.btnJoinMeeting.Text = "Join";
            this.btnJoinMeeting.UseVisualStyleBackColor = false;
            this.btnJoinMeeting.Click += new System.EventHandler(this.btnJoinMeeting_Click);
            // 
            // btnExitMeeting
            // 
            this.btnExitMeeting.BackColor = System.Drawing.Color.Red;
            this.btnExitMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMeeting.Location = new System.Drawing.Point(157, 147);
            this.btnExitMeeting.Name = "btnExitMeeting";
            this.btnExitMeeting.Size = new System.Drawing.Size(94, 51);
            this.btnExitMeeting.TabIndex = 5;
            this.btnExitMeeting.Text = "Exit";
            this.btnExitMeeting.UseVisualStyleBackColor = false;
            this.btnExitMeeting.Click += new System.EventHandler(this.btnExitMeeting_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Messages:";
            // 
            // txtUiMessages
            // 
            this.txtUiMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUiMessages.Location = new System.Drawing.Point(34, 263);
            this.txtUiMessages.Name = "txtUiMessages";
            this.txtUiMessages.Size = new System.Drawing.Size(344, 30);
            this.txtUiMessages.TabIndex = 7;
            // 
            // pboxOverlayWait
            // 
            this.pboxOverlayWait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxOverlayWait.Image = ((System.Drawing.Image)(resources.GetObject("pboxOverlayWait.Image")));
            this.pboxOverlayWait.InitialImage = ((System.Drawing.Image)(resources.GetObject("pboxOverlayWait.InitialImage")));
            this.pboxOverlayWait.Location = new System.Drawing.Point(-146, -96);
            this.pboxOverlayWait.Name = "pboxOverlayWait";
            this.pboxOverlayWait.Size = new System.Drawing.Size(676, 507);
            this.pboxOverlayWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxOverlayWait.TabIndex = 8;
            this.pboxOverlayWait.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(181, 98);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(153, 32);
            this.txtPwd.TabIndex = 10;
            // 
            // ZoomLay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 317);
            this.ControlBox = false;
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUiMessages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExitMeeting);
            this.Controls.Add(this.btnJoinMeeting);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtMeetingId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxOverlayWait);
            this.Name = "ZoomLay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZoomLay";
            ((System.ComponentModel.ISupportInitialize)(this.pboxOverlayWait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMeetingId;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnJoinMeeting;
        private System.Windows.Forms.Button btnExitMeeting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUiMessages;
        private System.Windows.Forms.PictureBox pboxOverlayWait;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPwd;
    }
}

