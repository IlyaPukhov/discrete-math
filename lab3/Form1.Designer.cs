namespace lab3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridViewAdjacency = new System.Windows.Forms.DataGridView();
            this.RowHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxAdjacency = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewIncidents = new System.Windows.Forms.DataGridView();
            this.RowHeader_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxIncidents = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.numVertices = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjacency)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncidents)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.dataGridViewAdjacency);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.listBoxAdjacency);
            this.panel1.Location = new System.Drawing.Point(12, 117);
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
            this.textBox2.Text = "Список смежности";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewAdjacency
            // 
            this.dataGridViewAdjacency.AllowUserToDeleteRows = false;
            this.dataGridViewAdjacency.AllowUserToResizeColumns = false;
            this.dataGridViewAdjacency.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewAdjacency.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAdjacency.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataGridViewAdjacency.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewAdjacency.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdjacency.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAdjacency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdjacency.ColumnHeadersVisible = false;
            this.dataGridViewAdjacency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowHeader,
            this.Column1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAdjacency.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAdjacency.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewAdjacency.Location = new System.Drawing.Point(19, 73);
            this.dataGridViewAdjacency.Name = "dataGridViewAdjacency";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdjacency.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAdjacency.RowHeadersVisible = false;
            this.dataGridViewAdjacency.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewAdjacency.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewAdjacency.RowTemplate.Height = 29;
            this.dataGridViewAdjacency.Size = new System.Drawing.Size(357, 398);
            this.dataGridViewAdjacency.TabIndex = 1;
            this.dataGridViewAdjacency.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAdjacency_CellValueChanged);
            this.dataGridViewAdjacency.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGridViewAdjacency_CurrentCellDirtyStateChanged);
            // 
            // RowHeader
            // 
            this.RowHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RowHeader.DefaultCellStyle = dataGridViewCellStyle3;
            this.RowHeader.HeaderText = "";
            this.RowHeader.MinimumWidth = 6;
            this.RowHeader.Name = "RowHeader";
            this.RowHeader.ReadOnly = true;
            this.RowHeader.Width = 34;
            // 
            // Column1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
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
            // listBoxAdjacency
            // 
            this.listBoxAdjacency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxAdjacency.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxAdjacency.FormattingEnabled = true;
            this.listBoxAdjacency.ItemHeight = 33;
            this.listBoxAdjacency.Location = new System.Drawing.Point(403, 73);
            this.listBoxAdjacency.Name = "listBoxAdjacency";
            this.listBoxAdjacency.Size = new System.Drawing.Size(357, 398);
            this.listBoxAdjacency.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dataGridViewIncidents);
            this.panel2.Controls.Add(this.listBoxIncidents);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Location = new System.Drawing.Point(818, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 491);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewIncidents
            // 
            this.dataGridViewIncidents.AllowUserToDeleteRows = false;
            this.dataGridViewIncidents.AllowUserToResizeColumns = false;
            this.dataGridViewIncidents.AllowUserToResizeRows = false;
            this.dataGridViewIncidents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewIncidents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewIncidents.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIncidents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewIncidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncidents.ColumnHeadersVisible = false;
            this.dataGridViewIncidents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowHeader_1,
            this.Column1_1});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewIncidents.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewIncidents.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewIncidents.Location = new System.Drawing.Point(19, 73);
            this.dataGridViewIncidents.Name = "dataGridViewIncidents";
            this.dataGridViewIncidents.RowHeadersVisible = false;
            this.dataGridViewIncidents.RowHeadersWidth = 51;
            this.dataGridViewIncidents.RowTemplate.Height = 29;
            this.dataGridViewIncidents.Size = new System.Drawing.Size(357, 398);
            this.dataGridViewIncidents.TabIndex = 5;
            // 
            // RowHeader_1
            // 
            this.RowHeader_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RowHeader_1.HeaderText = "";
            this.RowHeader_1.MinimumWidth = 6;
            this.RowHeader_1.Name = "RowHeader_1";
            this.RowHeader_1.ReadOnly = true;
            this.RowHeader_1.Width = 34;
            // 
            // Column1_1
            // 
            this.Column1_1.HeaderText = "1";
            this.Column1_1.MinimumWidth = 6;
            this.Column1_1.Name = "Column1_1";
            this.Column1_1.Width = 34;
            // 
            // listBoxIncidents
            // 
            this.listBoxIncidents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxIncidents.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxIncidents.FormattingEnabled = true;
            this.listBoxIncidents.ItemHeight = 33;
            this.listBoxIncidents.Location = new System.Drawing.Point(403, 73);
            this.listBoxIncidents.Name = "listBoxIncidents";
            this.listBoxIncidents.Size = new System.Drawing.Size(357, 398);
            this.listBoxIncidents.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(403, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(357, 39);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Список инцидентности";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(19, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(357, 39);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "Матрица инцидентности";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.buttonResult);
            this.panel3.Controls.Add(this.numVertices);
            this.panel3.Location = new System.Drawing.Point(415, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 76);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество вершин графа:";
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
            this.numVertices.Location = new System.Drawing.Point(377, 18);
            this.numVertices.Name = "numVertices";
            this.numVertices.Size = new System.Drawing.Size(80, 39);
            this.numVertices.TabIndex = 3;
            this.numVertices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numVertices.TextChanged += new System.EventHandler(this.NumVertices_TextChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(111, 30);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(192, 48);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1613, 630);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GraphForms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjacency)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncidents)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private DataGridView dataGridViewAdjacency;
        private TextBox textBox1;
        private Panel panel2;
        private TextBox textBox4;
        private TextBox textBox5;
        private ListBox listBoxAdjacency;
        private ListBox listBoxIncidents;
        private DataGridView dataGridViewIncidents;
        private DataGridViewTextBoxColumn RowHeader_1;
        private DataGridViewTextBoxColumn Column1_1;
        private Panel panel3;
        private Button buttonResult;
        private TextBox numVertices;
        private Button buttonClear;
        private DataGridViewTextBoxColumn RowHeader;
        private DataGridViewTextBoxColumn Column1;
        private Label label1;
    }
}