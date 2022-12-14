using System.Collections;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs E)
        {
            dataGridView.Rows.Clear();
            dataGridView.RowCount = 32;
            textBox1.Clear();

            string sdnf = "";
            string sknf = "";
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                BitArray bitArray = new BitArray(new int[] { i }); // 11111000...0

                for (int j = 0; j < 5; j++)
                {
                    dataGridView[j, i].Value = Convert.ToInt32(bitArray[4 - j]);
                }

                bool a = Convert.ToBoolean(dataGridView[0, i].Value);
                bool b = Convert.ToBoolean(dataGridView[1, i].Value);
                bool c = Convert.ToBoolean(dataGridView[2, i].Value);
                bool d = Convert.ToBoolean(dataGridView[3, i].Value);
                bool e = Convert.ToBoolean(dataGridView[4, i].Value);

                if ((a || b || !c) && (!d || e))
                {
                    dataGridView[5, i].Value = 1;
                    if (sdnf != "")
                        sdnf += " ∨ ";
                    sdnf += $"({CheckPositive(a)}a ∧ {CheckPositive(b)}b ∧ {CheckPositive(c)}c ∧ {CheckPositive(d)}d ∧ {CheckPositive(e)}e)";
                }
                else
                {
                    dataGridView[5, i].Value = 0;
                    if (sknf != "")
                        sknf += " ∧ ";
                    sknf += $"({CheckNegative(a)}a ∨ {CheckNegative(b)}b ∨ {CheckNegative(c)}c ∨ {CheckNegative(d)}d ∨ {CheckNegative(e)}e)";
                }
            }
            textBox1.Text = "Совершенная дизъюнктивная нормальная форма = " + sdnf;
            textBox1.Text += "\r\n\r\nСовершенная конъюнктивная нормальная форма = " + sknf;
        }
        public static string CheckPositive(bool value) => !value ? "¬" : "";

        public static string CheckNegative(bool value) => value ? "¬" : "";
    }
}