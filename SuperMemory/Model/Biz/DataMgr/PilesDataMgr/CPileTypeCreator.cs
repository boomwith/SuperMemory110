using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;
using SuperMemory.Utils;
using System.Windows.Forms;
using SuperMemory.Model.DB.TablePileType;
using SuperMemory.Partten.Observer;

namespace SuperMemory.Model.Biz.DataMgr.PilesDataMgr
{
    public class CPileTypeCreator
    {
        internal void create(object parentPileType)
        {
            this.parentPileType = parentPileType;

            pileType = new CPileType();
            pileType.PileTypeId = this.newPileTypeId();
            pileType.ParentTypeId = this.newTypeParentTypeId();
            pileType.TypeOrder = this.newTypeOrder();
            pileType.IsLeaf = this.newTypeIsLeaf();
        }

        internal void save2DB()
        {
            if(this.invalidInputName())
            {
                MessageBox.Show("����д�������");
                return;
            }

            this.pileTypeDB().saveNewEnt(this.pileType);

        }

        private bool invalidInputName()
        {
            if (null == this.pileType.PileTypeName)
            {
                return false;
            }
            return this.pileType.PileTypeName.Equals("");
        }

        private bool newTypeIsLeaf()
        {
            // ����������ѡ�е���root�� return false
            // ���� return ture

            if (this.isParentTypeRoot())
            {
                return false;
            }

            return true;
        }

        private int newTypeOrder()
        {
            // ͬһ�㼶��׷�����������
            // ��������ѡ�еĽڵ㣬�����ݿ���������ڵ��µ��ӽڵ�����һ��˳���

            // �����ҵ���˳��� + 1;

            return this.getCurTypeLevelLastOrder() + 1;
        }

        private int getCurTypeLevelLastOrder()
        {
            // ���ѡ�нڵ��� root ������ݿ�ѡ���з�Ҷ���������һ��˳���
            if (this.isParentTypeRoot())
            {
                return CModelMgr.Inst.Db.PileType.getLastNotLeafTypeOrder();
            }
            // ����ѡ��ǰ������������˳���
            return CModelMgr.Inst.Db.PileType.getLastLeafTypeOrderByParentId(this.getParentPileTypeId());
        }

        private string getParentPileTypeId()
        {
            if (this.isParentTypeRoot())
            {
                return "";
            }
            return ((CPileType)this.parentPileType).PileTypeId;
        }

        private bool isParentTypeRoot()
        {
            return this.parentPileType is string;
        }

        private string newTypeParentTypeId()
        {
            return getParentPileTypeId();
        }

        private string newPileTypeId()
        {
            return "pt" + CIDGenerator.Inst.gen();
        }

        private CTablePileType pileTypeDB()
        {
            return CModelMgr.Inst.Db.PileType;
        }

        
        private CPileType pileType;

        public CPileType PileType
        {
            get { return pileType; }
        }

        private object parentPileType;


    }
}
