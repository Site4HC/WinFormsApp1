namespace WinFormsApp1
{
    partial class frmOsoba
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
            dataGridView1 = new DataGridView();
            txtFind = new TextBox();
            Find = new Label();
            btnFind = new Button();
            btnFilter = new Button();
            groupBox1 = new GroupBox();
            btnFilterCancel = new Button();
            btnFilterOk = new Button();
            cmbSex = new ComboBox();
            cmbAdres = new ComboBox();
            dtpDNOTo = new DateTimePicker();
            dtpDNOFrom = new DateTimePicker();
            txtReitTo = new TextBox();
            txtReitFrom = new TextBox();
            txtPIP = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 233);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(561, 12);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(100, 23);
            txtFind.TabIndex = 1;
            txtFind.Visible = false;
            txtFind.TextChanged += txtFind_TextChanged;
            // 
            // Find
            // 
            Find.AutoSize = true;
            Find.Location = new Point(525, 15);
            Find.Name = "Find";
            Find.Size = new Size(30, 15);
            Find.TabIndex = 2;
            Find.Text = "Find";
            Find.Visible = false;
            Find.Click += Find_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(56, 12);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(137, 12);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFilterCancel);
            groupBox1.Controls.Add(btnFilterOk);
            groupBox1.Controls.Add(cmbSex);
            groupBox1.Controls.Add(cmbAdres);
            groupBox1.Controls.Add(dtpDNOTo);
            groupBox1.Controls.Add(dtpDNOFrom);
            groupBox1.Controls.Add(txtReitTo);
            groupBox1.Controls.Add(txtReitFrom);
            groupBox1.Controls.Add(txtPIP);
            groupBox1.Location = new Point(12, 307);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 129);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            groupBox1.Visible = false;
            // 
            // btnFilterCancel
            // 
            btnFilterCancel.Location = new Point(695, 85);
            btnFilterCancel.Name = "btnFilterCancel";
            btnFilterCancel.Size = new Size(75, 23);
            btnFilterCancel.TabIndex = 8;
            btnFilterCancel.Text = "Відміна";
            btnFilterCancel.UseVisualStyleBackColor = true;
            btnFilterCancel.Click += btnFilterCancel_Click;
            // 
            // btnFilterOk
            // 
            btnFilterOk.Location = new Point(695, 36);
            btnFilterOk.Name = "btnFilterOk";
            btnFilterOk.Size = new Size(75, 23);
            btnFilterOk.TabIndex = 7;
            btnFilterOk.Text = "Фільтр";
            btnFilterOk.UseVisualStyleBackColor = true;
            btnFilterOk.Click += btnFilterOk_Click;
            // 
            // cmbSex
            // 
            cmbSex.FormattingEnabled = true;
            cmbSex.Location = new Point(562, 85);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(121, 23);
            cmbSex.TabIndex = 6;
            // 
            // cmbAdres
            // 
            cmbAdres.FormattingEnabled = true;
            cmbAdres.Location = new Point(562, 36);
            cmbAdres.Name = "cmbAdres";
            cmbAdres.Size = new Size(121, 23);
            cmbAdres.TabIndex = 5;
            // 
            // dtpDNOTo
            // 
            dtpDNOTo.Location = new Point(343, 82);
            dtpDNOTo.Name = "dtpDNOTo";
            dtpDNOTo.Size = new Size(200, 23);
            dtpDNOTo.TabIndex = 4;
            // 
            // dtpDNOFrom
            // 
            dtpDNOFrom.Location = new Point(343, 36);
            dtpDNOFrom.Name = "dtpDNOFrom";
            dtpDNOFrom.Size = new Size(200, 23);
            dtpDNOFrom.TabIndex = 3;
            // 
            // txtReitTo
            // 
            txtReitTo.Location = new Point(172, 82);
            txtReitTo.Name = "txtReitTo";
            txtReitTo.Size = new Size(100, 23);
            txtReitTo.TabIndex = 2;
            // 
            // txtReitFrom
            // 
            txtReitFrom.Location = new Point(172, 36);
            txtReitFrom.Name = "txtReitFrom";
            txtReitFrom.Size = new Size(100, 23);
            txtReitFrom.TabIndex = 1;
            // 
            // txtPIP
            // 
            txtPIP.Location = new Point(19, 56);
            txtPIP.Name = "txtPIP";
            txtPIP.Size = new Size(100, 23);
            txtPIP.TabIndex = 0;
            // 
            // frmOsoba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnFilter);
            Controls.Add(btnFind);
            Controls.Add(Find);
            Controls.Add(txtFind);
            Controls.Add(dataGridView1);
            Name = "frmOsoba";
            Text = "frmOsoba";
            Load += frmOsoba_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtFind;
        private Label Find;
        private Button btnFind;
        private Button btnFilter;
        private GroupBox groupBox1;
        private TextBox txtReitTo;
        private TextBox txtReitFrom;
        private TextBox txtPIP;
        private Button btnFilterCancel;
        private Button btnFilterOk;
        private ComboBox cmbSex;
        private ComboBox cmbAdres;
        private DateTimePicker dtpDNOTo;
        private DateTimePicker dtpDNOFrom;
    }
}