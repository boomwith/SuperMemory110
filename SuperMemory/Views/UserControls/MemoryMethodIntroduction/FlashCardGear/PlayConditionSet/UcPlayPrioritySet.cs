using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet
{
    public partial class UcPlayPrioritySet : UcCbbSetBase
    {


        #region ����
        public const int VALUE_PILE_NUMBER_PRIO = 1;
        private const string NAME_PILE_NUMBER_PRIO = "׮������";

        public const int VALUE_PILE_PIC_PRIO = 2;
        private const string NAME_PILE_PIC_PRIO = "ͼ������";

        public const int VALUE_PILE_WORD_PRIO = 3;
        private const string NAME_PILE_WORD_PRIO = "������";

        public const int VALUE_PILE_ROlE_PRIO = 4;
        private const string NAME_PILE_ROlE_PRIO = "��ɫ����";
        
        public const int VALUE_PILE_ACTION_PRIO = 5;
        private const string NAME_PILE_ACTION_PRIO = "��������";
        #endregion

        #region ��
        public const int VALUE_PILE_NUMBER_ONLY = 6;
        private const string NAME_PILE_NUMBER_ONLY = "��׮��";

        public const int VALUE_PILE_PIC_ONLY = 7;
        private const string NAME_PILE_PIC_ONLY = "��ͼ��";

        public const int VALUE_PILE_WORD_ONLY = 8;
        private const string NAME_PILE_WORD_ONLY = "����";

        public const int VALUE_PILE_ROLE_ONLY = 9;
        private const string NAME_PILE_ROLE_ONLY = "����ɫ";

        public const int VALUE_PILE_ACTION_ONLY = 10;
        private const string NAME_PILE_ACTION_ONLY = "������";
        #endregion


        public UcPlayPrioritySet()
        {
            InitializeComponent();
        }


        public void setObserver(IPlayPrioritySetObserver ob)
        {
            this.ob = ob;
        }

        protected override void createValues(DataTable ret)
        {
            ret.Rows.Add(this.createRow(ret, NAME_PILE_NUMBER_PRIO, VALUE_PILE_NUMBER_PRIO));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_PIC_PRIO, VALUE_PILE_PIC_PRIO));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_WORD_PRIO, VALUE_PILE_WORD_PRIO));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_ROlE_PRIO, VALUE_PILE_ROlE_PRIO));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_ACTION_PRIO, VALUE_PILE_ACTION_PRIO));

            ret.Rows.Add(this.createRow(ret, NAME_PILE_NUMBER_ONLY, VALUE_PILE_NUMBER_ONLY));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_PIC_ONLY, VALUE_PILE_PIC_ONLY));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_WORD_ONLY, VALUE_PILE_WORD_ONLY));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_ROLE_ONLY, VALUE_PILE_ROLE_ONLY));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_ACTION_ONLY, VALUE_PILE_ACTION_ONLY));
        }

        protected override void onSelChanged()
        {
            if (null == this.ob)
            {
                return;
            }

            this.ob.onPlayPriorityChanged(this.getSelValue());            
        }

         private IPlayPrioritySetObserver ob;
    }
}
