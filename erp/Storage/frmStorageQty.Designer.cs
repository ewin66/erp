namespace Storage
{
    partial class frmStorageQty
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
            this.cbKind = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.rgOption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbKind.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rgOption
            // 
            this.rgOption.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgOption.Properties.Appearance.Options.UseBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.Size = new System.Drawing.Size(101, 24);
            this.lbTitle.Text = "frmBase";
            // 
            // cbKind
            // 
            this.cbKind.Location = new System.Drawing.Point(439, 35);
            this.cbKind.Name = "cbKind";
            this.cbKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbKind.Properties.Items.AddRange(new object[] {
            "����Ʒ",
            "���Ʒ",
            "ԭ����",
            "����"});
            this.cbKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbKind.Size = new System.Drawing.Size(100, 21);
            this.cbKind.TabIndex = 17;
            this.cbKind.SelectedIndexChanged += new System.EventHandler(this.cbKind_SelectedIndexChanged);
            // 
            // frmStorageQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(722, 469);
            this.Controls.Add(this.cbKind);
            this.Name = "frmStorageQty";
            this.Text = "ʵʱ���";
            this.Load += new System.EventHandler(this.frmStorageQty_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStorageQty_KeyDown);
            this.Controls.SetChildIndex(this.cbKind, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rgOption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbKind.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbKind;
    }
}
