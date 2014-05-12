using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Entities
{
    public class CPileType
    {
        /// <summary>
        /// ���id
        /// </summary>
        private string pileTypeId;

        public string PileTypeId
        {
            get { return pileTypeId; }
            set { pileTypeId = value; }
        }

        /// <summary>
        /// �������
        /// </summary>
        private string pileTypeName;

        public string PileTypeName
        {
            get { return pileTypeName; }
            set { pileTypeName = value; }
        }

        /// <summary>
        /// �ϼ���� id
        /// </summary>
        private string parentTypeId;

        public string ParentTypeId
        {
            get { return parentTypeId; }
            set { parentTypeId = value; }
        }

        /// <summary>
        /// �Ƿ�Ҷ�����
        /// </summary>
        private bool isLeaf;

        public bool IsLeaf
        {
            get { return isLeaf; }
            set { isLeaf = value; }
        }

        /// <summary>
        /// ˳��
        /// </summary>
        private int typeOrder;

        public int TypeOrder
        {
            get { return typeOrder; }
            set { typeOrder = value; }
        }
    }
}
