namespace lab4
{
    internal static class GraphUtils
    {
        public static void SetUpMatrix(DataGridView matrix)
        {

            matrix.RowCount = 2;
            matrix.Rows[0].ReadOnly = true;
            matrix[0, 1].Value = '1';
            matrix[1, 0].Value = '1';
            matrix[1, 1].Style.BackColor = SystemColors.ControlLight;
            matrix.Columns[0].DefaultCellStyle.BackColor = SystemColors.Control;
            matrix.Rows[0].DefaultCellStyle.BackColor = SystemColors.Control;
        }

        public static void ClearMatrix(DataGridView matrix)
        {
            matrix.Rows.Clear();
            matrix.Columns.Clear();
        }
    }
}
