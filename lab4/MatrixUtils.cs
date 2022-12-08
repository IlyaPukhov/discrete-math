namespace lab4
{
    internal static class MatrixUtils
    {
        public static int[,] ConvertMatrixToArray(DataGridView dataGridView)
        {
            int size = dataGridView.RowCount - 1;
            int[,] matrix = new int[size, size];

            for (int i = 1; i < dataGridView.ColumnCount; i++)
            {
                for (int j = 1; j < dataGridView.RowCount; j++)
                {
                    matrix[i - 1, j - 1] = Convert.ToInt32(dataGridView[i, j].Value);
                }
            }
            return matrix;
        }

        public static void AddСolumns(DataGridView matrix, int size)
        {
            for (int i = 1; i <= size + 1; i++)
            {
                matrix.Columns.Add("Column" + i, i.ToString());
            }
            matrix.Columns[0].ReadOnly = true;
        }

        public static void AddRows(DataGridView matrix)
        {
            int size = matrix.ColumnCount;
            matrix.Rows.Add(size);
            for (int i = 1; i < size; i++)
            {
                matrix[0, i].Value = i.ToString();
                matrix[i, 0].Value = i.ToString();

                matrix[i, i].ReadOnly = true;
                matrix[i, i].Style.BackColor = SystemColors.ControlLight;
            }

            matrix.Columns[0].ReadOnly = true;
            matrix.Columns[0].DefaultCellStyle.BackColor = SystemColors.Control;

            matrix.Rows[0].ReadOnly = true;
            matrix.Rows[0].DefaultCellStyle.BackColor = SystemColors.Control;
            matrix.AllowUserToAddRows = false;
        }

        public static void FixFill(DataGridView matrix)
        {
            for (int i = 1; i < matrix.RowCount; i++)
            {
                for (int j = 1; j < matrix.ColumnCount; j++)
                {
                    if (j == i) continue;

                    //fill zeros and units
                    matrix[j, i].Value = (matrix[j, i].Value is null || matrix[j, i].Value.ToString() == "0") ? 0 : 1;
                }
            }
        }

    }
}