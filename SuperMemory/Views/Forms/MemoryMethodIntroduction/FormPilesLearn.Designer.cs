namespace SuperMemory.Views.Forms.MemoryMethodIntroduction
{
    partial class FormPilesLearn
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
            this.ucPielsLearn = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.PilesLearn.UcPielsLearn();
            this.SuspendLayout();
            // 
            // ucPielsLearn
            // 
            this.ucPielsLearn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucPielsLearn.Location = new System.Drawing.Point(87, 22);
            this.ucPielsLearn.Name = "ucPielsLearn";
            this.ucPielsLearn.Size = new System.Drawing.Size(849, 581);
            this.ucPielsLearn.TabIndex = 0;
            // 
            // FormPilesLearn
            // 
            this.ClientSize = new System.Drawing.Size(1028, 633);
            this.Controls.Add(this.ucPielsLearn);
            this.Name = "FormPilesLearn";
            this.TabText = "110׮ѧϰ";
            this.Text = "110׮ѧϰ";
            this.Load += new System.EventHandler(this.FormPilesLearn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.MemoryMethodIntroduction.PilesLearn.UcPielsLearn ucPielsLearn;
    }
}
