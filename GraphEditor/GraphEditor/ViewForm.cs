using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GraphEditor
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        public ViewForm(DataGridView viewMatrix, string name)
        {
            InitializeComponent();
            Text = name;
            matrix.Columns.Clear();
            matrix.ColumnCount = viewMatrix.ColumnCount;
            for (int i = 0; i < viewMatrix.ColumnCount; i++)
                matrix.Columns[i].Name = viewMatrix.Columns[i].Name;
            for (int i = 0; i < viewMatrix.RowCount; i++)
            {
                int index = matrix.Rows.Add();
                matrix.Rows[index].HeaderCell.Value = viewMatrix.Rows[index].HeaderCell.Value;
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    matrix.Rows[index].Cells[j].Value = viewMatrix.Rows[index].Cells[j].Value;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text|*.txt";
            save.Title = "Сохранить";
            save.ShowDialog();
            if (save.FileName != "")
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < matrix.Rows.Count - 1; i++)
                {
                    List<string> cols = new List<string>();
                    
                    for (int j = 0; j < matrix.Columns.Count; j++)
                    {
                        cols.Add(matrix.Rows[i].Cells[j].Value.ToString());
                    }
                    builder.AppendLine(string.Join(" ", cols.ToArray()));
                }
                File.WriteAllText(save.FileName, builder.ToString());
            }
        }
    }
}
