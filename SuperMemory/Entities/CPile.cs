using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Entities
{
    /// <summary>
    /// 110 ����г������׮
    /// </summary>
    public class CPile
    {
        /// <summary>
        /// ׮ͼ
        /// </summary>
        private string pic;

        public string Pic
        {
            get { return pic; }
            set { pic = value; }
        }

        /// <summary>
        /// ׮��
        /// </summary>
        private string pileNumber;

        public string PileNumber
        {
            get { return pileNumber; }
            set { pileNumber = value; }
        }

        /// <summary>
        /// ׮��(г����)
        /// </summary>
        private string word;

        public string Word
        {
            get { return word; }
            set { word = value; }
        }

        /// <summary>
        /// ��ɫ
        /// </summary>
        private string role;

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        /// <summary>
        /// ���Ƕ���
        /// </summary>
        private string action;

        public string Action
        {
            get { return action; }
            set { action = value; }
        }
        /// <summary>
        /// ԭʼ˳��:������Ȼ˳��
        /// </summary>
        private int primOrder;

        public int PrimOrder
        {
            get { return primOrder; }
            set { primOrder = value; }
        }
        /// <summary>
        /// ׮���id
        /// </summary>
        private string pileTypeId;

        public string PileTypeId
        {
            get { return pileTypeId; }
            set { pileTypeId = value; }
        }
    }
}
