namespace SuperMemory.Views.Forms.MemoryMethodIntroduction
{
    partial class FormPicChoiceMeaning
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
            this.ucPicChoiceMeaningSetting = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning.UcPicChoiceMeaningSetting();
            this.SuspendLayout();
            // 
            // ucPicChoiceMeaningSetting
            // 
            this.ucPicChoiceMeaningSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucPicChoiceMeaningSetting.Location = new System.Drawing.Point(101, 12);
            this.ucPicChoiceMeaningSetting.Name = "ucPicChoiceMeaningSetting";
            this.ucPicChoiceMeaningSetting.Size = new System.Drawing.Size(568, 454);
            this.ucPicChoiceMeaningSetting.TabIndex = 0;
            // 
            // FormPicChoiceMeaning
            // 
            this.ClientSize = new System.Drawing.Size(781, 487);
            this.Controls.Add(this.ucPicChoiceMeaningSetting);
            this.Name = "FormPicChoiceMeaning";
            this.TabText = "��ͼѡ��";
            this.Text = "��ͼѡ��";
            this.Load += new System.EventHandler(this.FormPicChoiceMeaning_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning.UcPicChoiceMeaningSetting ucPicChoiceMeaningSetting;
    }
}
