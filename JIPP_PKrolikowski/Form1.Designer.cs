namespace JIPP_PKrolikowski
{
    partial class Form1
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelDataBase = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstNameEnter = new System.Windows.Forms.TextBox();
            this.textBoxLastNameEnter = new System.Windows.Forms.TextBox();
            this.buttonEnterNewPerson = new System.Windows.Forms.Button();
            this.dataGridViewDb = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleDbDataSet = new JIPP_PKrolikowski.PeopleDbDataSet();
            this.groupBoxPlaceForAnimation = new System.Windows.Forms.GroupBox();
            this.tableTableAdapter = new JIPP_PKrolikowski.PeopleDbDataSetTableAdapters.TableTableAdapter();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelDataBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelDataBase, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewDb, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxPlaceForAnimation, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelDataBase
            // 
            this.tableLayoutPanelDataBase.ColumnCount = 4;
            this.tableLayoutPanelDataBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDataBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDataBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDataBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDataBase.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelDataBase.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelDataBase.Controls.Add(this.textBoxFirstNameEnter, 1, 0);
            this.tableLayoutPanelDataBase.Controls.Add(this.textBoxLastNameEnter, 1, 1);
            this.tableLayoutPanelDataBase.Controls.Add(this.buttonEnterNewPerson, 1, 2);
            this.tableLayoutPanelDataBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDataBase.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelDataBase.Name = "tableLayoutPanelDataBase";
            this.tableLayoutPanelDataBase.RowCount = 4;
            this.tableLayoutPanelDataBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDataBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDataBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDataBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDataBase.Size = new System.Drawing.Size(394, 219);
            this.tableLayoutPanelDataBase.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // textBoxFirstNameEnter
            // 
            this.tableLayoutPanelDataBase.SetColumnSpan(this.textBoxFirstNameEnter, 2);
            this.textBoxFirstNameEnter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxFirstNameEnter.Location = new System.Drawing.Point(101, 31);
            this.textBoxFirstNameEnter.Name = "textBoxFirstNameEnter";
            this.textBoxFirstNameEnter.Size = new System.Drawing.Size(190, 20);
            this.textBoxFirstNameEnter.TabIndex = 3;
            // 
            // textBoxLastNameEnter
            // 
            this.tableLayoutPanelDataBase.SetColumnSpan(this.textBoxLastNameEnter, 2);
            this.textBoxLastNameEnter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxLastNameEnter.Location = new System.Drawing.Point(101, 85);
            this.textBoxLastNameEnter.Name = "textBoxLastNameEnter";
            this.textBoxLastNameEnter.Size = new System.Drawing.Size(190, 20);
            this.textBoxLastNameEnter.TabIndex = 4;
            // 
            // buttonEnterNewPerson
            // 
            this.tableLayoutPanelDataBase.SetColumnSpan(this.buttonEnterNewPerson, 2);
            this.buttonEnterNewPerson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEnterNewPerson.Location = new System.Drawing.Point(101, 136);
            this.buttonEnterNewPerson.Name = "buttonEnterNewPerson";
            this.buttonEnterNewPerson.Size = new System.Drawing.Size(190, 23);
            this.buttonEnterNewPerson.TabIndex = 0;
            this.buttonEnterNewPerson.Text = "Wprowadź nową osobę";
            this.buttonEnterNewPerson.UseVisualStyleBackColor = true;
            this.buttonEnterNewPerson.Click += new System.EventHandler(this.buttonEnterNewPerson_Click);
            // 
            // dataGridViewDb
            // 
            this.dataGridViewDb.AllowUserToAddRows = false;
            this.dataGridViewDb.AllowUserToDeleteRows = false;
            this.dataGridViewDb.AllowUserToOrderColumns = true;
            this.dataGridViewDb.AutoGenerateColumns = false;
            this.dataGridViewDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.forenameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn});
            this.dataGridViewDb.DataSource = this.tableBindingSource;
            this.dataGridViewDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDb.Location = new System.Drawing.Point(403, 3);
            this.dataGridViewDb.Name = "dataGridViewDb";
            this.dataGridViewDb.ReadOnly = true;
            this.dataGridViewDb.Size = new System.Drawing.Size(394, 219);
            this.dataGridViewDb.TabIndex = 1;
            this.dataGridViewDb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDb_CellClick);
            this.dataGridViewDb.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDb_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forenameDataGridViewTextBoxColumn
            // 
            this.forenameDataGridViewTextBoxColumn.DataPropertyName = "Forename";
            this.forenameDataGridViewTextBoxColumn.HeaderText = "Forename";
            this.forenameDataGridViewTextBoxColumn.Name = "forenameDataGridViewTextBoxColumn";
            this.forenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.peopleDbDataSet;
            // 
            // peopleDbDataSet
            // 
            this.peopleDbDataSet.DataSetName = "PeopleDbDataSet";
            this.peopleDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxPlaceForAnimation
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.groupBoxPlaceForAnimation, 2);
            this.groupBoxPlaceForAnimation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPlaceForAnimation.Location = new System.Drawing.Point(3, 228);
            this.groupBoxPlaceForAnimation.Name = "groupBoxPlaceForAnimation";
            this.groupBoxPlaceForAnimation.Size = new System.Drawing.Size(794, 219);
            this.groupBoxPlaceForAnimation.TabIndex = 2;
            this.groupBoxPlaceForAnimation.TabStop = false;
            this.groupBoxPlaceForAnimation.Text = "Miejsce na animacje";
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "Form1";
            this.Text = "Osobliwa baza danych";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelDataBase.ResumeLayout(false);
            this.tableLayoutPanelDataBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDataBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirstNameEnter;
        private System.Windows.Forms.TextBox textBoxLastNameEnter;
        private System.Windows.Forms.Button buttonEnterNewPerson;
        private System.Windows.Forms.DataGridView dataGridViewDb;
        private PeopleDbDataSet peopleDbDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private PeopleDbDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxPlaceForAnimation;
    }
}

