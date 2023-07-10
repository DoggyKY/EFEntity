using ClassLibrary1;

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
            components = new System.ComponentModel.Container();
            bsCompany = new BindingSource(components);
            button2 = new Button();
            bsActs = new BindingSource(components);
            dataGridView1 = new DataGridView();
            codeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subcodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mscompidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mscomptypDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mscompseqDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            effDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            feeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            networkaddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            bsaocs = new BindingSource(components);
            codeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsCompany).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsActs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsaocs).BeginInit();
            SuspendLayout();
            // 
            // bsCompany
            // 
            bsCompany.DataSource = typeof(EntitySrvr.Models.Company);
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(645, 90);
            button2.Name = "button2";
            button2.Size = new Size(250, 44);
            button2.TabIndex = 2;
            button2.Text = "Save Activities";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // bsActs
            // 
            bsActs.DataSource = typeof(EntitySrvr.Models.Activity);
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codeDataGridViewTextBoxColumn, subcodeDataGridViewTextBoxColumn, mscompidDataGridViewTextBoxColumn, mscomptypDataGridViewTextBoxColumn, mscompseqDataGridViewTextBoxColumn, dtDataGridViewTextBoxColumn, effDateDataGridViewTextBoxColumn, feeDataGridViewTextBoxColumn, networkaddressDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bsActs;
            dataGridView1.Location = new Point(12, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(972, 199);
            dataGridView1.TabIndex = 3;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn.HeaderText = "Code";
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // subcodeDataGridViewTextBoxColumn
            // 
            subcodeDataGridViewTextBoxColumn.DataPropertyName = "Subcode";
            subcodeDataGridViewTextBoxColumn.HeaderText = "Subcode";
            subcodeDataGridViewTextBoxColumn.Name = "subcodeDataGridViewTextBoxColumn";
            // 
            // mscompidDataGridViewTextBoxColumn
            // 
            mscompidDataGridViewTextBoxColumn.DataPropertyName = "Mscompid";
            mscompidDataGridViewTextBoxColumn.HeaderText = "Mscompid";
            mscompidDataGridViewTextBoxColumn.Name = "mscompidDataGridViewTextBoxColumn";
            // 
            // mscomptypDataGridViewTextBoxColumn
            // 
            mscomptypDataGridViewTextBoxColumn.DataPropertyName = "Mscomptyp";
            mscomptypDataGridViewTextBoxColumn.HeaderText = "Mscomptyp";
            mscomptypDataGridViewTextBoxColumn.Name = "mscomptypDataGridViewTextBoxColumn";
            // 
            // mscompseqDataGridViewTextBoxColumn
            // 
            mscompseqDataGridViewTextBoxColumn.DataPropertyName = "Mscompseq";
            mscompseqDataGridViewTextBoxColumn.HeaderText = "Mscompseq";
            mscompseqDataGridViewTextBoxColumn.Name = "mscompseqDataGridViewTextBoxColumn";
            // 
            // dtDataGridViewTextBoxColumn
            // 
            dtDataGridViewTextBoxColumn.DataPropertyName = "Dt";
            dtDataGridViewTextBoxColumn.HeaderText = "Dt";
            dtDataGridViewTextBoxColumn.Name = "dtDataGridViewTextBoxColumn";
            // 
            // effDateDataGridViewTextBoxColumn
            // 
            effDateDataGridViewTextBoxColumn.DataPropertyName = "EffDate";
            effDateDataGridViewTextBoxColumn.HeaderText = "EffDate";
            effDateDataGridViewTextBoxColumn.Name = "effDateDataGridViewTextBoxColumn";
            // 
            // feeDataGridViewTextBoxColumn
            // 
            feeDataGridViewTextBoxColumn.DataPropertyName = "Fee";
            feeDataGridViewTextBoxColumn.HeaderText = "Fee";
            feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            // 
            // networkaddressDataGridViewTextBoxColumn
            // 
            networkaddressDataGridViewTextBoxColumn.DataPropertyName = "Networkaddress";
            networkaddressDataGridViewTextBoxColumn.HeaderText = "Networkaddress";
            networkaddressDataGridViewTextBoxColumn.Name = "networkaddressDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bsCompany, "Name", true));
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(61, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(819, 33);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(373, 90);
            button1.Name = "button1";
            button1.Size = new Size(250, 44);
            button1.TabIndex = 5;
            button1.Text = "Save Company";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { codeDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn });
            dataGridView2.DataSource = bsaocs;
            dataGridView2.Location = new Point(12, 384);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(972, 199);
            dataGridView2.TabIndex = 6;
            // 
            // bsaocs
            // 
            bsaocs.DataSource = typeof(DataSet1.aocDataTable);
            // 
            // codeDataGridViewTextBoxColumn1
            // 
            codeDataGridViewTextBoxColumn1.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn1.HeaderText = "Code";
            codeDataGridViewTextBoxColumn1.Name = "codeDataGridViewTextBoxColumn1";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 92;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 622);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bsCompany).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsActs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsaocs).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridView dataGridView2;
        private BindingSource bsaocs;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}