namespace GraphEditor
{
    partial class CreateForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.matrix = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nodeNumberUpdown = new System.Windows.Forms.NumericUpDown();
            this.edgeNumberUpdown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.matrixTypeCombobox = new System.Windows.Forms.ComboBox();
            this.weightCheckbox = new System.Windows.Forms.CheckBox();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeNumberUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeNumberUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.generateButton);
            this.splitContainer1.Panel1.Controls.Add(this.weightCheckbox);
            this.splitContainer1.Panel1.Controls.Add(this.matrixTypeCombobox);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.edgeNumberUpdown);
            this.splitContainer1.Panel1.Controls.Add(this.nodeNumberUpdown);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.matrix);
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.createButton);
            this.splitContainer1.Panel2.Controls.Add(this.cancelButton);
            this.splitContainer1.Size = new System.Drawing.Size(916, 521);
            this.splitContainer1.SplitterDistance = 477;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(211, 477);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cancelButton.Location = new System.Drawing.Point(829, 8);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 22);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.createButton.Location = new System.Drawing.Point(739, 8);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 22);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // matrix
            // 
            this.matrix.AllowUserToAddRows = false;
            this.matrix.AllowUserToDeleteRows = false;
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrix.Location = new System.Drawing.Point(211, 0);
            this.matrix.Name = "matrix";
            this.matrix.Size = new System.Drawing.Size(705, 477);
            this.matrix.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество вершин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество ребр";
            // 
            // nodeNumberUpdown
            // 
            this.nodeNumberUpdown.Location = new System.Drawing.Point(12, 87);
            this.nodeNumberUpdown.Name = "nodeNumberUpdown";
            this.nodeNumberUpdown.Size = new System.Drawing.Size(188, 20);
            this.nodeNumberUpdown.TabIndex = 4;
            // 
            // edgeNumberUpdown
            // 
            this.edgeNumberUpdown.Location = new System.Drawing.Point(12, 143);
            this.edgeNumberUpdown.Name = "edgeNumberUpdown";
            this.edgeNumberUpdown.Size = new System.Drawing.Size(188, 20);
            this.edgeNumberUpdown.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип представления";
            // 
            // matrixTypeCombobox
            // 
            this.matrixTypeCombobox.FormattingEnabled = true;
            this.matrixTypeCombobox.Items.AddRange(new object[] {
            "Матрица смежности",
            "Матрица инцидентности",
            "Матрица весов",
            "Список ребер",
            "Структура смежности"});
            this.matrixTypeCombobox.Location = new System.Drawing.Point(12, 35);
            this.matrixTypeCombobox.Name = "matrixTypeCombobox";
            this.matrixTypeCombobox.Size = new System.Drawing.Size(188, 21);
            this.matrixTypeCombobox.TabIndex = 7;
            this.matrixTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.matrixTypeCombobox_SelectedIndexChanged);
            // 
            // weightCheckbox
            // 
            this.weightCheckbox.AutoSize = true;
            this.weightCheckbox.Location = new System.Drawing.Point(12, 181);
            this.weightCheckbox.Name = "weightCheckbox";
            this.weightCheckbox.Size = new System.Drawing.Size(45, 17);
            this.weightCheckbox.TabIndex = 9;
            this.weightCheckbox.Text = "Вес";
            this.weightCheckbox.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(12, 214);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(85, 23);
            this.generateButton.TabIndex = 10;
            this.generateButton.Text = "Генерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 521);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CreateForm";
            this.ShowIcon = false;
            this.Text = "Создать новый граф";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeNumberUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeNumberUpdown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.CheckBox weightCheckbox;
        private System.Windows.Forms.ComboBox matrixTypeCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown edgeNumberUpdown;
        private System.Windows.Forms.NumericUpDown nodeNumberUpdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}