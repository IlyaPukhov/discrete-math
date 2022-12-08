namespace lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridViewAdjacency = new System.Windows.Forms.DataGridView();
            this.RowHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxEuler = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.numVertices = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjacency)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.dataGridViewAdjacency);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBoxEuler);
            this.panel1.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(13, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 491);
            this.panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(403, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(357, 39);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Цикл Эйлера";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewAdjacency
            // 
            this.dataGridViewAdjacency.AllowUserToDeleteRows = false;
            this.dataGridViewAdjacency.AllowUserToResizeColumns = false;
            this.dataGridViewAdjacency.AllowUserToResizeRows = false;
            this.dataGridViewAdjacency.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAdjacency.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAdjacency.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdjacency.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAdjacency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdjacency.ColumnHeadersVisible = false;
            this.dataGridViewAdjacency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowHeader,
            this.Column1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAdjacency.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAdjacency.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewAdjacency.Location = new System.Drawing.Point(19, 73);
            this.dataGridViewAdjacency.Name = "dataGridViewAdjacency";
            this.dataGridViewAdjacency.RowHeadersVisible = false;
            this.dataGridViewAdjacency.RowHeadersWidth = 51;
            this.dataGridViewAdjacency.RowTemplate.Height = 29;
            this.dataGridViewAdjacency.Size = new System.Drawing.Size(357, 394);
            this.dataGridViewAdjacency.TabIndex = 1;
            this.dataGridViewAdjacency.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAdjacency_CellValueChanged);
            this.dataGridViewAdjacency.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGridViewAdjacency_CurrentCellDirtyStateChanged);
            // 
            // RowHeader
            // 
            this.RowHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RowHeader.HeaderText = "";
            this.RowHeader.MinimumWidth = 6;
            this.RowHeader.Name = "RowHeader";
            this.RowHeader.ReadOnly = true;
            this.RowHeader.Width = 34;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 34;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(19, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(357, 39);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Матрица смежности";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEuler
            // 
            this.textBoxEuler.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEuler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEuler.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEuler.HideSelection = false;
            this.textBoxEuler.Location = new System.Drawing.Point(403, 73);
            this.textBoxEuler.Multiline = true;
            this.textBoxEuler.Name = "textBoxEuler";
            this.textBoxEuler.ReadOnly = true;
            this.textBoxEuler.Size = new System.Drawing.Size(357, 394);
            this.textBoxEuler.TabIndex = 4;
            // 
            // buttonResult
            // 
            this.buttonResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResult.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResult.Location = new System.Drawing.Point(514, 12);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(192, 48);
            this.buttonResult.TabIndex = 2;
            this.buttonResult.Text = "Расчет";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // numVertices
            // 
            this.numVertices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numVertices.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numVertices.Location = new System.Drawing.Point(379, 18);
            this.numVertices.Name = "numVertices";
            this.numVertices.Size = new System.Drawing.Size(80, 39);
            this.numVertices.TabIndex = 3;
            this.numVertices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numVertices.TextChanged += new System.EventHandler(this.NumVertices_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.buttonResult);
            this.panel3.Controls.Add(this.numVertices);
            this.panel3.Location = new System.Drawing.Point(12, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 76);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество вершин графа:";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(308, 626);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(192, 48);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(803, 692);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GraphForms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjacency)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private DataGridView dataGridViewAdjacency;
        private TextBox textBox1;
        private Button buttonResult;
        private TextBox numVertices;
        private Panel panel3;
        private DataGridViewTextBoxColumn RowHeader;
        private DataGridViewTextBoxColumn Column1;
        private TextBox textBoxEuler;
        private Label label2;
        private Button buttonClear;
    }
}