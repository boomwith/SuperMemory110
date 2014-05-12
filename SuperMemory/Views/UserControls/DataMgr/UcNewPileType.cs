using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Entities;
using SuperMemory.Utils;
using SuperMemory.Model;
using SuperMemory.Model.Biz.DataMgr.PilesDataMgr;

namespace SuperMemory.Views.UserControls.DataMgr
{
    public partial class UcNewPileType : SuperMemory.Views.UserControls.Common.UcFormMainBase
    {
        public UcNewPileType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            biz().saveNewSubPileType();
            closeMe();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            closeMe();
        }

        private void closeMe()
        {
            this.cleanInput();
            this.Parent.Hide();
        }

        private void cleanInput()
        {
            this.tbName.Text = "";
        }

        //private void createPileType()
        //{
        //    pileType = new CPileType();
        //    pileType.PileTypeId = this.newPileTypeId();
        //    pileType.ParentTypeId = this.newTypeParentTypeId();
        //    pileType.TypeOrder = this.newTypeOrder();
        //    pileType.IsLeaf = this.newTypeIsLeaf();

        //}

        //private bool newTypeIsLeaf()
        //{
        //    // ����������ѡ�е���root�� return false
        //    // ���� return ture

        //    if (this.isCurChosenRoot())
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        //private int newTypeOrder()
        //{
        //    // ͬһ�㼶��׷�����������
        //    // ��������ѡ�еĽڵ㣬�����ݿ���������ڵ��µ��ӽڵ�����һ��˳���
            
        //    // �����ҵ���˳��� + 1;

        //    return this.getCurTypeLevelLastOrder() + 1;
        //}

        //private int getCurTypeLevelLastOrder()
        //{
        //    // ���ѡ�нڵ��� root ������ݿ�ѡ���з�Ҷ���������һ��˳���
        //    if(this.isCurChosenRoot())
        //    {
        //        return CModelMgr.Inst.Db.PileType.getLastNotLeafTypeOrder();
        //    }
        //    // ����ѡ��ǰ������������˳���
        //    return CModelMgr.Inst.Db.PileType.getLastLeafTypeOrderByParentId(this.getCurChosenPileTypeId());
        //}

        //private string getCurChosenPileTypeId()
        //{
        //    return ((CPileType)biz().CurPileType).PileTypeId;
        //}

        //private bool isCurChosenRoot()
        //{
        //    return biz().CurPileType is string;
        //}

        //private string newTypeParentTypeId()
        //{
        //    return getCurChosenPileTypeId();
        //}

        //private string newPileTypeId()
        //{
        //    return "pt" + CIDGenerator.Inst.gen();
        //}

        private CPilesDataMgrBiz biz()
        {
            return CModelMgr.Inst.Biz.DataMgr.PilesDatMgr;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            biz().NewSubPileTypeCreator.PileType.PileTypeName = this.tbName.Text;
        }

        //private CPileType pileType;
    }
}

