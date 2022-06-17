
namespace ExeCRUD
{
    partial class Form3
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exeCRUDDataSet = new ExeCRUD.ExeCRUDDataSet();
            this.exeCRUDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exeCRUDDataSet1 = new ExeCRUD.ExeCRUDDataSet1();
            this.exeCRUDDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exeCRUDDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.exeCRUDDataSet2 = new ExeCRUD.ExeCRUDDataSet2();
            this.siswaBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siswaBTableAdapter = new ExeCRUD.ExeCRUDDataSet2TableAdapters.SiswaBTableAdapter();
            this.nISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nISDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.tTLDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.jKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siswaBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(320, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 223);
            this.dataGridView1.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(482, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 28;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 27;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(320, 347);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(133, 293);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(160, 22);
            this.tb5.TabIndex = 25;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(133, 249);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(160, 22);
            this.tb4.TabIndex = 24;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(133, 161);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(160, 22);
            this.tb2.TabIndex = 23;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(133, 114);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(160, 22);
            this.tb1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tanggal Lahir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nama";
            // 
            // txtNis
            // 
            this.txtNis.AutoSize = true;
            this.txtNis.Location = new System.Drawing.Point(18, 117);
            this.txtNis.Name = "txtNis";
            this.txtNis.Size = new System.Drawing.Size(30, 17);
            this.txtNis.TabIndex = 17;
            this.txtNis.Text = "NIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Kelas B";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 32;
            this.button1.Text = "Keluar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exeCRUDDataSet
            // 
            this.exeCRUDDataSet.DataSetName = "ExeCRUDDataSet";
            this.exeCRUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exeCRUDDataSetBindingSource
            // 
            this.exeCRUDDataSetBindingSource.DataSource = this.exeCRUDDataSet;
            this.exeCRUDDataSetBindingSource.Position = 0;
            // 
            // exeCRUDDataSet1
            // 
            this.exeCRUDDataSet1.DataSetName = "ExeCRUDDataSet1";
            this.exeCRUDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exeCRUDDataSet1BindingSource
            // 
            this.exeCRUDDataSet1BindingSource.DataSource = this.exeCRUDDataSet1;
            this.exeCRUDDataSet1BindingSource.Position = 0;
            // 
            // exeCRUDDataSet1BindingSource1
            // 
            this.exeCRUDDataSet1BindingSource1.DataSource = this.exeCRUDDataSet1;
            this.exeCRUDDataSet1BindingSource1.Position = 0;
            // 
            // exeCRUDDataSet2
            // 
            this.exeCRUDDataSet2.DataSetName = "ExeCRUDDataSet2";
            this.exeCRUDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siswaBBindingSource
            // 
            this.siswaBBindingSource.DataMember = "SiswaB";
            this.siswaBBindingSource.DataSource = this.exeCRUDDataSet2;
            // 
            // siswaBTableAdapter
            // 
            this.siswaBTableAdapter.ClearBeforeFill = true;
            // 
            // nISDataGridViewTextBoxColumn
            // 
            this.nISDataGridViewTextBoxColumn.DataPropertyName = "NIS";
            this.nISDataGridViewTextBoxColumn.HeaderText = "NIS";
            this.nISDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nISDataGridViewTextBoxColumn.Name = "nISDataGridViewTextBoxColumn";
            this.nISDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tTLDataGridViewTextBoxColumn
            // 
            this.tTLDataGridViewTextBoxColumn.DataPropertyName = "TTL";
            this.tTLDataGridViewTextBoxColumn.HeaderText = "TTL";
            this.tTLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tTLDataGridViewTextBoxColumn.Name = "tTLDataGridViewTextBoxColumn";
            this.tTLDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // jKDataGridViewTextBoxColumn
            // 
            this.jKDataGridViewTextBoxColumn.DataPropertyName = "JK";
            this.jKDataGridViewTextBoxColumn.HeaderText = "JK";
            this.jKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jKDataGridViewTextBoxColumn.Name = "jKDataGridViewTextBoxColumn";
            this.jKDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNis);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtNis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource exeCRUDDataSetBindingSource;
        private ExeCRUDDataSet exeCRUDDataSet;
        private System.Windows.Forms.BindingSource exeCRUDDataSet1BindingSource1;
        private ExeCRUDDataSet1 exeCRUDDataSet1;
        private System.Windows.Forms.BindingSource exeCRUDDataSet1BindingSource;
        private ExeCRUDDataSet2 exeCRUDDataSet2;
        private System.Windows.Forms.BindingSource siswaBBindingSource;
        private ExeCRUDDataSet2TableAdapters.SiswaBTableAdapter siswaBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jKDataGridViewTextBoxColumn;
    }
}