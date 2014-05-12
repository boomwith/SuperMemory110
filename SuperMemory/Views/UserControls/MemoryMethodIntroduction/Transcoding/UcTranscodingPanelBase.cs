using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding;
using SuperMemory.Model;
using SuperMemory.Enums;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding
{
    public partial class UcTranscodingPanelBase : UserControl, ITranscodingPanel
    {
        public UcTranscodingPanelBase()
        {
            InitializeComponent();
        }

        public void initLoad()
        {
            Biz.TranscodingPanel = this;
            Biz.GroupCountDownView = this.ucGroupCountDownView;
        }

        private void btnStartTrainning_Click(object sender, EventArgs e)
        {
            Biz.beginTrainning();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            (this.Parent as Form).Close();
        }

        private CTranscodingBiz Biz
        {
            get { return CModelMgr.Inst.Biz.MemoryMethodIntroduction.Transcoding; }
        }

        public EnumTranscodingType TranscodingType
        {
            set
            {
                this.ucTranscodingPart.TranscodingType = value;
            }
        }

        #region ITranscodingPanel ��Ա

        void ITranscodingPanel.showResetGroupPromp()
        {
            MessageBox.Show("��������������⣡", "�������");
        }

        void ITranscodingPanel.showContinueNextGroupPrompt()
        {
            MessageBox.Show("������ȷ��������һ�⣡", "������ȷ");
        }

        void ITranscodingPanel.showTrainningFinishPrompt()
        {
            MessageBox.Show("ѵ��������", "�ɼ����£�");
        }

        #endregion

        #region ITranscodingPanel ��Ա

        private delegate void cleanAllPilesMarkDele();
        void ITranscodingPanel.cleanAllPilesMark()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new cleanAllPilesMarkDele((this as ITranscodingPanel).cleanAllPilesMark));
                return;
            }
            this.ucTranscodingPart.cleanAllPilesMark();
        }

        #endregion
    }
}
