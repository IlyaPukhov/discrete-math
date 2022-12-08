namespace lab3
{
    public partial class Form1 : Form
    {
        int size;
        public Form1()
        {
            InitializeComponent();
            GraphUtils.SetUpMatrices(dataGridViewAdjacency);
            GraphUtils.ClearMatrices(dataGridViewIncidents);
        }


        private void NumVertices_TextChanged(object sender, EventArgs e)
        {
            size = int.TryParse(numVertices.Text, out size) && size > 0 ? size : 1;

            GraphUtils.ClearMatrices(dataGridViewAdjacency, dataGridViewIncidents);
            GraphUtils.ClearLists(listBoxAdjacency, listBoxIncidents);

            MatrixUtils.AddСolumns(dataGridViewAdjacency, size);
            MatrixUtils.AddRows(dataGridViewAdjacency);
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            MatrixUtils.Fill(dataGridViewAdjacency);

            GraphUtils.ClearLists(listBoxAdjacency, listBoxIncidents);
            GraphUtils.ClearMatrices(dataGridViewIncidents);

            PrintAdjacencyList();
            PrintIncidentsMatrix();
            PrintIncidentsList();
        }

        private void PrintAdjacencyList() // список смежности
        {
            for (int row = 1; row < dataGridViewAdjacency.RowCount; row++)
            {
                List<int> listAdjacencyColumns = new List<int>();
                for (int column = 1; column < dataGridViewAdjacency.ColumnCount; column++)
                {
                    if (Convert.ToInt32(dataGridViewAdjacency[column, row].Value) == 1)
                    {
                        listAdjacencyColumns.Add(column);
                    }
                }

                if (listAdjacencyColumns.Count > 0)
                {
                    listBoxAdjacency.Items.Add($" {row} :  {string.Join(", ", listAdjacencyColumns)}");
                }
            }

            if (listBoxAdjacency.Items.Count == 0)
            {
                listBoxAdjacency.Items.Add("Нет смежных вершин!");
            }
        }

        private void PrintIncidentsMatrix() // матрица инцидентности
        {
            MatrixUtils.AddСolumns(dataGridViewIncidents, dataGridViewAdjacency.ColumnCount - 1);
            MatrixUtils.AddRows(dataGridViewIncidents);

            for (int row = 1; row < dataGridViewAdjacency.RowCount; row++)
            {
                for (int column = row; column < dataGridViewAdjacency.ColumnCount; column++)
                {
                    if (Convert.ToInt32(dataGridViewAdjacency[column, row].Value) == 1)
                    {
                        int incRow = dataGridViewIncidents.Rows.Add();

                        dataGridViewIncidents[column, incRow].Value = dataGridViewIncidents[row, incRow].Value = 1;
                    }
                }
            }
            dataGridViewIncidents.Columns[0].Visible = false;

            MatrixUtils.Fill(dataGridViewIncidents);

            if (dataGridViewIncidents.RowCount == 1)
            {
                int row = dataGridViewIncidents.Rows.Add();
                for (int column = 0; column < dataGridViewIncidents.ColumnCount; column++)
                {
                    dataGridViewIncidents[column, row].Value = 0;
                }
            }
        }

        private void PrintIncidentsList() // список инцидентности
        {
            for (int row = 1; row < dataGridViewIncidents.RowCount; row++)
            {
                List<int> listIncidentsColumns = new List<int>();
                for (int column = 1; column < dataGridViewIncidents.ColumnCount; column++)
                {
                    if (Convert.ToInt32(dataGridViewIncidents[column, row].Value) == 1)
                    {
                        listIncidentsColumns.Add(column);
                    }
                }

                if (listIncidentsColumns.Count > 0)
                    listBoxIncidents.Items.Add($" [ {string.Join(", ", listIncidentsColumns)} ]");
            }

            if (listBoxIncidents.Items.Count == 0)
            {
                listBoxIncidents.Items.Add("Нет инцидентных ребер!");
            }
        }


        private void ButtonClear_Click(object sender, EventArgs e)
        {
            GraphUtils.ClearLists(listBoxAdjacency, listBoxIncidents);
            GraphUtils.ClearMatrices(dataGridViewIncidents);

            for (int row = 1; row < dataGridViewAdjacency.RowCount; row++)
                for (int column = row; column < dataGridViewAdjacency.ColumnCount; column++)
                    dataGridViewAdjacency[column, row].Value = null;
        }


        private void DataGridViewAdjacency_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewAdjacency.IsCurrentCellDirty)
            {
                dataGridViewAdjacency.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridViewAdjacency_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex > 0)
            {
                int j = e.ColumnIndex;
                int i = e.RowIndex;

                if (dataGridViewAdjacency[j, i].Value != dataGridViewAdjacency[i, j].Value)
                {
                    dataGridViewAdjacency[i, j].Value = dataGridViewAdjacency[j, i].Value;
                }
            }
        }
    }
}