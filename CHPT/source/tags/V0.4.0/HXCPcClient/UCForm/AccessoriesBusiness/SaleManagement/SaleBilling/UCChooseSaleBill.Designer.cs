﻿namespace HXCPcClient.UCForm.AccessoriesBusiness.SaleManagement.SaleBilling
{
    partial class UCChooseSaleBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCChooseSaleBill));
            this.txtparts_type = new ServiceStationClient.ComponentUI.TextBox.TextChooser();
            this.txtparts_name = new ServiceStationClient.ComponentUI.TextBox.TextChooser();
            this.txtparts_code = new ServiceStationClient.ComponentUI.TextBox.TextChooser();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtorder_num = new ServiceStationClient.ComponentUI.TextBoxEx();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeStart = new ServiceStationClient.ComponentUI.DateTimePickerEx();
            this.dateTimeEnd = new ServiceStationClient.ComponentUI.DateTimePickerEx();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlhandle = new ServiceStationClient.ComponentUI.ComboBoxEx(this.components);
            this.ddloperator = new ServiceStationClient.ComponentUI.ComboBoxEx(this.components);
            this.ddlorg_id = new ServiceStationClient.ComponentUI.ComboBoxEx(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgPurchaseOrder = new ServiceStationClient.ComponentUI.DataGridViewEx(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.order_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handle_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operator_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAccessoriesDetail = new ServiceStationClient.ComponentUI.DataGridViewEx(this.components);
            this.btnSearch = new ServiceStationClient.ComponentUI.ButtonEx();
            this.btnClear = new ServiceStationClient.ComponentUI.ButtonEx();
            this.btnColse = new ServiceStationClient.ComponentUI.ButtonEx();
            this.btnOK = new ServiceStationClient.ComponentUI.ButtonEx();
            this.btnNotCheck = new ServiceStationClient.ComponentUI.ButtonEx();
            this.btnAllCheck = new ServiceStationClient.ComponentUI.ButtonEx();
            this.sale_billing_parts_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_billing_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parts_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parts_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parts_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawing_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax_prices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_counts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorem_together = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finish_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surplus_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrival_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_factory_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccessoriesDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.btnColse);
            this.pnlContainer.Controls.Add(this.btnOK);
            this.pnlContainer.Controls.Add(this.btnNotCheck);
            this.pnlContainer.Controls.Add(this.btnAllCheck);
            this.pnlContainer.Controls.Add(this.btnSearch);
            this.pnlContainer.Controls.Add(this.btnClear);
            this.pnlContainer.Controls.Add(this.dgAccessoriesDetail);
            this.pnlContainer.Controls.Add(this.dgPurchaseOrder);
            this.pnlContainer.Controls.Add(this.txtparts_type);
            this.pnlContainer.Controls.Add(this.txtparts_name);
            this.pnlContainer.Controls.Add(this.txtparts_code);
            this.pnlContainer.Controls.Add(this.label4);
            this.pnlContainer.Controls.Add(this.label3);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Controls.Add(this.txtorder_num);
            this.pnlContainer.Controls.Add(this.label5);
            this.pnlContainer.Controls.Add(this.dateTimeStart);
            this.pnlContainer.Controls.Add(this.dateTimeEnd);
            this.pnlContainer.Controls.Add(this.label7);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.ddlhandle);
            this.pnlContainer.Controls.Add(this.ddloperator);
            this.pnlContainer.Controls.Add(this.ddlorg_id);
            this.pnlContainer.Controls.Add(this.label9);
            this.pnlContainer.Controls.Add(this.label8);
            this.pnlContainer.Controls.Add(this.label6);
            this.pnlContainer.Size = new System.Drawing.Size(866, 485);
            // 
            // txtparts_type
            // 
            this.txtparts_type.ChooserTypeImage = ServiceStationClient.ComponentUI.TextBox.ChooserType.Default;
            this.txtparts_type.Location = new System.Drawing.Point(578, 71);
            this.txtparts_type.Name = "txtparts_type";
            this.txtparts_type.ReadOnly = false;
            this.txtparts_type.Size = new System.Drawing.Size(144, 24);
            this.txtparts_type.TabIndex = 95;
            this.txtparts_type.ToolTipTitle = "";
            this.txtparts_type.ChooserClick += new System.EventHandler(this.txtparts_type_ChooserClick);
            // 
            // txtparts_name
            // 
            this.txtparts_name.ChooserTypeImage = ServiceStationClient.ComponentUI.TextBox.ChooserType.Default;
            this.txtparts_name.Location = new System.Drawing.Point(326, 71);
            this.txtparts_name.Name = "txtparts_name";
            this.txtparts_name.ReadOnly = false;
            this.txtparts_name.Size = new System.Drawing.Size(143, 24);
            this.txtparts_name.TabIndex = 94;
            this.txtparts_name.ToolTipTitle = "";
            this.txtparts_name.ChooserClick += new System.EventHandler(this.txtparts_name_ChooserClick);
            // 
            // txtparts_code
            // 
            this.txtparts_code.ChooserTypeImage = ServiceStationClient.ComponentUI.TextBox.ChooserType.Default;
            this.txtparts_code.Location = new System.Drawing.Point(96, 71);
            this.txtparts_code.Name = "txtparts_code";
            this.txtparts_code.ReadOnly = false;
            this.txtparts_code.Size = new System.Drawing.Size(146, 24);
            this.txtparts_code.TabIndex = 93;
            this.txtparts_code.ToolTipTitle = "";
            this.txtparts_code.ChooserClick += new System.EventHandler(this.txtparts_code_ChooserClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 92;
            this.label4.Text = "配件类别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 91;
            this.label3.Text = "配件名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 90;
            this.label2.Text = "配件编码：";
            // 
            // txtorder_num
            // 
            this.txtorder_num.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtorder_num.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtorder_num.BackColor = System.Drawing.Color.Transparent;
            this.txtorder_num.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtorder_num.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(208)))), ((int)(((byte)(226)))));
            this.txtorder_num.ForeImage = null;
            this.txtorder_num.InputtingVerifyCondition = null;
            this.txtorder_num.Location = new System.Drawing.Point(578, 11);
            this.txtorder_num.MaxLengh = 32767;
            this.txtorder_num.Multiline = false;
            this.txtorder_num.Name = "txtorder_num";
            this.txtorder_num.Radius = 3;
            this.txtorder_num.ReadOnly = false;
            this.txtorder_num.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.txtorder_num.ShowError = false;
            this.txtorder_num.Size = new System.Drawing.Size(144, 23);
            this.txtorder_num.TabIndex = 89;
            this.txtorder_num.UseSystemPasswordChar = false;
            this.txtorder_num.Value = "";
            this.txtorder_num.VerifyCondition = null;
            this.txtorder_num.VerifyType = null;
            this.txtorder_num.VerifyTypeName = null;
            this.txtorder_num.WaterMark = null;
            this.txtorder_num.WaterMarkColor = System.Drawing.Color.Silver;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 88;
            this.label5.Text = "采购开单号：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(98, 13);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.ShowFormat = "yyyy年MM月dd日";
            this.dateTimeStart.Size = new System.Drawing.Size(144, 21);
            this.dateTimeStart.TabIndex = 87;
            this.dateTimeStart.Value = new System.DateTime(2014, 9, 15, 20, 17, 9, 878);
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(326, 13);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.ShowFormat = "yyyy年MM月dd日";
            this.dateTimeEnd.Size = new System.Drawing.Size(143, 23);
            this.dateTimeEnd.TabIndex = 86;
            this.dateTimeEnd.Value = new System.DateTime(2014, 9, 15, 20, 17, 9, 878);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 84;
            this.label7.Text = "单据日期：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 85;
            this.label1.Text = "至";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ddlhandle
            // 
            this.ddlhandle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddlhandle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlhandle.FormattingEnabled = true;
            this.ddlhandle.Location = new System.Drawing.Point(326, 42);
            this.ddlhandle.Name = "ddlhandle";
            this.ddlhandle.Size = new System.Drawing.Size(143, 22);
            this.ddlhandle.TabIndex = 81;
            // 
            // ddloperator
            // 
            this.ddloperator.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddloperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddloperator.FormattingEnabled = true;
            this.ddloperator.Location = new System.Drawing.Point(578, 42);
            this.ddloperator.Name = "ddloperator";
            this.ddloperator.Size = new System.Drawing.Size(144, 22);
            this.ddloperator.TabIndex = 80;
            // 
            // ddlorg_id
            // 
            this.ddlorg_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddlorg_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlorg_id.FormattingEnabled = true;
            this.ddlorg_id.Location = new System.Drawing.Point(98, 42);
            this.ddlorg_id.Name = "ddlorg_id";
            this.ddlorg_id.Size = new System.Drawing.Size(144, 22);
            this.ddlorg_id.TabIndex = 79;
            this.ddlorg_id.SelectedIndexChanged += new System.EventHandler(this.ddlorg_id_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(519, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 78;
            this.label9.Text = "操作人：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 77;
            this.label8.Text = "经办人：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 76;
            this.label6.Text = "部门：";
            // 
            // dgPurchaseOrder
            // 
            this.dgPurchaseOrder.AllowUserToAddRows = false;
            this.dgPurchaseOrder.AllowUserToDeleteRows = false;
            this.dgPurchaseOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgPurchaseOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgPurchaseOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPurchaseOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgPurchaseOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPurchaseOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPurchaseOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colCheck,
            this.order_name,
            this.order_type_name,
            this.order_num,
            this.order_date,
            this.money,
            this.org_name,
            this.handle_name,
            this.operator_name,
            this.remark});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPurchaseOrder.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgPurchaseOrder.EnableHeadersVisualStyles = false;
            this.dgPurchaseOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.dgPurchaseOrder.IsCheck = true;
            this.dgPurchaseOrder.Location = new System.Drawing.Point(19, 110);
            this.dgPurchaseOrder.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.dgPurchaseOrder.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("dgPurchaseOrder.MergeColumnNames")));
            this.dgPurchaseOrder.MultiSelect = false;
            this.dgPurchaseOrder.Name = "dgPurchaseOrder";
            this.dgPurchaseOrder.ReadOnly = true;
            this.dgPurchaseOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.dgPurchaseOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgPurchaseOrder.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgPurchaseOrder.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgPurchaseOrder.RowTemplate.Height = 23;
            this.dgPurchaseOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPurchaseOrder.ShowCheckBox = true;
            this.dgPurchaseOrder.Size = new System.Drawing.Size(824, 168);
            this.dgPurchaseOrder.TabIndex = 96;
            this.dgPurchaseOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPurchaseOrder_CellClick);
            this.dgPurchaseOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPurchaseOrder_CellContentClick);
            this.dgPurchaseOrder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgPurchaseOrder_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "sale_billing_id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // colCheck
            // 
            this.colCheck.HeaderText = "";
            this.colCheck.MinimumWidth = 25;
            this.colCheck.Name = "colCheck";
            this.colCheck.ReadOnly = true;
            this.colCheck.Width = 25;
            // 
            // order_name
            // 
            this.order_name.HeaderText = "单据名称";
            this.order_name.Name = "order_name";
            this.order_name.ReadOnly = true;
            // 
            // order_type_name
            // 
            this.order_type_name.DataPropertyName = "order_type_name";
            this.order_type_name.HeaderText = "单据类型";
            this.order_type_name.Name = "order_type_name";
            this.order_type_name.ReadOnly = true;
            // 
            // order_num
            // 
            this.order_num.DataPropertyName = "order_num";
            this.order_num.HeaderText = "单据号码";
            this.order_num.MinimumWidth = 180;
            this.order_num.Name = "order_num";
            this.order_num.ReadOnly = true;
            this.order_num.Width = 180;
            // 
            // order_date
            // 
            this.order_date.DataPropertyName = "order_date";
            this.order_date.HeaderText = "单据日期";
            this.order_date.Name = "order_date";
            this.order_date.ReadOnly = true;
            // 
            // money
            // 
            this.money.HeaderText = "金额";
            this.money.Name = "money";
            this.money.ReadOnly = true;
            // 
            // org_name
            // 
            this.org_name.DataPropertyName = "org_name";
            this.org_name.HeaderText = "部门";
            this.org_name.Name = "org_name";
            this.org_name.ReadOnly = true;
            // 
            // handle_name
            // 
            this.handle_name.DataPropertyName = "handle_name";
            this.handle_name.HeaderText = "经办人";
            this.handle_name.Name = "handle_name";
            this.handle_name.ReadOnly = true;
            // 
            // operator_name
            // 
            this.operator_name.DataPropertyName = "operator_name";
            this.operator_name.HeaderText = "操作人";
            this.operator_name.Name = "operator_name";
            this.operator_name.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "备注";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            // 
            // dgAccessoriesDetail
            // 
            this.dgAccessoriesDetail.AllowUserToAddRows = false;
            this.dgAccessoriesDetail.AllowUserToDeleteRows = false;
            this.dgAccessoriesDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgAccessoriesDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAccessoriesDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAccessoriesDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgAccessoriesDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAccessoriesDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgAccessoriesDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccessoriesDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sale_billing_parts_id,
            this.sale_billing_id,
            this.colDetailCheck,
            this.parts_id,
            this.parts_code,
            this.parts_name,
            this.drawing_num,
            this.unit_name,
            this.business_price,
            this.tax_prices,
            this.business_counts,
            this.valorem_together,
            this.finish_count,
            this.surplus_count,
            this.arrival_date,
            this.Column5,
            this.Column6,
            this.car_factory_code});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAccessoriesDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgAccessoriesDetail.EnableHeadersVisualStyles = false;
            this.dgAccessoriesDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.dgAccessoriesDetail.IsCheck = true;
            this.dgAccessoriesDetail.Location = new System.Drawing.Point(19, 284);
            this.dgAccessoriesDetail.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.dgAccessoriesDetail.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("dgAccessoriesDetail.MergeColumnNames")));
            this.dgAccessoriesDetail.MultiSelect = false;
            this.dgAccessoriesDetail.Name = "dgAccessoriesDetail";
            this.dgAccessoriesDetail.ReadOnly = true;
            this.dgAccessoriesDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.dgAccessoriesDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgAccessoriesDetail.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgAccessoriesDetail.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgAccessoriesDetail.RowTemplate.Height = 23;
            this.dgAccessoriesDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccessoriesDetail.ShowCheckBox = true;
            this.dgAccessoriesDetail.Size = new System.Drawing.Size(824, 154);
            this.dgAccessoriesDetail.TabIndex = 97;
            this.dgAccessoriesDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccessoriesDetail_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Caption = "查询";
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.DownImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.DownImage")));
            this.btnSearch.Location = new System.Drawing.Point(783, 73);
            this.btnSearch.MoveImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.MoveImage")));
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.NormalImage")));
            this.btnSearch.Size = new System.Drawing.Size(60, 26);
            this.btnSearch.TabIndex = 103;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Caption = "清除";
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.DownImage = ((System.Drawing.Image)(resources.GetObject("btnClear.DownImage")));
            this.btnClear.Location = new System.Drawing.Point(783, 42);
            this.btnClear.MoveImage = ((System.Drawing.Image)(resources.GetObject("btnClear.MoveImage")));
            this.btnClear.Name = "btnClear";
            this.btnClear.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnClear.NormalImage")));
            this.btnClear.Size = new System.Drawing.Size(60, 26);
            this.btnClear.TabIndex = 102;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnColse
            // 
            this.btnColse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColse.BackgroundImage")));
            this.btnColse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColse.Caption = "关闭";
            this.btnColse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnColse.DownImage = ((System.Drawing.Image)(resources.GetObject("btnColse.DownImage")));
            this.btnColse.Location = new System.Drawing.Point(784, 450);
            this.btnColse.MoveImage = ((System.Drawing.Image)(resources.GetObject("btnColse.MoveImage")));
            this.btnColse.Name = "btnColse";
            this.btnColse.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnColse.NormalImage")));
            this.btnColse.Size = new System.Drawing.Size(60, 26);
            this.btnColse.TabIndex = 107;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Caption = "确定";
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOK.DownImage = ((System.Drawing.Image)(resources.GetObject("btnOK.DownImage")));
            this.btnOK.Location = new System.Drawing.Point(717, 450);
            this.btnOK.MoveImage = ((System.Drawing.Image)(resources.GetObject("btnOK.MoveImage")));
            this.btnOK.Name = "btnOK";
            this.btnOK.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnOK.NormalImage")));
            this.btnOK.Size = new System.Drawing.Size(60, 26);
            this.btnOK.TabIndex = 106;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnNotCheck
            // 
            this.btnNotCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotCheck.BackgroundImage")));
            this.btnNotCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotCheck.Caption = "反选";
            this.btnNotCheck.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNotCheck.DownImage = ((System.Drawing.Image)(resources.GetObject("btnNotCheck.DownImage")));
            this.btnNotCheck.Location = new System.Drawing.Point(613, 450);
            this.btnNotCheck.MoveImage = ((System.Drawing.Image)(resources.GetObject("btnNotCheck.MoveImage")));
            this.btnNotCheck.Name = "btnNotCheck";
            this.btnNotCheck.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnNotCheck.NormalImage")));
            this.btnNotCheck.Size = new System.Drawing.Size(60, 26);
            this.btnNotCheck.TabIndex = 105;
            this.btnNotCheck.Click += new System.EventHandler(this.btnNotCheck_Click);
            // 
            // btnAllCheck
            // 
            this.btnAllCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAllCheck.BackgroundImage")));
            this.btnAllCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllCheck.Caption = "全选";
            this.btnAllCheck.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAllCheck.DownImage = ((System.Drawing.Image)(resources.GetObject("btnAllCheck.DownImage")));
            this.btnAllCheck.Location = new System.Drawing.Point(546, 450);
            this.btnAllCheck.MoveImage = ((System.Drawing.Image)(resources.GetObject("btnAllCheck.MoveImage")));
            this.btnAllCheck.Name = "btnAllCheck";
            this.btnAllCheck.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnAllCheck.NormalImage")));
            this.btnAllCheck.Size = new System.Drawing.Size(60, 26);
            this.btnAllCheck.TabIndex = 104;
            this.btnAllCheck.Click += new System.EventHandler(this.btnAllCheck_Click);
            // 
            // sale_billing_parts_id
            // 
            this.sale_billing_parts_id.DataPropertyName = "sale_billing_parts_id";
            this.sale_billing_parts_id.HeaderText = "sale_billing_parts_id";
            this.sale_billing_parts_id.Name = "sale_billing_parts_id";
            this.sale_billing_parts_id.ReadOnly = true;
            this.sale_billing_parts_id.Visible = false;
            // 
            // sale_billing_id
            // 
            this.sale_billing_id.DataPropertyName = "sale_billing_id";
            this.sale_billing_id.HeaderText = "sale_billing_id";
            this.sale_billing_id.Name = "sale_billing_id";
            this.sale_billing_id.ReadOnly = true;
            this.sale_billing_id.Visible = false;
            // 
            // colDetailCheck
            // 
            this.colDetailCheck.HeaderText = "";
            this.colDetailCheck.MinimumWidth = 25;
            this.colDetailCheck.Name = "colDetailCheck";
            this.colDetailCheck.ReadOnly = true;
            this.colDetailCheck.Width = 25;
            // 
            // parts_id
            // 
            this.parts_id.DataPropertyName = "parts_id";
            this.parts_id.HeaderText = "配件ID";
            this.parts_id.Name = "parts_id";
            this.parts_id.ReadOnly = true;
            this.parts_id.Visible = false;
            // 
            // parts_code
            // 
            this.parts_code.DataPropertyName = "parts_code";
            this.parts_code.HeaderText = "配件编码";
            this.parts_code.Name = "parts_code";
            this.parts_code.ReadOnly = true;
            // 
            // parts_name
            // 
            this.parts_name.DataPropertyName = "parts_name";
            this.parts_name.HeaderText = "配件名称";
            this.parts_name.Name = "parts_name";
            this.parts_name.ReadOnly = true;
            // 
            // drawing_num
            // 
            this.drawing_num.DataPropertyName = "drawing_num";
            this.drawing_num.HeaderText = "图号";
            this.drawing_num.Name = "drawing_num";
            this.drawing_num.ReadOnly = true;
            // 
            // unit_name
            // 
            this.unit_name.DataPropertyName = "unit_name";
            this.unit_name.HeaderText = "单位";
            this.unit_name.Name = "unit_name";
            this.unit_name.ReadOnly = true;
            this.unit_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // business_price
            // 
            this.business_price.DataPropertyName = "business_price";
            this.business_price.HeaderText = "单价";
            this.business_price.Name = "business_price";
            this.business_price.ReadOnly = true;
            // 
            // tax_prices
            // 
            this.tax_prices.DataPropertyName = "tax_prices";
            this.tax_prices.HeaderText = "含税单价";
            this.tax_prices.Name = "tax_prices";
            this.tax_prices.ReadOnly = true;
            // 
            // business_counts
            // 
            this.business_counts.DataPropertyName = "business_counts";
            this.business_counts.HeaderText = "数量";
            this.business_counts.Name = "business_counts";
            this.business_counts.ReadOnly = true;
            // 
            // valorem_together
            // 
            this.valorem_together.DataPropertyName = "valorem_together";
            this.valorem_together.HeaderText = "金额";
            this.valorem_together.Name = "valorem_together";
            this.valorem_together.ReadOnly = true;
            // 
            // finish_count
            // 
            this.finish_count.DataPropertyName = "finish_count";
            this.finish_count.HeaderText = "已引用数量";
            this.finish_count.Name = "finish_count";
            this.finish_count.ReadOnly = true;
            // 
            // surplus_count
            // 
            this.surplus_count.DataPropertyName = "surplus_count";
            this.surplus_count.HeaderText = "剩余数量";
            this.surplus_count.Name = "surplus_count";
            this.surplus_count.ReadOnly = true;
            // 
            // arrival_date
            // 
            this.arrival_date.DataPropertyName = "arrival_date";
            this.arrival_date.HeaderText = "到货日期";
            this.arrival_date.Name = "arrival_date";
            this.arrival_date.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "辅助单位";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "辅助数量";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // car_factory_code
            // 
            this.car_factory_code.DataPropertyName = "car_factory_code";
            this.car_factory_code.HeaderText = "厂商编码";
            this.car_factory_code.Name = "car_factory_code";
            this.car_factory_code.ReadOnly = true;
            // 
            // UCChooseSaleBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 518);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UCChooseSaleBill";
            this.Text = "导入销售开单";
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccessoriesDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ServiceStationClient.ComponentUI.TextBox.TextChooser txtparts_type;
        private ServiceStationClient.ComponentUI.TextBox.TextChooser txtparts_name;
        private ServiceStationClient.ComponentUI.TextBox.TextChooser txtparts_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ServiceStationClient.ComponentUI.TextBoxEx txtorder_num;
        private System.Windows.Forms.Label label5;
        private ServiceStationClient.ComponentUI.DateTimePickerEx dateTimeStart;
        private ServiceStationClient.ComponentUI.DateTimePickerEx dateTimeEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private ServiceStationClient.ComponentUI.ComboBoxEx ddlhandle;
        private ServiceStationClient.ComponentUI.ComboBoxEx ddloperator;
        private ServiceStationClient.ComponentUI.ComboBoxEx ddlorg_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private ServiceStationClient.ComponentUI.DataGridViewEx dgPurchaseOrder;
        private ServiceStationClient.ComponentUI.DataGridViewEx dgAccessoriesDetail;
        private ServiceStationClient.ComponentUI.ButtonEx btnSearch;
        private ServiceStationClient.ComponentUI.ButtonEx btnClear;
        private ServiceStationClient.ComponentUI.ButtonEx btnColse;
        private ServiceStationClient.ComponentUI.ButtonEx btnOK;
        private ServiceStationClient.ComponentUI.ButtonEx btnNotCheck;
        private ServiceStationClient.ComponentUI.ButtonEx btnAllCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn org_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn handle_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn operator_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_billing_parts_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_billing_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDetailCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn parts_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn parts_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn parts_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawing_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax_prices;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_counts;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorem_together;
        private System.Windows.Forms.DataGridViewTextBoxColumn finish_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn surplus_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrival_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_factory_code;
    }
}