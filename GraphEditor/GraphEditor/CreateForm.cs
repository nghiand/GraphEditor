using System;
using System.Windows.Forms;

namespace GraphEditor
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void matrixTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = matrixTypeCombobox.SelectedIndex;
            matrix.Columns.Clear();
            Console.WriteLine(selectedIndex);
            switch (selectedIndex)
            {
                case 0:
                    weightCheckbox.Enabled = false;
                    weightCheckbox.Checked = false;
                    edgeNumberUpdown.Enabled = false;
                    break;
                case 1:
                    weightCheckbox.Enabled = false;
                    weightCheckbox.Checked = false;
                    edgeNumberUpdown.Enabled = true;
                    break;
                case 2:
                    weightCheckbox.Enabled = false;
                    weightCheckbox.Checked = true;
                    edgeNumberUpdown.Enabled = false;
                    break;
                case 3:
                    weightCheckbox.Enabled = true;
                    weightCheckbox.Checked = false;
                    edgeNumberUpdown.Enabled = true;
                    break;
                case 4:
                    weightCheckbox.Enabled = false;
                    weightCheckbox.Checked = false;
                    edgeNumberUpdown.Enabled = false;
                    break;
                default:
                    return;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = matrixTypeCombobox.SelectedIndex;
            Console.WriteLine(selectedIndex);
            int n = (int)nodeNumberUpdown.Value;
            int m = (int)edgeNumberUpdown.Value;
            bool weightCheck = weightCheckbox.Checked;
            switch (selectedIndex)
            {
                case 0:
                    matrix.Columns.Clear();

                    matrix.ColumnCount = n;
                    for (int i = 0; i < n; i++)
                    {
                        matrix.Columns[i].Name = (i + 1).ToString();
                        matrix.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        int index = matrix.Rows.Add();
                        matrix.Rows[index].HeaderCell.Value = (i + 1).ToString();
                    }
                    break;
                case 1:
                    matrix.Columns.Clear();

                    matrix.ColumnCount = m;
                    for (int i = 0; i < m; i++)
                    {
                        matrix.Columns[i].Name = (i + 1).ToString();
                        matrix.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        int index = matrix.Rows.Add();
                        matrix.Rows[index].HeaderCell.Value = (i + 1).ToString();
                    }
                    break;
                case 2:
                    matrix.Columns.Clear();

                    matrix.ColumnCount = n;
                    for (int i = 0; i < n; i++)
                    {
                        matrix.Columns[i].Name = (i + 1).ToString();
                        matrix.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        int index = matrix.Rows.Add();
                        matrix.Rows[index].HeaderCell.Value = (i + 1).ToString();
                    }
                    break;
                case 3:
                    matrix.Columns.Clear();
                    if (m == 0) break;
                    matrix.ColumnCount = m;
                    for (int i = 0; i < m; i++)
                    {
                        matrix.Columns[i].Name = (i + 1).ToString();
                        matrix.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    int index3 = matrix.Rows.Add();
                    matrix.Rows[index3].HeaderCell.Value = "r";
                    index3 = matrix.Rows.Add();
                    matrix.Rows[index3].HeaderCell.Value = "t";
                    if (weightCheck)
                    {
                        index3 = matrix.Rows.Add();
                        matrix.Rows[index3].HeaderCell.Value = "w";
                    }
                    break;
                case 4:
                    matrix.Columns.Clear();

                    matrix.ColumnCount = 1;
                    matrix.Columns[0].Name = "Adj[x]";
                    matrix.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                    for (int i = 0; i < n; i++)
                    {
                        int index = matrix.Rows.Add();
                        matrix.Rows[index].HeaderCell.Value = (i + 1).ToString();
                    }
                    break;
                default:
                    return;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = matrixTypeCombobox.SelectedIndex;
            int n = (int)nodeNumberUpdown.Value;
            int m = (int)edgeNumberUpdown.Value;
            bool weightCheck = weightCheckbox.Checked;
            int[,] input;
            Graph.Graph graph;
            try
            {
                switch (selectedIndex)
                {
                    case 0:
                        // Check matrix format
                        if (matrix.Rows.Count != n)
                        {
                            throw new Exception("Количества вершин в поле и в матрице не совпадают.");
                        }
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                int index;
                                if (int.TryParse(matrix.Rows[i].Cells[j].Value.ToString(), out index) == false)
                                {
                                    throw new Exception("Некорректные значения ячейк матрицы. Проверьте, пожалуйста.");
                                }
                                if (index != 0 && index != 1)
                                {
                                    throw new Exception("Значение ячейки принимает только 0 или 1.");
                                }
                                if (index == 1 && i == j)
                                {
                                    throw new Exception("Петлей не разрешено");
                                }
                            }
                        }

                        // Create graph
                        input = new int[n, n];
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                input[i, j] = int.Parse(matrix.Rows[i].Cells[j].Value.ToString());
                            }
                        }
                        graph = Graph.GraphRepresentation.fromAdjacencyMatrix(input);
                        break;
                    case 1:
                        // Check matrix format
                        if (matrix.Rows.Count != n)
                        {
                            throw new Exception("Количества вершин в поле и в матрице не совпадают.");
                        }
                        if (matrix.Columns.Count != m)
                        {
                            throw new Exception("Количества ребр в поле и в матрице не совпадают.");
                        }
                        for (int j = 0; j < m; j++)
                        {
                            int count0 = 0;
                            int sum = 0;
                            for (int i = 0; i < n; i++)
                            {
                                int index;
                                if (int.TryParse(matrix.Rows[i].Cells[j].Value.ToString(), out index) == false)
                                {
                                    throw new Exception("Некорректные значения ячейк матрицы. Проверьте, пожалуйста.");
                                }
                                if (index != 0 && index != 1 && index != -1)
                                {
                                    throw new Exception("Значение ячейки принимает только -1, 0 или 1.");
                                }
                                if (index == 0) count0++;
                                sum += index;
                            }
                            if (count0 != n - 2 || sum != 0)
                            {
                                throw new Exception("Некорректный формат");
                            }
                        }
                        // Create graph
                        input = new int[n, m];
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                input[i, j] = int.Parse(matrix.Rows[i].Cells[j].Value.ToString());
                            }
                        }
                        graph = Graph.GraphRepresentation.fromIncidenceMatrix(input);
                        break;
                    case 2:
                        // Check matrix format
                        if (matrix.Rows.Count != n)
                        {
                            throw new Exception("Количества вершин в поле и в матрице не совпадают.");
                        }
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                int index;
                                if (int.TryParse(matrix.Rows[i].Cells[j].Value.ToString(), out index) == false)
                                {
                                    throw new Exception("Некорректные значения ячейк матрицы. Проверьте, пожалуйста.");
                                }
                                if (index < 0)
                                {
                                    throw new Exception("Значение ячейки принимает только положительные числа.");
                                }
                                if (i == j && index != 0)
                                {
                                    throw new Exception("Петлей не разрешено");
                                }
                            }
                        }
                        // Create graph
                        input = new int[n, n];
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                input[i, j] = int.Parse(matrix.Rows[i].Cells[j].Value.ToString());
                            }
                        }
                        graph = Graph.GraphRepresentation.fromWeightMatrix(input);
                        break;
                    case 3:
                        // Check matrix format
                        if (matrix.Columns.Count != m)
                        {
                            throw new Exception("Количества ребр в поле и в матрице не совпадают.");
                        }
                        for (int j = 0; j < m; j++)
                        {
                            for (int i = 0; i < (weightCheck ? 3 : 2); i++)
                            {
                                int index;
                                if (int.TryParse(matrix.Rows[i].Cells[j].Value.ToString(), out index) == false)
                                {
                                    throw new Exception("Некорректные значения ячейк матрицы. Проверьте, пожалуйста.");
                                }
                                if (index <= 0)
                                {
                                    throw new Exception("Значение ячейки принимает только положительные числа.");
                                }
                                if (i < 2 && index > n)
                                {
                                    throw new Exception("Некорректный формат");
                                }
                            }
                            if (matrix.Rows[0].Cells[j].Value.ToString() == matrix.Rows[1].Cells[j].Value.ToString())
                            {
                                throw new Exception("Петлей не разрешено");
                            }
                        }
                        // Create graph
                        input = new int[matrix.Rows.Count, m];
                        for (int i = 0; i < matrix.Rows.Count; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                input[i, j] = int.Parse(matrix.Rows[i].Cells[j].Value.ToString());
                            }
                        }
                        graph = Graph.GraphRepresentation.fromEdgeList(input);
                        while (graph.Nodes.Count < n)
                        {
                            graph.AddNode(new Graph.Node(graph.Nodes.Count));
                        }
                        break;
                    case 4:
                        // Check matrix format
                        if (matrix.Rows.Count != n)
                        {
                            throw new Exception("Количества вершин в поле и в матрице не совпадают.");
                        }

                        for (int i = 0; i < n; i++)
                        {
                            if (matrix.Rows[i].Cells[0].Value == null)
                                continue;
                            string s = matrix.Rows[i].Cells[0].Value.ToString();
                            string[] tokens = s.Split(new[] { ',' });
                            for (int j = 0; j < tokens.GetLength(0); j++)
                            {
                                int index;
                                if (int.TryParse(tokens[j], out index) == false)
                                {
                                    throw new Exception("Некорректные значения.");
                                }
                                if (index <= 0 || index > n)
                                {
                                    throw new Exception("Некорректный формат");
                                }
                                if (index == i + 1)
                                {
                                    throw new Exception("Петлей не разрешено");
                                }
                            }
                        }
                        // Create graph
                        graph = new Graph.Graph();
                        for (int i = 0; i < n; i++)
                            graph.AddNode(new Graph.Node(i));
                        for (int i = 0; i < n; i++)
                        {
                            if (matrix.Rows[i].Cells[0].Value == null)
                                continue;
                            string s = matrix.Rows[i].Cells[0].Value.ToString();
                            string[] tokens = s.Split(new[] { ',' });
                            for (int j = 0; j < tokens.GetLength(0); j++)
                            {
                                int index = int.Parse(tokens[j]);
                                graph.AddEdge(new Graph.Edge(graph.Nodes[i], graph.Nodes[index - 1]));
                            }
                        }
                        break;
                    default:
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            graph.MaxId = graph.Nodes.Count;
            MainForm parent = (MainForm)Owner;
            parent.CreateGraph(graph);
            Close();
        }
    }
}
