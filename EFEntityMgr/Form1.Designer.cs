namespace EFEntityMgr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsCompany = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.bsActs = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mscompidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mscomptypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mscompseqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.networkaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsCompany
            // 
            this.bsCompany.DataSource = typeof(EntitySrvr.Models.Company);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(645, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save Activities";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bsActs
            // 
            this.bsActs.DataSource = typeof(EntitySrvr.Models.Activity);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.subcodeDataGridViewTextBoxColumn,
            this.mscompidDataGridViewTextBoxColumn,
            this.mscomptypDataGridViewTextBoxColumn,
            this.mscompseqDataGridViewTextBoxColumn,
            this.dtDataGridViewTextBoxColumn,
            this.effDateDataGridViewTextBoxColumn,
            this.feeDataGridViewTextBoxColumn,
            this.networkaddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsActs;
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(972, 341);
            this.dataGridView1.TabIndex = 3;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // subcodeDataGridViewTextBoxColumn
            // 
            this.subcodeDataGridViewTextBoxColumn.DataPropertyName = "Subcode";
            this.subcodeDataGridViewTextBoxColumn.HeaderText = "Subcode";
            this.subcodeDataGridViewTextBoxColumn.Name = "subcodeDataGridViewTextBoxColumn";
            // 
            // mscompidDataGridViewTextBoxColumn
            // 
            this.mscompidDataGridViewTextBoxColumn.DataPropertyName = "Mscompid";
            this.mscompidDataGridViewTextBoxColumn.HeaderText = "Mscompid";
            this.mscompidDataGridViewTextBoxColumn.Name = "mscompidDataGridViewTextBoxColumn";
            // 
            // mscomptypDataGridViewTextBoxColumn
            // 
            this.mscomptypDataGridViewTextBoxColumn.DataPropertyName = "Mscomptyp";
            this.mscomptypDataGridViewTextBoxColumn.HeaderText = "Mscomptyp";
            this.mscomptypDataGridViewTextBoxColumn.Name = "mscomptypDataGridViewTextBoxColumn";
            // 
            // mscompseqDataGridViewTextBoxColumn
            // 
            this.mscompseqDataGridViewTextBoxColumn.DataPropertyName = "Mscompseq";
            this.mscompseqDataGridViewTextBoxColumn.HeaderText = "Mscompseq";
            this.mscompseqDataGridViewTextBoxColumn.Name = "mscompseqDataGridViewTextBoxColumn";
            // 
            // dtDataGridViewTextBoxColumn
            // 
            this.dtDataGridViewTextBoxColumn.DataPropertyName = "Dt";
            this.dtDataGridViewTextBoxColumn.HeaderText = "Dt";
            this.dtDataGridViewTextBoxColumn.Name = "dtDataGridViewTextBoxColumn";
            // 
            // effDateDataGridViewTextBoxColumn
            // 
            this.effDateDataGridViewTextBoxColumn.DataPropertyName = "EffDate";
            this.effDateDataGridViewTextBoxColumn.HeaderText = "EffDate";
            this.effDateDataGridViewTextBoxColumn.Name = "effDateDataGridViewTextBoxColumn";
            // 
            // feeDataGridViewTextBoxColumn
            // 
            this.feeDataGridViewTextBoxColumn.DataPropertyName = "Fee";
            this.feeDataGridViewTextBoxColumn.HeaderText = "Fee";
            this.feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            // 
            // networkaddressDataGridViewTextBoxColumn
            // 
            this.networkaddressDataGridViewTextBoxColumn.DataPropertyName = "Networkaddress";
            this.networkaddressDataGridViewTextBoxColumn.HeaderText = "Networkaddress";
            this.networkaddressDataGridViewTextBoxColumn.Name = "networkaddressDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCompany, "Name", true));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(61, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(819, 33);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(373, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save Company";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource bsCompany;
        private Button button2;
        private BindingSource bsActs;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mscompidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mscomptypDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mscompseqDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn effDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn networkaddressDataGridViewTextBoxColumn;
        private TextBox textBox1;
        private Button button1;
    }
}