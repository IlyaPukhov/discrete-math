namespace lab4
{
    public partial class Form1 : Form
    {
        int size;
        public Form1()
        {
            InitializeComponent();
            GraphUtils.SetUpMatrix(dataGridViewAdjacency);
        }


        private void NumVertices_TextChanged(object sender, EventArgs e)
        {
            size = int.TryParse(numVertices.Text, out size) && size > 0 ? size : 1;

            GraphUtils.ClearMatrix(dataGridViewAdjacency);
            textBoxEuler.Clear();

            MatrixUtils.AddСolumns(dataGridViewAdjacency, size);
            MatrixUtils.AddRows(dataGridViewAdjacency);
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            MatrixUtils.FixFill(dataGridViewAdjacency);
            textBoxEuler.Clear();

            PrintEulerCycle(dataGridViewAdjacency);
        }

        private void PrintEulerCycle(DataGridView dataGridViewAdjacency)
        {
            int[,] matrix = MatrixUtils.ConvertMatrixToArray(dataGridViewAdjacency);


            bool isExistOddVertex = false;
            int[] vertices = new int[size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    vertices[i] += matrix[i, j];
                }

                if (vertices[i] % 2 != 0)
                {
                    isExistOddVertex = true;
                    break;
                }
            }

            // Если есть нечетная вершина, то Эйлерова цикла не существует.
            if (isExistOddVertex)
            {
                textBoxEuler.Text = "Цикла Эйлера не существует!";
            }
            else
            {
                textBoxEuler.Text = GetEulerCycle(matrix);
            }
        }

        private string GetEulerCycle(int[,] matrix)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(0);

            Stack<int> resultCycle = new Stack<int>();
            // Идем из исходной вершины по циклу, пока не придем в исходную вершину
            // или пока не встретится вершина, у которой имеются инцидентные ей неотмеченные ребра.
            while (stack.Count > 0)
            {
                int currentVertex = stack.Peek();
                int firstAdjacencyVertex = GetAdjacencyVertex(matrix, currentVertex);

                if (firstAdjacencyVertex < 0)
                {
                    resultCycle.Push(stack.Pop());
                    continue;
                }

                // Встретилась вершина, у которой имеются инцидентные ей неотмеченные ребра =>
                // Отмечаем в перечне вершин уже построенного цикла первую найденную вершину
                // с инцидентными ей неотмеченными ребрами.
                // Строим из этой вершины дополнительный цикл, проходя по неотмеченным ребрам, отмечая
                // пройденные, пока не вернемся в эту же вершину.
                // Выписываем перечень вершин построенного дополнительного цикла, вставляем его в ранее
                // построенный цикл, совмещая его первую вершину с отмеченной.

                matrix[currentVertex, firstAdjacencyVertex] = matrix[firstAdjacencyVertex, currentVertex] = 0;
                stack.Push(firstAdjacencyVertex);
            }

            string euler = "";
            foreach (int vertex in resultCycle)
            {
                euler += $"{vertex + 1} ";
            }

            return euler[..(euler.Length - 1)];
        }

        private int GetAdjacencyVertex(int[,] matrix, int vertex)
        {
            for (int i = 0; i < size; i++)
            {
                if (matrix[vertex, i] == 1)
                {
                    return i;
                }
            }
            return -1;
        }


        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxEuler.Clear();

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