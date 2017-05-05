namespace GraphEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.openGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.viewGraphButton = new System.Windows.Forms.Button();
            this.viewGraphComboBox = new System.Windows.Forms.ComboBox();
            this.createGraphButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weightTextbox = new System.Windows.Forms.TextBox();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.selectButton = new System.Windows.Forms.ToolStripButton();
            this.nodeButton = new System.Windows.Forms.ToolStripButton();
            this.edgeButton = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveGraph,
            this.openGraph,
            this.закрытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newToolStripMenuItem.Text = "Новый";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveGraph
            // 
            this.saveGraph.Name = "saveGraph";
            this.saveGraph.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveGraph.Size = new System.Drawing.Size(172, 22);
            this.saveGraph.Text = "Сохранить";
            this.saveGraph.Click += new System.EventHandler(this.saveGraph_Click);
            // 
            // openGraph
            // 
            this.openGraph.Name = "openGraph";
            this.openGraph.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openGraph.Size = new System.Drawing.Size(172, 22);
            this.openGraph.Text = "Окрыть";
            this.openGraph.Click += new System.EventHandler(this.openGraph_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.createGraphButton);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picturebox);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 546);
            this.splitContainer1.SplitterDistance = 231;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.viewGraphButton);
            this.groupBox3.Controls.Add(this.viewGraphComboBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 92);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Представления графа";
            // 
            // viewGraphButton
            // 
            this.viewGraphButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewGraphButton.Location = new System.Drawing.Point(113, 57);
            this.viewGraphButton.Name = "viewGraphButton";
            this.viewGraphButton.Size = new System.Drawing.Size(81, 23);
            this.viewGraphButton.TabIndex = 1;
            this.viewGraphButton.Text = "Посмотреть";
            this.viewGraphButton.UseVisualStyleBackColor = true;
            this.viewGraphButton.Click += new System.EventHandler(this.viewGraphButton_Click);
            // 
            // viewGraphComboBox
            // 
            this.viewGraphComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewGraphComboBox.FormattingEnabled = true;
            this.viewGraphComboBox.Items.AddRange(new object[] {
            "Матрица смежности",
            "Матрица инцидентности",
            "Матрица весов",
            "Список ребер",
            "Структура смежности"});
            this.viewGraphComboBox.Location = new System.Drawing.Point(9, 30);
            this.viewGraphComboBox.Name = "viewGraphComboBox";
            this.viewGraphComboBox.Size = new System.Drawing.Size(185, 21);
            this.viewGraphComboBox.TabIndex = 0;
            // 
            // createGraphButton
            // 
            this.createGraphButton.Location = new System.Drawing.Point(12, 25);
            this.createGraphButton.Name = "createGraphButton";
            this.createGraphButton.Size = new System.Drawing.Size(140, 23);
            this.createGraphButton.TabIndex = 3;
            this.createGraphButton.Text = "Создать новый граф";
            this.createGraphButton.UseVisualStyleBackColor = true;
            this.createGraphButton.Click += new System.EventHandler(this.createGraphButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.weightTextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свойства";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вес";
            // 
            // weightTextbox
            // 
            this.weightTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weightTextbox.Location = new System.Drawing.Point(38, 27);
            this.weightTextbox.Name = "weightTextbox";
            this.weightTextbox.Size = new System.Drawing.Size(156, 20);
            this.weightTextbox.TabIndex = 1;
            this.weightTextbox.TextChanged += new System.EventHandler(this.weightTextbox_TextChanged);
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.Color.White;
            this.picturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturebox.Location = new System.Drawing.Point(0, 25);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(826, 521);
            this.picturebox.TabIndex = 1;
            this.picturebox.TabStop = false;
            this.picturebox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            this.picturebox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseDoubleClick);
            this.picturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseDown);
            this.picturebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseMove);
            this.picturebox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectButton,
            this.nodeButton,
            this.edgeButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(826, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // selectButton
            // 
            this.selectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectButton.Image = global::GraphEditor.Properties.Resources.cursor_512;
            this.selectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(23, 22);
            this.selectButton.Text = "toolStripButton1";
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // nodeButton
            // 
            this.nodeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nodeButton.Image = global::GraphEditor.Properties.Resources.black_circle_hi;
            this.nodeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nodeButton.Name = "nodeButton";
            this.nodeButton.Size = new System.Drawing.Size(23, 22);
            this.nodeButton.Text = "toolStripButton2";
            this.nodeButton.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // edgeButton
            // 
            this.edgeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.edgeButton.Image = global::GraphEditor.Properties.Resources.graph_edge;
            this.edgeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edgeButton.Name = "edgeButton";
            this.edgeButton.Size = new System.Drawing.Size(23, 22);
            this.edgeButton.Text = "toolStripButton3";
            this.edgeButton.Click += new System.EventHandler(this.edgeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 570);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Граф";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem saveGraph;
        private System.Windows.Forms.ToolStripMenuItem openGraph;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton selectButton;
        private System.Windows.Forms.ToolStripButton nodeButton;
        private System.Windows.Forms.ToolStripButton edgeButton;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.TextBox weightTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button createGraphButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button viewGraphButton;
        private System.Windows.Forms.ComboBox viewGraphComboBox;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
    }
}

