namespace ComputerComponentStore
{
    partial class FormManagerComponent
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
            this.btnOperation = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelSearchByComponent = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelComponentEdit = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dgvComponentList = new System.Windows.Forms.DataGridView();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOperation
            // 
            this.btnOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOperation.Location = new System.Drawing.Point(204, 2);
            this.btnOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(195, 44);
            this.btnOperation.TabIndex = 0;
            this.btnOperation.Text = "Operation";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRefresh.Location = new System.Drawing.Point(3, 2);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(195, 44);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelSearchByComponent
            // 
            this.labelSearchByComponent.AutoSize = true;
            this.labelSearchByComponent.BackColor = System.Drawing.SystemColors.Control;
            this.labelSearchByComponent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSearchByComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchByComponent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSearchByComponent.Location = new System.Drawing.Point(562, 28);
            this.labelSearchByComponent.Name = "labelSearchByComponent";
            this.labelSearchByComponent.Size = new System.Drawing.Size(554, 20);
            this.labelSearchByComponent.TabIndex = 2;
            this.labelSearchByComponent.Text = "Search by Component";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(562, 50);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(200, 26);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // panelComponentEdit
            // 
            this.panelComponentEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelComponentEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComponentEdit.Location = new System.Drawing.Point(1128, 107);
            this.panelComponentEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelComponentEdit.Name = "panelComponentEdit";
            this.panelComponentEdit.Size = new System.Drawing.Size(402, 670);
            this.panelComponentEdit.TabIndex = 4;
            this.panelComponentEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.panelComponentEdit_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Component List";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(3, 2);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(66, 42);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dgvComponentList
            // 
            this.dgvComponentList.AllowUserToAddRows = false;
            this.dgvComponentList.AllowUserToDeleteRows = false;
            this.dgvComponentList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvComponentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial,
            this.ComponentId,
            this.Component,
            this.Model,
            this.Quantity,
            this.UnitPrice});
            this.dgvComponentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComponentList.Location = new System.Drawing.Point(3, 107);
            this.dgvComponentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvComponentList.Name = "dgvComponentList";
            this.dgvComponentList.ReadOnly = true;
            this.dgvComponentList.RowHeadersWidth = 51;
            this.dgvComponentList.RowTemplate.Height = 28;
            this.dgvComponentList.Size = new System.Drawing.Size(1119, 670);
            this.dgvComponentList.TabIndex = 0;
            // 
            // Serial
            // 
            this.Serial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Serial.DataPropertyName = "Serial";
            this.Serial.HeaderText = "Serial";
            this.Serial.MinimumWidth = 6;
            this.Serial.Name = "Serial";
            this.Serial.ReadOnly = true;
            this.Serial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Serial.ToolTipText = "Serial Number";
            // 
            // ComponentId
            // 
            this.ComponentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComponentId.DataPropertyName = "Id";
            this.ComponentId.HeaderText = "Id";
            this.ComponentId.MinimumWidth = 6;
            this.ComponentId.Name = "ComponentId";
            this.ComponentId.ReadOnly = true;
            this.ComponentId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ComponentId.ToolTipText = "Component ID";
            // 
            // Component
            // 
            this.Component.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Component.DataPropertyName = "Components";
            this.Component.HeaderText = "Component";
            this.Component.MinimumWidth = 6;
            this.Component.Name = "Component";
            this.Component.ReadOnly = true;
            this.Component.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Component.ToolTipText = "Component Name";
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Model.ToolTipText = "Component Model";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.ToolTipText = "Component Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.ToolTipText = "Price";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.40426F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.59575F));
            this.tableLayoutPanel1.Controls.Add(this.dgvComponentList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelComponentEdit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.48315F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.51685F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1533, 779);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelSearchByComponent, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonBack, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSearch, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1119, 97);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonRefresh, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOperation, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1128, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(402, 97);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // FormManagerComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 859);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormManagerComponent";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 20);
            this.Text = "Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManagerComponent_FormClosed);
            this.Load += new System.EventHandler(this.FormManagerComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelSearchByComponent;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelComponentEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dgvComponentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

