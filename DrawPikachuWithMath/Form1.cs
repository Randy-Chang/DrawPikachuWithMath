using ZedGraph;

namespace DrawPikachuWithMath
{
    public partial class Form1 : Form
    {
        ZedGraphControl ZGraphDraw;
        Random random = new Random();
        List<double[]> listDoubleArrayX = new List<double[]>();
        List<double[]> listDoubleArrayY = new List<double[]>();

        public Form1()
        {
            InitializeComponent();

            InitZgraphInPanel(out ZGraphDraw, plZGraph);
            hsbValueA.ValueChanged += hsbValueA_ValueChanged;
            hsbValueA.Minimum = -1;
            hsbValueA.Maximum = 10;
            hsbValueA.LargeChange = 1;
            hsbValueA.Value = 0;
            lbValueA.Text = Convert.ToString(hsbValueA.Value);
            DrawCurve();
        }

        void hsbValueA_ValueChanged(object? sender, EventArgs e)
        {
            DrawCurve();
        }

        void BuildGraph(ZedGraphControl graph, List<double[]> listDoubleArrayX, List<double[]> listDoubleArrayY)
        {
            float SymbolSize = 6.0f;
            //清空曲線            
            GraphPane pane = graph.GraphPane;
            pane.CurveList.Clear();

            int intCount = listDoubleArrayX.Count;

            for (int i = 0; i < intCount; i++)
            {
                PointPairList PointPairs = new PointPairList(listDoubleArrayX[i], listDoubleArrayY[i]);
                LineItem myCurve;
                myCurve = pane.AddCurve($"Function{i}", PointPairs, RandomColor(), SymbolType.None);
                myCurve.IsY2Axis = false;
                myCurve.Line.Width = SymbolSize;
                myCurve.YAxisIndex = 0;
            }

            graph.AxisChange();
            graph.Invalidate();
        }

        void InitZgraphInPanel(out ZedGraphControl graph, Panel pl)
        {
            graph = new ZedGraphControl();
            graph.Parent = pl;
            graph.Dock = DockStyle.Fill;
            InitZgraph(graph);
        }

        void InitZgraph(ZedGraphControl graph)
        {
            int TitleFontSpecSize = 25;
            int ScaleFontSpecSize = 20;
            // Init_Graph_oneY
            GraphPane pane = graph.GraphPane;

            //pane.Title.IsVisible = false;
            pane.Legend.IsVisible = false;

            // Set the Titles
            pane.Title.Text = "Pickachu";  //Graph Title
            pane.Title.FontSpec.Size = 25;

            // Show the x axis grid
            pane.XAxis.MajorGrid.IsVisible = true;

            // Show the x axis scale and title
            pane.XAxis.Title.Text = "X";
            pane.XAxis.Title.FontSpec.Size = TitleFontSpecSize;
            pane.XAxis.Scale.FontSpec.Size = ScaleFontSpecSize;
            pane.XAxis.Scale.Max = 10;
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MajorGrid.DashOn = 10;
            pane.XAxis.MajorGrid.DashOff = 5;
            pane.XAxis.Scale.MajorStep = 1;

            // Show the y axis grid
            pane.YAxis.MajorGrid.IsVisible = true;

            // Show the y axis scale and title
            pane.YAxis.Title.Text = "Y";
            pane.YAxis.Title.FontSpec.Size = TitleFontSpecSize;
            pane.YAxis.Scale.FontSpec.Size = ScaleFontSpecSize;
            pane.YAxis.Scale.Max = 10;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.DashOn = 10;
            pane.YAxis.MajorGrid.DashOff = 5;
            pane.YAxis.Scale.MajorStep = 1;

        }


        #region Fucnction 1~9 頭輪廓
        void Function1(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 9; i <= 30; i++)
            {
                double x = i * 0.1 - ValueA;
                double y = 0.122 * Math.Pow(x - 3.6, 2) + 6.18;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function2(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 9; i <= 35; i++)
            {
                double x = i * 0.1 - ValueA;
                double y = -0.122 * Math.Pow(x - 2.0, 2) + 7.2;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function3(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 34; i <= 57; i++)
            {
                double x = i * 0.1 - ValueA;
                double y = -0.22 * Math.Pow(x - 4.7, 2) + 7.2;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function4(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 55; i <= 68; i++)
            {
                double x = i * 0.1 - ValueA;
                double y = -1 * Math.Pow(x - 7.0, 2) + 9.2;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function5(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 66; i <= 92; i++)
            {
                double y = i * 0.1 - ValueA;
                double x = -3.679744 + 2.401154 * y - 0.1371795 * Math.Pow(y, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function6(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 5586; i <= 6650; i++)
            {
                double y = i * 0.001 - ValueA;
                double x = -3.7653 + 3.59971 * y - 0.316192 * Math.Pow(y, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function7(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 553; i <= 663; i++)
            {
                double y = i * 0.01 - ValueA;
                double x = 12.9108 - 3.51498 * y + 0.309246 * Math.Pow(y, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function8(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 385; i <= 559; i++)
            {
                double y = i * 0.01 - ValueA;
                double x = -5.55076 + 4.90715 * y - 0.492709 * Math.Pow(y, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function9(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 392; i <= 550; i++)
            {
                double y = i * 0.01 - ValueA;
                double x = 16.7401 - 5.66103 * y + 0.572103 * Math.Pow(y, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }
        #endregion

        #region Fuction10~16 臉

        void Function10(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 0; i <= 200; i++)
            {
                double theta = 0.01* i * Math.PI;
                double r = 0.25;
                double x0 = 3.7;
                double y0 = 5.52;
                double x = x0 + r * Math.Cos(theta);
                double y = y0 + r * Math.Sin(theta);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function11(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 0; i <= 200; i++)
            {
                double theta = 0.01 * i * Math.PI;
                double r = 0.25;
                double x0 = 5.6;
                double y0 = 5.52;
                double x = x0 + r * Math.Cos(theta);
                double y = y0 + r * Math.Sin(theta);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function12(double ValueA)
        {
            // (( (7x - 32.75)^2 + (11y - 56.25)^2 - 1 )^3
            //  = (7x - 32.75)^2 * (11y -56.25)^3
        }

        void Function13(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 42; i <= 47; i++)
            {
                double x = i * 0.1 - ValueA;
                double y = 0.5 * Math.Abs(x - 4.4) + 4.6;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function14(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 47; i <= 52; i++)
            {
                double x = i * 0.1 - ValueA;
                double y = 0.5 * Math.Abs(x - 5) + 4.6;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function15(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 0; i <= 200; i++)
            {
                double theta = 0.01 * i * Math.PI;
                double r = 0.3;
                double x0 = 3.3;
                double y0 = 4.55;
                double x = x0 + r * Math.Cos(theta);
                double y = y0 + r * Math.Sin(theta);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function16(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 0; i <= 200; i++)
            {
                double theta = 0.01 * i * Math.PI;
                double r = 0.3;
                double x0 = 6;
                double y0 = 4.52;
                double x = x0 + r * Math.Cos(theta);
                double y = y0 + r * Math.Sin(theta);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }
        #endregion

        #region Fuction17~29 身體
        void Function17(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 1177; i <= 3976; i++)
            {
                double y = i * 0.001 - ValueA;
                double x = 5.95883 + 0.589144 * y - 0.127226 * Math.Pow(y, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function18(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 850; i <= 1177; i++)
            {
                double y = i * 0.001 - ValueA;
                double x = -0.723516 + 12.6347 * y - 5.53771 * Math.Pow(y, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function19(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 62; i <= 68; i++)
            {
                double x = i * 0.1 - ValueA;
                double y = 1034.44 - 484.967 * x + 75.875 * Math.Pow(x, 2) - 3.95833 * Math.Pow(x, 3);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function20(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 54; i <= 68; i++)
            {
                double x = i * 0.1 - ValueA;
                double y = 40.9843 - 19.9179 * x + 3.26786 * Math.Pow(x, 2) - 0.178571 * Math.Pow(x, 3);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function21(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 54; i <= 55; i++)
            {
                double x = i * 0.1 - ValueA;
                double y = 1.5 * (x - 5.4) + 0.6;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function22(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 407; i <= 550; i++)
            {
                double x = i * 0.01 - ValueA;
                double y = -10.848 + 7.15799 * x - 1.46547 * Math.Pow(x, 2) + 0.0995312 * Math.Pow(x, 3);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function23(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 49; i <= 72; i++)
            {
                double y = i * 0.01 - ValueA;
                double x = 2.81539 + 2.92656*y + 0.447319 * Math.Pow(y, 2) - 2.90533 * Math.Pow(y, 3);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function24(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 2814; i <= 4015; i++)
            {
                double x = i * 0.001 - ValueA;
                double y = 2.71884 - 2.06851 * x + 0.624823 * Math.Pow(x, 2) - 0.0617413 * Math.Pow(x, 3);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function25(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 470; i <= 757; i++)
            {
                double y = i * 0.001 - ValueA;
                double x = 4.96742 - 9.24249 * y + 11.6411 * Math.Pow(y, 2) - 3.66935 * Math.Pow(y, 3);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function26(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 305; i <= 356; i++)
            {
                double x = i * 0.01 - ValueA;
                double y = 0.2 * x + 0.15;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function27(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 823; i <= 1200; i++)
            {
                double y = i * 0.001 - ValueA;
                double x = 8.60766 - 9.44805 * y + 3.99818 * Math.Pow(y, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function28(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 119; i <= 228; i++)
            {
                double y = i * 0.01 - ValueA;
                double x = 3.89932 - 1.06878 * y + 0.272044 * Math.Pow(y, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function29(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 2200; i <= 3964; i++)
            {
                double y = i * 0.001 - ValueA;
                double x = 3.72783 - 0.688783 * y + 0.140805 * Math.Pow(y, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }
        #endregion

        #region Fuction31~ 尾巴
        void Function30(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 259; i <= 290; i++)
            {
                double x = i * 0.01 - ValueA;
                double y = -0.1 * x + 1.74;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function31(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 259; i <= 274; i++)
            {
                double x = i * 0.01 - ValueA;
                double y = 2 * x - 3.7;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function32(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 22; i <= 27; i++)
            {
                double x = i * 0.1 - ValueA;
                double y = -0.1 * x + 2.09;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function33(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 214; i <= 243; i++)
            {
                double x = i * 0.01 - ValueA;
                double y = 2.1 * x - 2.6;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function34(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 15; i <= 24; i++)
            {
                double x = i * 0.1- ValueA;
                double y = 2.5;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function35(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 150; i <= 205; i++)
            {
                double x = i * 0.01 - ValueA;
                double y = 2 * x - 0.5;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function36(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 80; i <= 210; i++)
            {
                double x = i * 0.01 - ValueA;
                double y = 3.03818 + 0.632359 * x - 0.178223 * Math.Pow(x, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function37(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 16; i <= 80; i++)
            {
                double x = i * 0.01 - ValueA;
                double y = -2.3 * x + 5.3;

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function38(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 10; i <= 275; i++)
            {
                double x = i * 0.01 - ValueA;
                double y = 4.92296 + 0.133296 * x - 0.0826966 * Math.Pow(x, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function39(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 243; i <= 310; i++)
            {
                double x = i * 0.01 - ValueA;
                double y = -5.24816 + 4.97243 * x - 0.634191 * Math.Pow(x, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function40(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 245; i <= 290; i++)
            {
                double x = i * 0.01 - ValueA;
                double y = 2.24242 + 0.7376 * x - 0.16 * Math.Pow(x, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }
        #endregion

        #region Function41~ 手
        void Function41(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 329; i <= 383; i++)
            {
                double x = i * 0.01 - ValueA;
                double y = 19.8423 - 8.59158 * x + 1.04803 * Math.Pow(x, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function42(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 383; i <= 422; i++)
            {
                double x = i * 0.01 - ValueA;
                double y = 58.9253 - 28.6634 * x + 3.62438 * Math.Pow(x, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function43(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 251; i <= 332; i++)
            {
                double y = i * 0.01 - ValueA;
                double x = 1.62487 + 2.12359 * y - 0.434134 * Math.Pow(y, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function44(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 262; i <= 332; i++)
            {
                double y = i * 0.01 - ValueA;
                double x = 7.57962  - 1.8249 * y + 0.367347 * Math.Pow(y, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function45(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 233; i <= 262; i++)
            {
                double y = i * 0.01 - ValueA;
                double x = 44.579 - 30.5929 * y + 5.95747 * Math.Pow(y, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }

        void Function46(double ValueA)
        {
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();

            for (int i = 564; i <= 606; i++)
            {
                double x = i * 0.01 - ValueA;
                double y = 15.8276 - 5.46259 * x + 0.5442186 * Math.Pow(x, 2);

                listX.Add(x);
                listY.Add(y);
            }
            listDoubleArrayX.Add(listX.ToArray());
            listDoubleArrayY.Add(listY.ToArray());
        }
        #endregion

        void DrawCurve()
        {
            listDoubleArrayX.Clear();
            listDoubleArrayY.Clear();

            double ValueA = Convert.ToDouble(hsbValueA.Value);
            lbValueA.Text = Convert.ToString(ValueA);

            Function1(ValueA);
            Function2(ValueA);
            Function3(ValueA);
            Function4(ValueA);
            Function5(ValueA);
            Function6(ValueA);
            Function7(ValueA);
            Function8(ValueA);
            Function9(ValueA);
            Function10(ValueA);
            Function11(ValueA);
            //Function12(ValueA);
            Function13(ValueA);
            Function14(ValueA);
            Function15(ValueA);
            Function16(ValueA);
            Function17(ValueA);
            Function18(ValueA);
            Function19(ValueA);
            Function20(ValueA);
            Function21(ValueA);
            Function22(ValueA);
            Function23(ValueA);
            Function24(ValueA);
            Function25(ValueA);
            Function26(ValueA);
            Function27(ValueA);
            Function28(ValueA);
            Function29(ValueA);

            Function30(ValueA);
            Function31(ValueA);
            Function32(ValueA);
            Function33(ValueA);
            Function34(ValueA);
            Function35(ValueA);
            Function36(ValueA);
            Function37(ValueA);
            Function38(ValueA);
            Function39(ValueA);
            Function40(ValueA);

            Function41(ValueA);
            Function42(ValueA);
            Function43(ValueA);
            Function44(ValueA);
            Function45(ValueA);
            Function46(ValueA);

            BuildGraph(ZGraphDraw, listDoubleArrayX, listDoubleArrayY);
        }

        Color RandomColor()
        {
            int index = random.Next(Listcolors.Count);
            string color = Listcolors[index];
            return ColorTranslator.FromHtml(color);
        }

        List<string> Listcolors = new List<string>()
        {
            "#3F51B5",
            "#009688",
            "#FF5722",
            "#607D8B",
            "#FF9800",
            "#9C27B0",
            "#2196F3",
            "#EA676C",
            "#E41A4A",
            "#5978BB",
            "#018790",
            "#0E3441",
            "#00B0AD",
            "#721D47",
            "#EA4833",
            "#EF937E",
            "#F37521",
            "#A12059",
            "#126881",
            "#8BC240",
            "#364D5B",
            "#C7DC5B",
            "#0094BC",
            "#E4126B",
            "#43B76E",
            "#7BCFE9",
            "#B71C46"
        };
    }
}