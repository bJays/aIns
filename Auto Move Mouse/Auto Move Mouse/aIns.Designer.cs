namespace Auto_Move_Mouse
{
    partial class aIns
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AlwaysCheckBox = new System.Windows.Forms.CheckBox();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.OperatingTimer = new System.Windows.Forms.Timer(this.components);
            this.aInsNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // AlwaysCheckBox
            // 
            this.AlwaysCheckBox.AutoSize = true;
            this.AlwaysCheckBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AlwaysCheckBox.Location = new System.Drawing.Point(12, 12);
            this.AlwaysCheckBox.Name = "AlwaysCheckBox";
            this.AlwaysCheckBox.Size = new System.Drawing.Size(122, 16);
            this.AlwaysCheckBox.TabIndex = 0;
            this.AlwaysCheckBox.Text = "&Always Enable";
            this.AlwaysCheckBox.UseVisualStyleBackColor = true;
            this.AlwaysCheckBox.CheckedChanged += new System.EventHandler(this.AlwaysCheckBox_CheckedChanged);
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(12, 31);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(56, 12);
            this.DebugLabel.TabIndex = 1;
            this.DebugLabel.Text = "DebugStr";
            // 
            // aInsNotifyIcon
            // 
            this.aInsNotifyIcon.Text = "aIns";
            this.aInsNotifyIcon.Visible = true;
            // 
            // aIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 46);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.AlwaysCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aIns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "aIns";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.aIns_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.aIns_FormClosed);
            this.Load += new System.EventHandler(this.aIns_Load);
            this.Shown += new System.EventHandler(this.aIns_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AlwaysCheckBox;
        private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.Timer OperatingTimer;
        private System.Windows.Forms.NotifyIcon aInsNotifyIcon;
    }
}

