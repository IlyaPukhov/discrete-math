namespace lab2
{
    public partial class Form1 : Form
    {
        readonly int numFigures = 4;
        readonly Label[] labelR;
        readonly Label[] labelW;
        readonly Label[] labelH;
        readonly Label[] forCircle;
        readonly Label[] forRectangle;
        readonly TextBox[] textX0;
        readonly TextBox[] textY0;
        readonly TextBox[] textR;
        readonly TextBox[] textW;
        readonly TextBox[] textH;
        readonly RadioButton[] radioButtonCircles;

        public Form1()
        {
            InitializeComponent();
            labelR = new Label[] { labelAR, labelBR, labelCR, labelDR };
            labelW = new Label[] { labelAw, labelBw, labelCw, labelDw };
            labelH = new Label[] { labelAh, labelBh, labelCh, labelDh };
            forCircle = new Label[] { forCircleA, forCircleB, forCircleC, forCircleD };
            forRectangle = new Label[] { forRectangleA, forRectangleB, forRectangleC, forRectangleD };

            textX0 = new TextBox[] { Ax0, Bx0, Cx0, Dx0 };
            textY0 = new TextBox[] { Ay0, By0, Cy0, Dy0 };
            textR = new TextBox[] { AR, BR, CR, DR };
            textW = new TextBox[] { Aw, Bw, Cw, Dw };
            textH = new TextBox[] { Ah, Bh, Ch, Dh };
            radioButtonCircles = new RadioButton[] { radioButtonCircleA, radioButtonCircleB, radioButtonCircleC, radioButtonCircleD };

        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            double X = ToDouble(x.Text);
            double Y = ToDouble(y.Text);

            Figure[] figures = new Figure[numFigures];

            // Создание фигур
            for (int i = 0; i < numFigures; i++)
            {
                double R, W, H;
                bool IsCircle = radioButtonCircles[i].Checked;
                double X0 = ToDouble(textX0[i].Text);
                double Y0 = ToDouble(textY0[i].Text);
                R = W = H = 0;
                if (IsCircle)
                {
                    R = ToDouble(textR[i].Text);
                }
                else
                {
                    W = ToDouble(textW[i].Text);
                    H = ToDouble(textH[i].Text);
                }

                figures[i] = GetFigure(IsCircle, X0, Y0, R, W, H);
            }

            bool A = IsInSet(X, Y, figures[0]);
            bool B = IsInSet(X, Y, figures[1]);
            bool C = IsInSet(X, Y, figures[2]);
            bool D = IsInSet(X, Y, figures[3]);

            bool V = (!(A && B) || D) || C;
            if (V)
            {
                textBoxResult.Text = $"\r\nТочка ({X}; {Y}) принадлежит заданному плоскому множеству точек";
            }
            else
            {
                textBoxResult.Text = $"\r\nТочка ({X}; {Y}) НЕ принадлежит заданному плоскому множеству точек";
            }
        }

        private static double ToDouble(string text)
        {
            if (Double.TryParse(text.Trim().Replace('.', ','), out double result))
            {
                return result;
            }
            else
            {
                MessageBox.Show("Стандартные значения!", "Ошибка чтения координат!");
                return 0;
            }
        }

        private static bool IsInSet(double X0, double Y0, Figure figure)
        {
            if (figure.isCircle)
            {
                double X = X0 - figure.x0;
                double Y = Y0 - figure.y0;

                return Math.Sqrt(X * X + Y * Y) <= figure.R;
            }
            else
            {
                double leftX = figure.x0 - figure.w / 2;
                double rightX = figure.x0 + figure.w / 2;
                double topY = figure.y0 + figure.h / 2;
                double bottomY = figure.y0 - figure.h / 2;

                return (X0 >= leftX && X0 <= rightX && Y0 <= topY && Y0 >= bottomY);
            }
        }

        private static Figure GetFigure(bool isCircle, double x0, double y0, double R, double w, double h)
        {
            Figure figure = new Figure()
            {
                x0 = x0,
                y0 = y0,
                isCircle = isCircle
            };

            if (isCircle)
            {
                figure.R = R;
            }
            else
            {
                figure.w = w;
                figure.h = h;
            }
            return figure;
        }


        private void RadioButtonA_CheckedChanged(object sender, EventArgs e) => SetVisibles(0);
        private void RadioButtonB_CheckedChanged(object sender, EventArgs e) => SetVisibles(1);
        private void RadioButtonC_CheckedChanged(object sender, EventArgs e) => SetVisibles(2);
        private void RadioButtonD_CheckedChanged(object sender, EventArgs e) => SetVisibles(3);

        private void SetVisibles(int id)
        {
            if (radioButtonCircles[id].Checked)
            {
                forRectangle[id].Visible = false;
                labelW[id].Visible = false;
                labelH[id].Visible = false;
                textH[id].Visible = false;
                textW[id].Visible = false;

                forCircle[id].Visible = true;
                labelR[id].Visible = true;
                textR[id].Visible = true;
            }
            else
            {
                forRectangle[id].Visible = true;
                labelW[id].Visible = true;
                labelH[id].Visible = true;
                textH[id].Visible = true;
                textW[id].Visible = true;

                forCircle[id].Visible = false;
                labelR[id].Visible = false;
                textR[id].Visible = false;
            }
        }

        public struct Figure
        {
            public bool isCircle;
            public double x0;
            public double y0;
            public double w;
            public double h;
            public double R;
        }
    }
}