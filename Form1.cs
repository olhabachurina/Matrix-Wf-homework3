using System.Windows.Forms;

namespace Matrix_Wf_homework3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string selectedSize = MatrixSizeComboBox.SelectedItem.ToString();
            int matrixSize = 0;

            if (selectedSize == "3x3")
            {
                matrixSize = 3;
            }
            else if (selectedSize == "6x6")
            {
                matrixSize = 6;
            }
            else if (selectedSize == "9x9")
            {
                matrixSize = 9;
            }

            double[,] matrix1 = new double[matrixSize, matrixSize];
            double[,] matrix2 = new double[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix1[row, col] = Convert.ToDouble(Matrix1DataGridView.Rows[row].Cells[col].Value);
                    matrix2[row, col] = Convert.ToDouble(Matrix2DataGridView.Rows[row].Cells[col].Value);
                }
            }

            double[,] resultMatrix = new double[matrixSize, matrixSize];
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    resultMatrix[row, col] = matrix1[row, col] + matrix2[row, col];
                }
            }

            ResultDataGridView.Rows.Clear();
            for (int row = 0; row < matrixSize; row++)
            {
                string[] rowValues = new string[matrixSize];
                for (int col = 0; col < matrixSize; col++)
                {
                    rowValues[col] = resultMatrix[row, col].ToString();
                }

                ResultDataGridView.Rows.Add(rowValues);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSize = MatrixSizeComboBox.SelectedItem.ToString();
            int matrixSize = 0;

            if (selectedSize == "3x3")
            {
                matrixSize = 3;
            }
            else if (selectedSize == "6x6")
            {
                matrixSize = 6;
            }
            else if (selectedSize == "9x9")
            {
                matrixSize = 9;
            }

            UpdateDataGridViewSize(Matrix1DataGridView, matrixSize);
            UpdateDataGridViewSize(Matrix2DataGridView, matrixSize);
            UpdateDataGridViewSize(ResultDataGridView, matrixSize);
        }

        private void UpdateDataGridViewSize(DataGridView dataGridView, int matrixSize)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            for (int col = 0; col < matrixSize; col++)
            {
                dataGridView.Columns.Add($"col{col + 1}", $"Col {col + 1}");
            }

            for (int row = 0; row < matrixSize; row++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                for (int col = 0; col < matrixSize; col++)
                {
                    newRow.Cells.Add(new DataGridViewTextBoxCell());
                }

                dataGridView.Rows.Add(newRow);
            }
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)// 1 матрица
        {
            DataGridViewCell cell = Matrix1DataGridView[e.ColumnIndex, e.RowIndex];


            string cellValue = cell.Value.ToString();
        }

        private void Matrix2DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)//2 матрица
        {
            DataGridViewCell cell = Matrix2DataGridView[e.ColumnIndex, e.RowIndex];


            string cellValue = cell.Value.ToString();

        }

        private void ResultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)// 3- результативна€
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                object cellValue = ResultDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null)
                {

                    {

                        MessageBox.Show("«начение €чейки: " + cellValue.ToString(), "«начение €чейки");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MatrixSizeComboBox.Items.Add("3x3");
            MatrixSizeComboBox.Items.Add("6x6");
            MatrixSizeComboBox.Items.Add("9x9");


            MatrixSizeComboBox.SelectedIndex = 0;
        }


    }
}


