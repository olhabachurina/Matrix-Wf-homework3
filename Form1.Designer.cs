namespace Matrix_Wf_homework3
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
            label1 = new Label();
            MatrixSizeComboBox = new ComboBox();
            Matrix1DataGridView = new DataGridView();
            CalculateButton = new Button();
            Matrix2DataGridView = new DataGridView();
            ResultDataGridView = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)Matrix1DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Matrix2DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(330, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(316, 29);
            label1.TabIndex = 0;
            label1.Text = "Выберите размер матрицы";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // MatrixSizeComboBox
            // 
            MatrixSizeComboBox.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MatrixSizeComboBox.ForeColor = Color.FromArgb(255, 128, 128);
            MatrixSizeComboBox.FormattingEnabled = true;
            MatrixSizeComboBox.Location = new Point(654, 20);
            MatrixSizeComboBox.Margin = new Padding(4, 5, 4, 5);
            MatrixSizeComboBox.Name = "MatrixSizeComboBox";
            MatrixSizeComboBox.Size = new Size(188, 37);
            MatrixSizeComboBox.TabIndex = 1;
            MatrixSizeComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Matrix1DataGridView
            // 
            Matrix1DataGridView.BackgroundColor = Color.FromArgb(255, 128, 255);
            Matrix1DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Matrix1DataGridView.Location = new Point(102, 125);
            Matrix1DataGridView.Margin = new Padding(4, 5, 4, 5);
            Matrix1DataGridView.Name = "Matrix1DataGridView";
            Matrix1DataGridView.RowHeadersWidth = 51;
            Matrix1DataGridView.RowTemplate.Height = 29;
            Matrix1DataGridView.Size = new Size(372, 184);
            Matrix1DataGridView.TabIndex = 2;
            Matrix1DataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.FromArgb(255, 192, 192);
            CalculateButton.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CalculateButton.Location = new Point(522, 336);
            CalculateButton.Margin = new Padding(4, 5, 4, 5);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(173, 71);
            CalculateButton.TabIndex = 3;
            CalculateButton.Text = "Посчитать";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // Matrix2DataGridView
            // 
            Matrix2DataGridView.BackgroundColor = Color.FromArgb(255, 128, 255);
            Matrix2DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Matrix2DataGridView.Location = new Point(727, 125);
            Matrix2DataGridView.Margin = new Padding(4, 5, 4, 5);
            Matrix2DataGridView.Name = "Matrix2DataGridView";
            Matrix2DataGridView.RowHeadersWidth = 51;
            Matrix2DataGridView.RowTemplate.Height = 29;
            Matrix2DataGridView.Size = new Size(395, 184);
            Matrix2DataGridView.TabIndex = 4;
            Matrix2DataGridView.CellContentClick += Matrix2DataGridView_CellContentClick;
            // 
            // ResultDataGridView
            // 
            ResultDataGridView.BackgroundColor = Color.FromArgb(255, 224, 192);
            ResultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultDataGridView.Location = new Point(425, 472);
            ResultDataGridView.Margin = new Padding(4, 5, 4, 5);
            ResultDataGridView.Name = "ResultDataGridView";
            ResultDataGridView.RowHeadersWidth = 51;
            ResultDataGridView.RowTemplate.Height = 29;
            ResultDataGridView.Size = new Size(363, 230);
            ResultDataGridView.TabIndex = 5;
            ResultDataGridView.CellContentClick += ResultDataGridView_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(130, 91);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(323, 29);
            label2.TabIndex = 6;
            label2.Text = "Введите данные 1 матрицы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(748, 91);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(326, 29);
            label3.TabIndex = 7;
            label3.Text = "Введите данные 2 матрицы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(462, 438);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(305, 29);
            label4.TabIndex = 8;
            label4.Text = "Результирующая матрица";
            // 
            // Form1
            // 
            AcceptButton = CalculateButton;
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1512, 716);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ResultDataGridView);
            Controls.Add(Matrix2DataGridView);
            Controls.Add(CalculateButton);
            Controls.Add(Matrix1DataGridView);
            Controls.Add(MatrixSizeComboBox);
            Controls.Add(label1);
            Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Matrix1DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Matrix2DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ResultDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private ComboBox MatrixSizeComboBox;
        private DataGridView Matrix1DataGridView;
        private Button CalculateButton;
        private DataGridView Matrix2DataGridView;
        private DataGridView ResultDataGridView;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}