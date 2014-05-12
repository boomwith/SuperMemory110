using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayProgress
{
    public partial class UcStepProgresser : UcProgresserBase, IProgresser
    {
        public UcStepProgresser()
        {
            InitializeComponent();
        }

        protected override string getLabel()
        {
            return "���ʱ�䣺";
        }
 


        #region IProgresser ��Ա

        void IProgresser.updateProgress(int value)
        {
            this.updateProgressDo(value);
        }

        #endregion
    }
}

