namespace Entity
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
            dataGridView1 = new DataGridView();
            cityIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryCodeNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            buttonCreate = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonSelect = new Button();
            textBoxCreate = new TextBox();
            textBoxSelect = new TextBox();
            comboBoxCreate = new ComboBox();
            countryBindingSource = new BindingSource(components);
            countryBindingSource1 = new BindingSource(components);
            countryBindingSource2 = new BindingSource(components);
            comboBoxDelete = new ComboBox();
            comboBoxUpdate = new ComboBox();
            textBoxUpdate = new TextBox();
            comboBoxUpdateCountry = new ComboBox();
            buttonSupprimerSelection = new Button();
            buttonIndex = new Button();
            label1 = new Label();
            textBoxIndex = new TextBox();
            buttonJoin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cityIdDataGridViewTextBoxColumn, cityNameDataGridViewTextBoxColumn, countryCodeDataGridViewTextBoxColumn, countryCodeNavigationDataGridViewTextBoxColumn });
            dataGridView1.DataSource = cityBindingSource;
            dataGridView1.Location = new Point(18, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(453, 171);
            dataGridView1.TabIndex = 0;
            dataGridView1.Click += dataGridView1_CellContentClick;
            // 
            // cityIdDataGridViewTextBoxColumn
            // 
            cityIdDataGridViewTextBoxColumn.DataPropertyName = "CityId";
            cityIdDataGridViewTextBoxColumn.HeaderText = "CityId";
            cityIdDataGridViewTextBoxColumn.Name = "cityIdDataGridViewTextBoxColumn";
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            cityNameDataGridViewTextBoxColumn.DataPropertyName = "CityName";
            cityNameDataGridViewTextBoxColumn.HeaderText = "CityName";
            cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            // 
            // countryCodeDataGridViewTextBoxColumn
            // 
            countryCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryCode";
            countryCodeDataGridViewTextBoxColumn.HeaderText = "CountryCode";
            countryCodeDataGridViewTextBoxColumn.Name = "countryCodeDataGridViewTextBoxColumn";
            // 
            // countryCodeNavigationDataGridViewTextBoxColumn
            // 
            countryCodeNavigationDataGridViewTextBoxColumn.DataPropertyName = "CountryCodeNavigation";
            countryCodeNavigationDataGridViewTextBoxColumn.HeaderText = "CountryCodeNavigation";
            countryCodeNavigationDataGridViewTextBoxColumn.Name = "countryCodeNavigationDataGridViewTextBoxColumn";
            // 
            // cityBindingSource
            // 
            cityBindingSource.DataSource = typeof(Models.City);
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(18, 442);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(453, 127);
            dataGridView2.TabIndex = 1;
            // 
            // buttonCreate
            // 
            buttonCreate.Enabled = false;
            buttonCreate.Location = new Point(659, 42);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(121, 23);
            buttonCreate.TabIndex = 2;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Enabled = false;
            buttonUpdate.Location = new Point(659, 121);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(121, 23);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Enabled = false;
            buttonDelete.Location = new Point(658, 214);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(122, 23);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSelect
            // 
            buttonSelect.Enabled = false;
            buttonSelect.Location = new Point(659, 442);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(121, 23);
            buttonSelect.TabIndex = 5;
            buttonSelect.Text = "Select";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // textBoxCreate
            // 
            textBoxCreate.Location = new Point(504, 20);
            textBoxCreate.Name = "textBoxCreate";
            textBoxCreate.Size = new Size(122, 23);
            textBoxCreate.TabIndex = 6;
            textBoxCreate.TextChanged += textBoxCreate_TextChanged;
            // 
            // textBoxSelect
            // 
            textBoxSelect.Location = new Point(504, 442);
            textBoxSelect.Name = "textBoxSelect";
            textBoxSelect.Size = new Size(122, 23);
            textBoxSelect.TabIndex = 9;
            textBoxSelect.TextChanged += textBoxSelect_TextChanged;
            // 
            // comboBoxCreate
            // 
            comboBoxCreate.DataSource = countryBindingSource;
            comboBoxCreate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCreate.FormattingEnabled = true;
            comboBoxCreate.Location = new Point(504, 65);
            comboBoxCreate.Name = "comboBoxCreate";
            comboBoxCreate.Size = new Size(122, 23);
            comboBoxCreate.TabIndex = 11;
            comboBoxCreate.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // countryBindingSource
            // 
            countryBindingSource.DataSource = typeof(Models.Country);
            // 
            // comboBoxDelete
            // 
            comboBoxDelete.DataSource = cityBindingSource;
            comboBoxDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDelete.FormattingEnabled = true;
            comboBoxDelete.Location = new Point(504, 213);
            comboBoxDelete.Name = "comboBoxDelete";
            comboBoxDelete.Size = new Size(121, 23);
            comboBoxDelete.TabIndex = 12;
            // 
            // comboBoxUpdate
            // 
            comboBoxUpdate.DataSource = cityBindingSource;
            comboBoxUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUpdate.FormattingEnabled = true;
            comboBoxUpdate.Location = new Point(504, 121);
            comboBoxUpdate.Name = "comboBoxUpdate";
            comboBoxUpdate.Size = new Size(121, 23);
            comboBoxUpdate.TabIndex = 13;
            // 
            // textBoxUpdate
            // 
            textBoxUpdate.Location = new Point(504, 168);
            textBoxUpdate.Name = "textBoxUpdate";
            textBoxUpdate.Size = new Size(121, 23);
            textBoxUpdate.TabIndex = 14;
            textBoxUpdate.TextChanged += textBoxUpdate_TextChanged_1;
            // 
            // comboBoxUpdateCountry
            // 
            comboBoxUpdateCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUpdateCountry.FormattingEnabled = true;
            comboBoxUpdateCountry.Location = new Point(659, 168);
            comboBoxUpdateCountry.Name = "comboBoxUpdateCountry";
            comboBoxUpdateCountry.Size = new Size(121, 23);
            comboBoxUpdateCountry.TabIndex = 15;
            comboBoxUpdateCountry.SelectedIndexChanged += comboBoxUpdateCountry_SelectedIndexChanged;
            // 
            // buttonSupprimerSelection
            // 
            buttonSupprimerSelection.Location = new Point(18, 212);
            buttonSupprimerSelection.Name = "buttonSupprimerSelection";
            buttonSupprimerSelection.Size = new Size(108, 23);
            buttonSupprimerSelection.TabIndex = 16;
            buttonSupprimerSelection.Text = "Supprimer selection";
            buttonSupprimerSelection.UseVisualStyleBackColor = true;
            buttonSupprimerSelection.Click += buttonSupprimerSelection_Click;
            // 
            // buttonIndex
            // 
            buttonIndex.Enabled = false;
            buttonIndex.Location = new Point(503, 307);
            buttonIndex.Name = "buttonIndex";
            buttonIndex.Size = new Size(122, 23);
            buttonIndex.TabIndex = 17;
            buttonIndex.Text = "Chercher avec index";
            buttonIndex.UseVisualStyleBackColor = true;
            buttonIndex.Click += buttonIndex_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(659, 311);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 18;
            label1.Text = "label1";
            // 
            // textBoxIndex
            // 
            textBoxIndex.Location = new Point(503, 351);
            textBoxIndex.Name = "textBoxIndex";
            textBoxIndex.Size = new Size(122, 23);
            textBoxIndex.TabIndex = 19;
            textBoxIndex.TextChanged += textBox1_TextChanged;
            // 
            // buttonJoin
            // 
            buttonJoin.Enabled = false;
            buttonJoin.Location = new Point(658, 483);
            buttonJoin.Name = "buttonJoin";
            buttonJoin.Size = new Size(122, 23);
            buttonJoin.TabIndex = 20;
            buttonJoin.Text = "Join";
            buttonJoin.UseVisualStyleBackColor = true;
            buttonJoin.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 606);
            Controls.Add(buttonJoin);
            Controls.Add(textBoxIndex);
            Controls.Add(label1);
            Controls.Add(buttonIndex);
            Controls.Add(buttonSupprimerSelection);
            Controls.Add(comboBoxUpdateCountry);
            Controls.Add(textBoxUpdate);
            Controls.Add(comboBoxUpdate);
            Controls.Add(comboBoxDelete);
            Controls.Add(comboBoxCreate);
            Controls.Add(textBoxSelect);
            Controls.Add(textBoxCreate);
            Controls.Add(buttonSelect);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCreate);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryCodeNavigationDataGridViewTextBoxColumn;
        private BindingSource cityBindingSource;
        private DataGridView dataGridView2;
        private Button buttonCreate;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonSelect;
        private TextBox textBoxCreate;
        private TextBox textBoxSelect;
        private ComboBox comboBoxCreate;
        private BindingSource countryBindingSource;
        private BindingSource countryBindingSource1;
        private BindingSource countryBindingSource2;
        private ComboBox comboBoxDelete;
        private ComboBox comboBoxUpdate;
        private TextBox textBoxUpdate;
        private ComboBox comboBoxUpdateCountry;
        private Button buttonSupprimerSelection;
        private Button buttonIndex;
        private Label label1;
        private TextBox textBoxIndex;
        private Button buttonJoin;
    }
}