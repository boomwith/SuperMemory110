using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Model;
using SuperMemory.Model.DB.TablePileType;
using SuperMemory.Entities;
using SuperMemory.Model.Biz.DataMgr.PilesDataMgr;
using SuperMemory.Views.Forms.DataMgr;
using SuperMemory.Partten.Observer;
using SuperMemory.Global;

namespace SuperMemory.Views.UserControls.DataMgr
{
    public partial class UcPilesDataMgr : SuperMemory.Views.UserControls.Common.UcFormMainBase, IObserver
    {
        public const string GROUP_BOX_PILE_DETAIL_TITLE_HEAD= "׮��ϸ,��ǰ������";
        public const string GROUP_BOX_PILE_GRID_TILE_HEAD = "׮�б���ǰ׮���";

        public UcPilesDataMgr()
        {
            InitializeComponent();
        }

        public override void initLoad()
        {
            this.biz().add(this);

            // ������
            this.updatePileTypesTreeData();
            // ׮����������
            this.updatePilesOperBtnsState();

            // ׮������
            this.updatePilesGridData();

            // ׮��ϸ����
            this.updatePileDetailData();
        }

        #region IObserver ��Ա

        void IObserver.notified(int eventId)
        {
            switch (eventId)
            {
                case CPilesDataMgrBiz.EVENT_NEW_PILE_TYPE_SAVED:
                case CPilesDataMgrBiz.EVENT_CUR_PILE_TYPE_DELETED:
                    // ���ⷢ���仯(��������ɾ����)
                    updatePileTypesTreeData();
                    break;
                case CPilesDataMgrBiz.EVENT_CUR_PILE_TYPE_CHANGED:
                    // ��ǰѡ��������仯
                    this.updatePilesGridData();
                    this.updatePilesOperBtnsState();
                    break;
                case CPilesDataMgrBiz.EVNE_CUR_PILE_STATE_CHANGED:
                    // ��ǰ׮״̬�仯��׮��\ɾ\�ģ�
                    this.updatePileDetailData();
                    break;
                case CPilesDataMgrBiz.EVENT_NEW_PILE_SAVED:
                case CPilesDataMgrBiz.EVENT_EDIT_PILE_SAVED:
                    // ��׮����� 
                    this.updatePilesGridData();
                    break;
                case CPilesDataMgrBiz.EVENT_CUR_PILE_CHAGED:
                    this.updatePileDetailData();
                    break;
            }

        }


        #endregion


        #region ����׮�����
        private void updatePileTypesTreeData()
        {

            this.cleanTree();

            TreeNode root = new TreeNode();
            root.Text = "׮���";
            root.Tag = "root";
            this.tvPileTypes.Nodes.Add(root);

            this.loadAllParentPileTypeNodes(root);
        }

        private void cleanTree()
        {
            this.tvPileTypes.Nodes.Clear();
        }
        /// <summary>
        /// �������и����ڵ�
        /// </summary>
        /// <param name="rootNode"></param>
        private void loadAllParentPileTypeNodes(TreeNode rootNode)
        {
            List<CPileType> allParenTypeEnts = CModelMgr.Inst.Db.PileType.laodAllParentTypeEnts();
            if (null == allParenTypeEnts)
            {
                return ;
            }
            foreach (CPileType ent in allParenTypeEnts)
            {
                rootNode.Nodes.Add(this.create1ParentPileTypeNodeByEnt(ent));
            }
        }

        /// <summary>
        /// ����һ�������ڵ�
        /// </summary>
        /// <param name="ent"></param>
        /// <returns></returns>
        private TreeNode create1ParentPileTypeNodeByEnt(CPileType ent)
        {
            TreeNode ret = new TreeNode();
            ret.Text = ent.PileTypeName;
            ret.Tag = ent;
            this.load1parentAllChildrenNodes(ret,ent);
            return ret;
        }
        /// <summary>
        /// ����һ�������ڵ�������ӽڵ�
        /// </summary>
        /// <param name="parentNode"></param>
        /// <param name="parnetEnt"></param>
        private void load1parentAllChildrenNodes(TreeNode parentNode, CPileType parnetEnt)
        {
            List<CPileType> chidrenEnts = CModelMgr.Inst.Db.PileType.load1ParentAllChildrenEnts(parnetEnt.PileTypeId);
            foreach (CPileType ent in chidrenEnts)
            {
                parentNode.Nodes.Add(this.create1SubPileTypeNodeByEnt(ent));
            }
        }
        /// <summary>
        /// ����һ�������ڵ�
        /// </summary>
        /// <param name="ent"></param>
        /// <returns></returns>
        private TreeNode create1SubPileTypeNodeByEnt(CPileType ent)
        {
            TreeNode ret = new TreeNode();
            ret.Text = ent.PileTypeName;
            ret.Tag = ent;
            return ret;
        }

        #endregion

        #region ����׮������ť��
        private void updatePilesOperBtnsState()
        {
            if (!biz().isChosenPileTypeLeaf())
            {
                this.unenablePileOperBtns();
            }
            else
            {
                this.enablePileOperBtns();
            }
        }

        private void unenablePileOperBtns()
        {
            this.btnNewPile.Enabled = false;
            this.btnEditPile.Enabled = false;
            this.btnDelPile.Enabled = false;
        }

        private void enablePileOperBtns()
        {
            this.btnNewPile.Enabled = true;
            this.btnEditPile.Enabled = true;
            this.btnDelPile.Enabled = true;
        }
        #endregion 

        #region ����׮���
        private void updatePilesGridData()
        {
            DataTable dtPiles = biz().loadCurPileTypePiles();
            if(null == dtPiles)
            {
                if (null == this.dgvPiles.DataSource)
                {
                    this.pilesGridTitleNon();
                    return;
                }
                this.pilesGridTitleNon();
                cleanPilesGrid();
                return;
            }

            this.updatePilesGridTitle();
            this.dgvPiles.DataSource = dtPiles;
            for (int i = 0; i < this.dgvPiles.Rows.Count;i++ )
            {
                this.dgvPiles["colPilePic", i].Value = this.getPileImgeByRowIndex(i);//Image.FromFile(this.dgvPiles["colPilePicSrc",i].Value.ToString());
            }

        }

        private Image getPileImgeByRowIndex(int i)
        {
            if (null == this.dgvPiles["colPilePicSrc", i].Value)
            {
                return null;
            }
            if ("".Equals(this.dgvPiles["colPilePicSrc", i].Value.ToString()))
            {
                return null;
            }
            return Image.FromFile(this.dgvPiles["colPilePicSrc", i].Value.ToString()); 
        }



        private void updatePilesGridTitle()
        {
            this.gbPilesGrid.Text = GROUP_BOX_PILE_GRID_TILE_HEAD + biz().getCurPileTypeName();
        }



        private void pilesGridTitleNon()
        {
            this.gbPilesGrid.Text = GROUP_BOX_PILE_GRID_TILE_HEAD + "��";
        }

        private void cleanPilesGrid()
        {
            ((DataTable)(this.dgvPiles.DataSource)).Clear();
        }
        #endregion

        #region ����׮��ϸ
        private void updatePileDetailData()
        {
            switch(biz().CurPileState)
            {
                case CPilesDataMgrBiz.CUR_PILE_STATE_NON:
                    this.gbPileDetail.Text = GROUP_BOX_PILE_DETAIL_TITLE_HEAD + "��";
                    this.unEnablePileDetail();
                    this.updatePileDetailView();
                    break;
                case CPilesDataMgrBiz.CUR_PILE_STATE_NEW:
                    this.gbPileDetail.Text = GROUP_BOX_PILE_DETAIL_TITLE_HEAD + "�½�׮";
                    this.enablePileDetail();
                    this.cleanPileDetail();
                    break;
                case CPilesDataMgrBiz.CUR_PILE_STATE_EDIT:
                    this.gbPileDetail.Text = GROUP_BOX_PILE_DETAIL_TITLE_HEAD + "�༭׮";
                    this.updatePileDetailView();
                    this.enablePileDetail();
                    this.tbPileNumber.Enabled = false;
                    break;
            }

            
        }

        private void updatePileDetailView()
        {
            if (null == biz().CurPile)
            {
                return;
            }

            this.tbPileNumber.Text = biz().CurPile.PileNumber;
            this.tbPileWord.Text = biz().CurPile.Word;
            this.rtbPileAction.Text = biz().CurPile.Action;
            this.tbRole.Text = biz().CurPile.Role;

            if (null == biz().CurPile.Pic)
            {
                this.picbPile.Image = null;
                return;
            }
            if ("".Equals(biz().CurPile.Pic))
            {
                this.picbPile.Image = null;
                return;
            }
            this.picbPile.Image = Image.FromFile(CGlobal.Inst.PilePicDir + biz().CurPile.Pic);
        }

        private void enablePileDetail()
        {
            this.tbPileNumber.Enabled = true;
            this.tbPileWord.Enabled = true;
            this.picbPile.Enabled = true;
            this.tbRole.Enabled = true;
            this.rtbPileAction.Enabled = true;
            this.btnSavePile.Enabled = true;
        }

        private void unEnablePileDetail()
        {
            this.tbPileNumber.Enabled = false;
            this.tbPileWord.Enabled = false;
            this.tbRole.Enabled = false;
            this.picbPile.Enabled = false;
            this.rtbPileAction.Enabled = false;
            this.btnSavePile.Enabled = false;
        }

        private void cleanPileDetail()
        {
            this.tbPileNumber.Text = "";
            this.tbPileWord.Text = "";
            this.tbRole.Text = "";
            this.rtbPileAction.Text = "";
            this.picbPile.Image = null;
        }
        #endregion

        #region ����������������¼���
        /// <summary>
        /// �����������ϵ�ĳ���ڵ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvPileTypes_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //ѡ��������ڵ�
            biz().CurPileType = e.Node.Tag;

            if( isRightClickTreeNode(e))
            {
                // �Ҽ�������ϵ�ĳ���ڵ�
                if(biz().isChosenPileTypeRoot())
                {
                    showPileTypsOperMenuOnlyNewOper(e);
                }
                else if (biz().isChosenPileTypeNotLeaf())
                {
                    showPileTypesOperMenuFull(e);
                }
             

            }
            
        }
        /// <summary>
        /// ��׮�����˵� 
        /// </summary>
        /// <param name="e"></param>
        private void showPilesOperMenu(TreeNodeMouseClickEventArgs e)
        {
            this.cmsPilesOper.Show(this.tvPileTypes.PointToScreen(new Point(e.X, e.Y)));
        }
        /// <summary>
        /// ��������׮�������˵�
        /// </summary>
        /// <param name="e"></param>
        private void showPileTypesOperMenuFull(TreeNodeMouseClickEventArgs e)
        {
            this.cmsPileTypesOper.Items["tsmiEditPileType"].Visible = true;
            this.cmsPileTypesOper.Items["tsmiDeletePileType"].Visible = true;
            this.cmsPileTypesOper.Show(this.tvPileTypes.PointToScreen(new Point(e.X, e.Y)));
        }
        /// <summary>
        /// �Ƿ�ѡ���� root �ڵ�
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private static bool isClickTreeNodeRoot(TreeNodeMouseClickEventArgs e)
        {
            return e.Node.Tag.ToString().Equals("root");
        }
        /// <summary>
        /// ��ֻ�С�������𡱵�׮�������˵�
        /// </summary>
        /// <param name="e"></param>
        private void showPileTypsOperMenuOnlyNewOper(TreeNodeMouseClickEventArgs e)
        {
            this.cmsPileTypesOper.Items["tsmiEditPileType"].Visible = false;
            this.cmsPileTypesOper.Items["tsmiDeletePileType"].Visible = false;

            this.cmsPileTypesOper.Show(this.tvPileTypes.PointToScreen(new Point(e.X, e.Y)));
        }
        /// <summary>
        /// �Ƿ�ѡ���˸����ڵ�
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private bool isClickTreeParentTypeNode(TreeNodeMouseClickEventArgs e)
        {
            return ((CPileType)(e.Node.Tag)).IsLeaf == false;
        }
        /// <summary>
        /// �Ƿ�������Ҽ������׮������ϵĽڵ�
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private  bool isRightClickTreeNode(TreeNodeMouseClickEventArgs e)
        {
            return e.Button == MouseButtons.Right;
        }

        /// <summary>
        /// �½����,Ϊ��ǰ�ڵ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiNewPileType_Click(object sender, EventArgs e)
        {
            // �����ǰѡ�� root 
            // ֻ�����ӷ�Ҷ�����

            // ���ѡ�з�Ҷ�����
            // ֻ������Ҷ�����

            // ��ѡ�е�CPileType ���󴫸� �½����Ի���
            biz().newSubPileType();

            new FormNewPileType().ShowDialog(this);
        }
        /// <summary>
        /// �༭��ǰ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiEditPileType_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ɾ����ǰ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDeletePileType_Click(object sender, EventArgs e)
        {
            DialogResult dlgRet = MessageBox.Show("�Ƿ�ɾ����ǰѡ�����", "��ʾ", MessageBoxButtons.OKCancel);
            if (dlgRet == DialogResult.Cancel)
            {
                return;
            }
            biz().deleteCurChosenPileType();
        }
        #endregion

        private CPilesDataMgrBiz biz()
        {
            return CModelMgr.Inst.Biz.DataMgr.PilesDatMgr;
        }


        #region ׮����ɾ�Ĳ����������¼���
        /// <summary>
        /// �����½�׮״̬
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewPile_Click(object sender, EventArgs e)
        {
            biz().newPile();
        }
        /// <summary>
        /// ����༭��ǰ׮״̬
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditPile_Click(object sender, EventArgs e)
        {
            biz().editCurPile();
        }
        /// <summary>
        /// ɾ����ǰ׮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelPile_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePile_Click(object sender, EventArgs e)
        {
            biz().saveCurPile();
        }
        #endregion


        #region ׮��ϸ����
        private void tbPileNumber_TextChanged(object sender, EventArgs e)
        {
            biz().CurPile.PileNumber = tbPileNumber.Text;
        }

        private void tbPileWord_TextChanged(object sender, EventArgs e)
        {
            biz().CurPile.Word = tbPileWord.Text;
        }

        private void rtbPileAction_TextChanged(object sender, EventArgs e)
        {
            biz().CurPile.Action = rtbPileAction.Text;
        }

        private void tbRole_TextChanged(object sender, EventArgs e)
        {
            biz().CurPile.Role = tbRole.Text;
        }

        private void picbPile_Click(object sender, EventArgs e)
        {
            string chosenFile;
            if (this.openFileDialogPilePic.ShowDialog() == DialogResult.OK)
            {
                chosenFile = this.openFileDialogPilePic.FileName;
                biz().PileImagSrc = chosenFile;
                this.picbPile.Image = Image.FromFile(chosenFile);
            }
        }
        #endregion

        private void dgvPiles_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dgvPiles.CurrentRow == null)
            {
                return;
            }
            biz().CurPile = this.getCurChosenPile();
        }

        private CPile getCurChosenPile()
        {
            return biz().loadCurPileTypePileByOrder(this.getCurChosenPileOrder());

        }

        private int getCurChosenPileOrder()
        {
            return int.Parse(this.dgvPiles["colPileOrder", this.dgvPiles.CurrentRow.Index].Value.ToString());
        }







    }
}

