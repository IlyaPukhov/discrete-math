namespace lab3
{
    internal static class GraphUtils
    {
        public static void SetUpMatrices(params DataGridView[] matrices)
        {
            foreach (DataGridView matrix in matrices)
            {
                matrix.RowCount = 2;
                matrix.Rows[0].ReadOnly = true;
                matrix[0, 1].Value = '1';
                matrix[1, 0].Value = '1';
                matrix[1, 1].Style.BackColor = SystemColors.ControlLight;
                matrix.Columns[0].DefaultCellStyle.BackColor = SystemColors.Control;
                matrix.Rows[0].DefaultCellStyle.BackColor = SystemColors.Control;
            }
        }

        public static void ClearMatrices(params DataGridView[] matrices)
        {
            foreach (DataGridView matrix in matrices)
            {
                matrix.Rows.Clear();
                matrix.Columns.Clear();
            }
        }

        public static void ClearLists(params ListBox[] lists)
        {
            foreach (ListBox list in lists)
            {
                list.Items.Clear();
            }
        }
    }
}
