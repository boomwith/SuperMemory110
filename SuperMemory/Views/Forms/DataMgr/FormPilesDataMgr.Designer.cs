namespace SuperMemory.Views.Forms.DataMgr
{
    partial class FormPilesDataMgr
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
            this.ucPilesDataMgr = new SuperMemory.Views.UserControls.DataMgr.UcPilesDataMgr();
            this.SuspendLayout();
            // 
            // ucPilesDataMgr
            // 
            this.ucPilesDataMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPilesDataMgr.Location = new System.Drawing.Point(0, 0);
            this.ucPilesDataMgr.Name = "ucPilesDataMgr";
            this.ucPilesDataMgr.Size = new System.Drawing.Size(1060, 624);
            this.ucPilesDataMgr.TabIndex = 0;
            // 
            // FormPilesDataMgr
            // 
            this.ClientSize = new System.Drawing.Size(1060, 624);
            this.Controls.Add(this.ucPilesDataMgr);
            this.Name = "FormPilesDataMgr";
            this.TabText = "׮���ݹ���";
            this.Text = "׮���ݹ���";
            this.Load += new System.EventHandler(this.FormPilesDataMgr_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.DataMgr.UcPilesDataMgr ucPilesDataMgr;
    }
}
