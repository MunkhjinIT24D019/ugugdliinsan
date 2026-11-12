namespace ugugdliinsan
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            lblSearch = new Label();
            textBox1 = new TextBox();
            dgvWords = new DataGridView();
            lblSavedTitle = new Label();
            lstSaved = new ListBox();
            lblEnglish = new Label();
            lblMongolian = new Label();
            lblRussian = new Label();
            txtEnglish = new TextBox();
            txtMongolian = new TextBox();
            txtRussian = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSave = new Button();
            lblStatus = new Label();
            colNumber = new DataGridViewTextBoxColumn();
            colRussian = new DataGridViewTextBoxColumn();
            colEnglish = new DataGridViewTextBoxColumn();
            colMongolian = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvWords).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(17, 21);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(46, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Хайх:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 16);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Хайх үг:";
            textBox1.Size = new Size(450, 29);
            textBox1.TabIndex = 1;
            // 
            // dgvWords
            // 
            dgvWords.AllowUserToAddRows = false;
            dgvWords.AllowUserToDeleteRows = false;
            dgvWords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWords.BackgroundColor = Color.White;
            dgvWords.BorderStyle = BorderStyle.None;
            dgvWords.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvWords.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWords.Columns.AddRange(new DataGridViewColumn[] { colNumber, colRussian, colEnglish, colMongolian });
            dgvWords.EnableHeadersVisualStyles = false;
            dgvWords.GridColor = Color.FromArgb(225, 228, 232);
            dgvWords.Location = new Point(17, 89);
            dgvWords.Name = "dgvWords";
            dgvWords.ReadOnly = true;
            dgvWords.RowHeadersVisible = false;
            dgvWords.RowHeadersWidth = 51;
            dgvWords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWords.Size = new Size(472, 294);
            dgvWords.TabIndex = 2;
            // 
            // lblSavedTitle
            // 
            lblSavedTitle.AutoSize = true;
            lblSavedTitle.Font = new Font("Segoe UI", 8.5F);
            lblSavedTitle.ForeColor = Color.FromArgb(110, 110, 110);
            lblSavedTitle.Location = new Point(512, 87);
            lblSavedTitle.Name = "lblSavedTitle";
            lblSavedTitle.Size = new Size(163, 20);
            lblSavedTitle.TabIndex = 3;
            lblSavedTitle.Text = "saved.db · saved_words";
            // 
            // lstSaved
            // 
            lstSaved.BackColor = Color.White;
            lstSaved.BorderStyle = BorderStyle.FixedSingle;
            lstSaved.FormattingEnabled = true;
            lstSaved.Location = new Point(512, 110);
            lstSaved.Name = "lstSaved";
            lstSaved.Size = new Size(232, 86);
            lstSaved.TabIndex = 4;
            // 
            // lblEnglish
            // 
            lblEnglish.AutoSize = true;
            lblEnglish.Location = new Point(17, 425);
            lblEnglish.Name = "lblEnglish";
            lblEnglish.Size = new Size(52, 21);
            lblEnglish.TabIndex = 5;
            lblEnglish.Text = "Англи";
            // 
            // lblMongolian
            // 
            lblMongolian.AutoSize = true;
            lblMongolian.Location = new Point(264, 425);
            lblMongolian.Name = "lblMongolian";
            lblMongolian.Size = new Size(65, 21);
            lblMongolian.TabIndex = 6;
            lblMongolian.Text = "Монгол";
            // 
            // lblRussian
            // 
            lblRussian.AutoSize = true;
            lblRussian.Location = new Point(512, 425);
            lblRussian.Name = "lblRussian";
            lblRussian.Size = new Size(47, 21);
            lblRussian.TabIndex = 7;
            lblRussian.Text = "Орос";
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(73, 420);
            txtEnglish.Name = "txtEnglish";
            txtEnglish.Size = new Size(168, 29);
            txtEnglish.TabIndex = 8;
            // 
            // txtMongolian
            // 
            txtMongolian.Location = new Point(332, 420);
            txtMongolian.Name = "txtMongolian";
            txtMongolian.Size = new Size(168, 29);
            txtMongolian.TabIndex = 9;
            // 
            // txtRussian
            // 
            txtRussian.Location = new Point(562, 420);
            txtRussian.Name = "txtRussian";
            txtRussian.Size = new Size(168, 29);
            txtRussian.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(17, 478);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 37);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+ Нэмэх";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(124, 478);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(101, 37);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "✎ Засах";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(231, 478);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 37);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Устгах";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(338, 478);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 37);
            btnClear.TabIndex = 14;
            btnClear.Text = "↻ Цэвэрлэх";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(461, 478);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 37);
            btnSave.TabIndex = 15;
            btnSave.Text = "▣ Санах";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(17, 536);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(175, 21);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Нийт: 10 үг · Санасан: 0";
            // 
            // colNumber
            // 
            colNumber.FillWeight = 20F;
            colNumber.HeaderText = "№";
            colNumber.MinimumWidth = 6;
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            // 
            // colRussian
            // 
            colRussian.HeaderText = "Англи";
            colRussian.MinimumWidth = 6;
            colRussian.Name = "colRussian";
            colRussian.ReadOnly = true;
            // 
            // colEnglish
            // 
            colEnglish.HeaderText = "Монгол";
            colEnglish.MinimumWidth = 6;
            colEnglish.Name = "colEnglish";
            colEnglish.ReadOnly = true;
            // 
            // colMongolian
            // 
            colMongolian.HeaderText = "Орос";
            colMongolian.MinimumWidth = 6;
            colMongolian.Name = "colMongolian";
            colMongolian.ReadOnly = true;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(198, 232, 198);
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(30, 90, 30);
            label1.Location = new Point(512, 110);
            label1.Name = "label1";
            label1.Padding = new Padding(8, 0, 0, 0);
            label1.Size = new Size(232, 30);
            label1.TabIndex = 17;
            label1.Text = "Санасан үгс";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.5F);
            label2.ForeColor = Color.FromArgb(110, 110, 110);
            label2.Location = new Point(16, 64);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 18;
            label2.Text = "toli.db · words";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 228, 232);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 1);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Location = new Point(176, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 228, 232);
            panel3.Location = new Point(0, 380);
            panel3.Name = "panel3";
            panel3.Size = new Size(700, 1);
            panel3.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(638, 21);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 21;
            label3.Text = "Хэл:";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Бүгд", "Англи", "Монгол", "Орос" });
            comboBox1.Location = new Point(682, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 29);
            comboBox1.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(818, 566);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblStatus);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtRussian);
            Controls.Add(txtMongolian);
            Controls.Add(txtEnglish);
            Controls.Add(lblRussian);
            Controls.Add(lblMongolian);
            Controls.Add(lblEnglish);
            Controls.Add(lstSaved);
            Controls.Add(lblSavedTitle);
            Controls.Add(dgvWords);
            Controls.Add(textBox1);
            Controls.Add(lblSearch);
            Font = new Font("Segoe UI", 9.5F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гурван хэлний толь бичиг";
            ((System.ComponentModel.ISupportInitialize)dgvWords).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private TextBox textBox1;
        private DataGridView dgvWords;
        private Label lblSavedTitle;
        private ListBox lstSaved;
        private Label lblEnglish;
        private Label lblMongolian;
        private Label lblRussian;
        private TextBox txtEnglish;
        private TextBox txtMongolian;
        private TextBox txtRussian;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSave;
        private Label lblStatus;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colRussian;
        private DataGridViewTextBoxColumn colEnglish;
        private DataGridViewTextBoxColumn colMongolian;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private ComboBox comboBox1;
    }
}
