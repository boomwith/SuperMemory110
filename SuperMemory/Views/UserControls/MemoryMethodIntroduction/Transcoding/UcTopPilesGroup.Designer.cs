namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding
{
    partial class UcTopPilesGroup
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
            this.pile4 = new SuperMemory.Views.UserControls.Common.UcRadioPileViewBase();
            this.pile3 = new SuperMemory.Views.UserControls.Common.UcRadioPileViewBase();
            this.pile2 = new SuperMemory.Views.UserControls.Common.UcRadioPileViewBase();
            this.pile1 = new SuperMemory.Views.UserControls.Common.UcRadioPileViewBase();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pile4
            // 
            this.pile4.BackColor = System.Drawing.SystemColors.Control;
            this.pile4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pile4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pile4.Location = new System.Drawing.Point(534, 3);
            this.pile4.Name = "pile4";
            this.pile4.Size = new System.Drawing.Size(172, 168);
            this.pile4.TabIndex = 7;
            // 
            // pile3
            // 
            this.pile3.BackColor = System.Drawing.SystemColors.Control;
            this.pile3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pile3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pile3.Location = new System.Drawing.Point(357, 3);
            this.pile3.Name = "pile3";
            this.pile3.Size = new System.Drawing.Size(171, 168);
            this.pile3.TabIndex = 6;
            // 
            // pile2
            // 
            this.pile2.BackColor = System.Drawing.SystemColors.Control;
            this.pile2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pile2.Location = new System.Drawing.Point(180, 3);
            this.pile2.Name = "pile2";
            this.pile2.Size = new System.Drawing.Size(171, 168);
            this.pile2.TabIndex = 5;
            // 
            // pile1
            // 
            this.pile1.BackColor = System.Drawing.SystemColors.Control;
            this.pile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pile1.Location = new System.Drawing.Point(3, 3);
            this.pile1.Name = "pile1";
            this.pile1.Size = new System.Drawing.Size(171, 168);
            this.pile1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pile1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pile4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pile2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pile3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 174);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // UcTopPilesGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcTopPilesGroup";
            this.Size = new System.Drawing.Size(709, 174);
            this.Load += new System.EventHandler(this.UcTopPilesGroup_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.Common.UcRadioPileViewBase pile4;
        private SuperMemory.Views.UserControls.Common.UcRadioPileViewBase pile3;
        private SuperMemory.Views.UserControls.Common.UcRadioPileViewBase pile2;
        private SuperMemory.Views.UserControls.Common.UcRadioPileViewBase pile1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}
