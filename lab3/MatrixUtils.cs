namespace lab3
{
    internal static class MatrixUtils
    {
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
            int matrixSize = matrix.ColumnCount;

            if (matrix.Name == "dataGridViewAdjacency")
                AddRowsAdjacency(matrix, matrixSize);
            else
                AddRowsIncidents(matrix, matrixSize);
        }

        private static void AddRowsAdjacency(DataGridView matrix, int size)
        {
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

        private static void AddRowsIncidents(DataGridView matrix, int size)
        {
            matrix.Rows.Add();
            for (int i = 0; i < size; i++)
            {
                matrix[i, 0].Value = i.ToString();
            }

            matrix.ReadOnly = true;
            matrix.Rows[0].DefaultCellStyle.BackColor = SystemColors.Control;
            matrix.AllowUserToAddRows = false;
        }

        public static void Fill(DataGridView matrix)
        {
            for (int i = 1; i < matrix.RowCount; i++)
            {
                for (int j = 1; j < matrix.ColumnCount; j++)
                {
                    // заполнение нулями и единицами
                    matrix[j, i].Value = (matrix[j, i].Value is null || matrix[j, i].Value.ToString() == "0") ? 0 : 1;
                }
            }
            if (matrix.Name == "dataGridViewAdjacency") FixDiagonalFill(matrix);
        }

        public static void FixDiagonalFill(DataGridView matrix)
        {
            for (int i = 1; i < matrix.RowCount; i++)
            {
                matrix[i, i].Value = null;
            }
        }
    }
}