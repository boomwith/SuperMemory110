namespace SuperMemory.Views.Forms.MemoryMethodIntroduction
{
    partial class FormTranscoding
    {
        /// <summary>
        /// ����������������
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ������������ʹ�õ���Դ��
        /// </summary>
        /// <param name="disposing">���Ӧ�ͷ��й���Դ��Ϊ true������Ϊ false��</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows ������������ɵĴ���

        /// <summary>
        /// �����֧������ķ��� - ��Ҫ
        /// ʹ�ô���༭���޸Ĵ˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            this.ucTranscodingSetting = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding.UcTranscodingSetting();
            this.SuspendLayout();
            // 
            // ucTranscodingSetting
            // 
            this.ucTranscodingSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucTranscodingSetting.Location = new System.Drawing.Point(106, 22);
            this.ucTranscodingSetting.Name = "ucTranscodingSetting";
            this.ucTranscodingSetting.Size = new System.Drawing.Size(559, 446);
            this.ucTranscodingSetting.TabIndex = 0;
            // 
            // FormTranscoding
            // 
            this.ClientSize = new System.Drawing.Size(769, 485);
            this.Controls.Add(this.ucTranscodingSetting);
            this.Name = "FormTranscoding";
            this.TabText = "����ת��";
            this.Text = "����ת��";
            this.Load += new System.EventHandler(this.FormTranscoding_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding.UcTranscodingSetting ucTranscodingSetting;
    }
}
