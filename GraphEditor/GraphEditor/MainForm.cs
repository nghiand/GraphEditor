using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GraphEditor.Graph;
using System.Data;
using System.IO;

namespace GraphEditor
{
    public partial class MainForm : Form
    {
        private Graph.Graph graph;
        private Graphics g;
        private List<GraphObject> objects = new List<GraphObject>();
        private GraphObject currentObj = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            graph = new Graph.Graph();
            selectButton.Checked = true;
            nodeButton.Checked = false;
            edgeButton.Checked = false;
            weightTextbox.Enabled = false;
            g = picturebox.CreateGraphics();
        }

        private void picturebox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Node n = graph.CreateNewNode(e.Location);
                n.Draw(g);
                n.Selected += Node_Selected;
                n.Deselected += Node_Deselected;
                objects.Insert(0, n);
                //UpdateMatrices();
            }
        }

        private void Node_Deselected(object sender)
        {
            currentObj = null;
        }

        private void Node_Selected(object sender)
        {
            Node n = (Node)sender;
            if (selectButton.Checked)
            {
            }
            else if (edgeButton.Checked)
            {
                if (from == null)
                {
                    from = n;
                }
                else
                {
                    if (from == n)
                    {
                        n.Deselect();
                        from = null;
                    }
                    else
                    {
                        Edge edge = graph.CreateNewEdge(from, n);
                        edge.Selected += Edge_Selected;
                        edge.Deselected += Edge_Deselected;
                        objects.Add(edge);
                        from = null;
                        n.Deselect();
                    }
                }
            }
            else if (nodeButton.Checked)
            {

            }
            weightTextbox.Text = "";
            weightTextbox.Enabled = false;
            currentObj = n;
        }

        private void Edge_Selected(object sender)
        {
            Edge e = (Edge)sender;
            weightTextbox.Enabled = true;
            weightTextbox.Text = e.Weight.ToString();
            currentObj = e;
        }

        private void Edge_Deselected(object sender)
        {
            weightTextbox.Text = "";
            weightTextbox.Enabled = false;
            currentObj = null;
        }

        private Node from = null;

        private void picturebox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (selectButton.Checked || edgeButton.Checked)
                {
                    foreach (GraphObject obj in objects)
                        obj.Deselect();
                    foreach (GraphObject obj in objects)
                    {
                        if (obj.IsOnHover(e))
                        {
                            obj.OnMouseClick(e);
                            break;
                        }
                    }
                    Repaint();
                }
                else if (nodeButton.Checked)
                {
                    Node n = graph.CreateNewNode(e.Location);
                    n.Draw(g);
                    n.Selected += Node_Selected;
                    n.Deselected += Node_Deselected;
                    objects.Insert(0, n);
                    //UpdateMatrices();
                }
            }
        }

        private void picturebox_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void picturebox_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void picturebox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (selectButton.Checked)
                {
                    if (currentObj != null)
                        currentObj.Deselect();
                    foreach (GraphObject obj in objects)
                    {
                        if (obj is Node && obj.IsOnHover(e))
                        {
                            obj.Deselect();
                            ((Node)obj).OnMove(e.Location);
                            break;
                        }
                    }
                    Repaint();
                }
                else if (nodeButton.Checked)
                {

                }
                else if (edgeButton.Checked)
                {
                }
            }
        }

        private void picturebox_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            graph.Draw(g);
        }

        public void Repaint()
        {
            g.Clear(Color.White);
            graph.Draw(g);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            g = picturebox.CreateGraphics();
            Repaint();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            selectButton.Checked = true;
            nodeButton.Checked = false;
            edgeButton.Checked = false;
        }

        private void nodeButton_Click(object sender, EventArgs e)
        {
            selectButton.Checked = false;
            nodeButton.Checked = true;
            edgeButton.Checked = false;
        }

        private void edgeButton_Click(object sender, EventArgs e)
        {
            selectButton.Checked = false;
            nodeButton.Checked = false;
            edgeButton.Checked = true;
            from = null;
        }

        private void weightTextbox_TextChanged(object sender, EventArgs e)
        {
            if (currentObj != null && currentObj is Edge)
            {
                int w;
                if (int.TryParse(weightTextbox.Text, out w))
                {
                    ((Edge)currentObj).Weight = w;
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (currentObj != null)
                {
                    if (currentObj is Node)
                        graph.DeleteNode((Node)currentObj);
                    else
                        graph.DeleteEdge((Edge)currentObj);
                    objects.Remove(currentObj);
                    Repaint();
                }
                Console.WriteLine("Delete");
            }
        }

        private void WriteToFile(int[,] matrix)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text|*.txt";
            save.Title = "Сохранить";
            save.ShowDialog();
            if (save.FileName != "")
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        writer.Write(matrix[i, j]);
                        writer.Write(" ");
                    }
                    writer.WriteLine();
                }
                writer.Close();
            }
        }

        private void adjacencyMatrixSaveButton_Click(object sender, EventArgs e)
        {
            WriteToFile(GraphRepresentation.toAdjacencyMatrix(graph));
        }

        private void incidenceMatrixSaveButton_Click(object sender, EventArgs e)
        {
            WriteToFile(GraphRepresentation.toIncidenceMatrix(graph));
        }

        private void weightMatrixSaveButton_Click(object sender, EventArgs e)
        {
            WriteToFile(GraphRepresentation.toWeightMatrix(graph));
        }

        private void edgeListSaveButton_Click(object sender, EventArgs e)
        {
            WriteToFile(GraphRepresentation.toEdgeList(graph));
        }

        private void adjacencyListSaveButton_Click(object sender, EventArgs e)
        {
            WriteToFile(GraphRepresentation.toAdjacencyList(graph));
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graph = new Graph.Graph();
            selectButton.Checked = true;
            nodeButton.Checked = false;
            edgeButton.Checked = false;
            weightTextbox.Enabled = false;
            g.Clear(Color.White);
        }

        private void saveGraph_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text|*.txt";
            save.Title = "Сохранить";
            save.ShowDialog();
            if (save.FileName != "")
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine("{0} {1} {2}", graph.Nodes.Count, graph.Edges.Count, graph.MaxId);
                foreach (Node n in graph.Nodes)
                {
                    writer.WriteLine("{0} {1} {2}", n.Id, n.Position.X, n.Position.Y);
                }
                foreach(Edge edge in graph.Edges)
                {
                    writer.WriteLine("{0} {1} {2}", edge.From.Id, edge.To.Id, edge.Weight);
                }
                writer.Close();
            }
        }

        private void openGraph_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text|*.txt";
            open.Title = "Окрыть";
            open.ShowDialog();
            if (open.FileName != "")
            {
                StreamReader reader = new StreamReader(open.OpenFile());
                string[] items = reader.ReadLine().Split(' ');
                int n = int.Parse(items[0]);
                int m = int.Parse(items[1]);
                int maxId = int.Parse(items[2]);
                graph = new Graph.Graph();
                graph.MaxId = maxId;
                selectButton.Checked = true;
                nodeButton.Checked = false;
                edgeButton.Checked = false;
                weightTextbox.Enabled = false;
                g.Clear(Color.White);
                objects.Clear();

                for (int i = 0; i < n; i++)
                {
                    items = reader.ReadLine().Split(' ');
                    int id = int.Parse(items[0]);
                    int x = int.Parse(items[1]);
                    int y = int.Parse(items[2]);
                    Node node = graph.CreateNewNode(new Point(x, y), id);
                    node.Draw(g);
                    node.Selected += Node_Selected;
                    node.Deselected += Node_Deselected;
                    objects.Insert(0, node);
                }

                for (int i = 0; i < m; i++)
                {
                    items = reader.ReadLine().Split(' ');
                    int u = int.Parse(items[0]);
                    int v = int.Parse(items[1]);
                    int w = int.Parse(items[2]);
                    Node nodeu = graph.FindNodeWithId(u);
                    Node nodev = graph.FindNodeWithId(v);
                    Edge edge = graph.CreateNewEdge(nodeu, nodev, w);
                    edge.Selected += Edge_Selected;
                    edge.Deselected += Edge_Deselected;
                    objects.Add(edge);
                    int count = graph.CountEdge(edge);
                    edge.Draw(g, count);
                }

                //UpdateMatrices();
                reader.Close();
            }
        }

        private void data_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            if (current.TabIndex == 0)
            {
                Console.WriteLine("OK");
                picturebox.Refresh();
                //picturebox.Invalidate();
                //Repaint();
            }
        }

        private void data_Deselected(object sender, TabControlEventArgs e)
        {
            TabPage tab = (sender as TabControl).SelectedTab;
            if (tab.TabIndex == 0)
            {
                Console.WriteLine("Deselected");
            }
        }

        private void viewGraphButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = viewGraphComboBox.SelectedIndex;
            DataGridView viewMatrix = new DataGridView();
            string name = "";
            switch (selectedIndex)
            {
                case 0:
                    // Adjacency Matrix
                    int[,] matrix = GraphRepresentation.toAdjacencyMatrix(graph);
                    viewMatrix.Columns.Clear();

                    viewMatrix.ColumnCount = graph.Nodes.Count;
                    for (int i = 0; i < graph.Nodes.Count; i++)
                        viewMatrix.Columns[i].Name = graph.Nodes[i].Name;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        int index = viewMatrix.Rows.Add();
                        viewMatrix.Rows[index].HeaderCell.Value = graph.Nodes[i].Name;
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            viewMatrix.Rows[index].Cells[j].Value = matrix[i, j];
                        }
                    }
                    name = "Матрица смежности";
                    break;
                case 1:
                    matrix = GraphRepresentation.toIncidenceMatrix(graph);
                    viewMatrix.Columns.Clear();

                    if (graph.Edges.Count > 0)
                    {
                        viewMatrix.ColumnCount = graph.Edges.Count;
                        for (int i = 0; i < graph.Edges.Count; i++)
                            viewMatrix.Columns[i].Name = graph.Edges[i].From.Name + "/" + graph.Edges[i].To.Name;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            int index = viewMatrix.Rows.Add();
                            viewMatrix.Rows[index].HeaderCell.Value = graph.Nodes[i].Name;
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                viewMatrix.Rows[index].Cells[j].Value = matrix[i, j];
                            }
                        }
                    }
                    name = "Матрица инцидентности";
                    break;
                case 2:
                    matrix = GraphRepresentation.toWeightMatrix(graph);
                    viewMatrix.Columns.Clear();

                    viewMatrix.ColumnCount = graph.Nodes.Count;
                    for (int i = 0; i < graph.Nodes.Count; i++)
                        viewMatrix.Columns[i].Name = graph.Nodes[i].Name;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        int index = viewMatrix.Rows.Add();
                        viewMatrix.Rows[index].HeaderCell.Value = graph.Nodes[i].Name;
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i, j] == 1000000)
                                viewMatrix.Rows[index].Cells[j].Value = "oo";
                            else
                                viewMatrix.Rows[index].Cells[j].Value = matrix[i, j];
                        }
                    }
                    name = "Матрица весов";
                    break;
                case 3:
                    matrix = GraphRepresentation.toEdgeList(graph);
                    viewMatrix.Columns.Clear();

                    if (graph.Edges.Count > 0)
                    {
                        viewMatrix.ColumnCount = graph.Edges.Count;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            int index = viewMatrix.Rows.Add();
                            if (i == 0)
                                viewMatrix.Rows[index].HeaderCell.Value = "r";
                            else
                                viewMatrix.Rows[index].HeaderCell.Value = "t";
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                viewMatrix.Rows[index].Cells[j].Value = matrix[i, j];
                            }
                        }
                    }
                    name = "Список ребер";
                    break;
                case 4:
                    viewMatrix.Columns.Clear();
                    viewMatrix.ColumnCount = 1;
                    viewMatrix.Columns[0].Name = "Adj[x]";
                    for (int i = 0; i < graph.Nodes.Count; i++)
                    {
                        string s = "";
                        foreach (Edge edge in graph.Edges)
                            if (edge.From == graph.Nodes[i])
                            {
                                s += edge.To.Name + ", ";
                            }
                        int index = viewMatrix.Rows.Add();
                        viewMatrix.Rows[index].HeaderCell.Value = graph.Nodes[i].Name;
                        viewMatrix.Rows[index].Cells[0].Value = s;
                    }
                    name = "Структура смежности";
                    break;
                default:
                    return;
            }
            using (ViewForm viewForm = new ViewForm(viewMatrix, name))
            {
                viewForm.ShowDialog(this);
            }
            Console.WriteLine(selectedIndex);
        }

        private void createGraphButton_Click(object sender, EventArgs e)
        {
            using (CreateForm createForm = new CreateForm())
            {
                createForm.ShowDialog(this);
            }
        }

        public void CreateGraph(Graph.Graph gr)
        {
            graph = gr;
            g.Clear(Color.White);
            float r = Math.Min((float)picturebox.Width / 2, (float)picturebox.Height / 2) - 20 - Node.NODE_SIZE;
            double unit = 2.0 * Math.PI / graph.Nodes.Count;
            double deg = 0;
            PointF center = new PointF((float)picturebox.Width / 2, (float)picturebox.Height / 2);
            for (int i = 0; i < graph.Nodes.Count; i++)
            {
                float x = center.X + (r * (float)Math.Cos(deg));
                float y = center.Y + (r * (float)Math.Sin(deg));
                graph.Nodes[i].Position = new Point((int)x, (int)y);
                deg += unit;
            }
            objects.Clear();
            for (int i = 0; i < graph.Nodes.Count; i++)
            {
                objects.Insert(0, graph.Nodes[i]);
                graph.Nodes[i].Selected += Node_Selected;
                graph.Nodes[i].Deselected += Node_Deselected;
            }
            for (int i = 0; i < graph.Edges.Count; i++)
            {
                objects.Add(graph.Edges[i]);
                graph.Edges[i].Selected += Edge_Selected;
                graph.Edges[i].Deselected += Edge_Deselected;
            }
                
            Repaint();
            //Console.WriteLine(r);
        }
    }
}
