using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDO;

namespace EDOModeling
{
    public partial class Form1 : Form
    {
        //diff equation
        Function function;
        //explicit solution
        Function solution;
        //isoclines function
        Function isoclines;
        //directions field slopes
        double[] slopes;
        //size of the picBox
        int size;
        //length in units of the axes
        int units;

        double pixelsPerUnit;
        double unitsPerPixel;

        //step in between each line of the directions field(pixels)
        int step;
        //length of the lines of the directions field
        int lineLength;
        //step in between each point of the solution graph
        float precision;

        //x sub 0 and y sub 0 values of the PVI
        double x0;
        double y0;
        //iterations of Eulers method
        int iterations;

        //isoclines
        double isoTopValue, isoBotValue, isoDensity;

        bool showEuler, showDF, showSolution, showIsoclines;
        

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(750,580);
            function = Function.Read(txtFunction.Text);
            solution = Function.Read(txtSolution.Text);
            isoclines = Function.Read(txtIsoclines.Text);

            slopes = new double[300 * 300];
            size = pboxBoard.Width;

            units = (int)numudUnits.Value;
            step = (int)numudStep.Value;
            lineLength = (int)numudSlopeLength.Value;
            precision = (float)numudPrecision.Value;

            pixelsPerUnit = (double)size / units;
            unitsPerPixel = (double)units / size;

            numudX.Value = 4;
            numudY.Value = (decimal)Math.PI / 4;

            numudIsoBot.Minimum = int.MinValue;
            numudIsoTp.Maximum = int.MaxValue;
            numudIsoBot.Maximum = numudIsoTp.Value;
            numudIsoTp.Minimum = numudIsoBot.Value;
            isoDensity = (double)numudIsoStep.Value;
            isoTopValue= (double)numudIsoTp.Value;
            isoBotValue = (double)numudIsoBot.Value;

            x0 = (double)numudX.Value;
            y0 = (double)numudY.Value;
            iterations = (int)numudIter.Value;

            showEuler = showSolution = showDF = showIsoclines = true;
            GetSlopes();            
        }

        private void GetSlopes()
        {
            int k = 0;
            for (int i = 0; i < size; i +=step)
                for (int j = 0; j < size; j += step)
                {
                    double[] point = GetPoint(i + step / 2, j + step / 2);
                    double x = point[0];
                    double y = point[1];
                    try
                    {
                        slopes[k] = EDO.EDO.Evaluator(x, y, function, 'x', 'y');
                        k++;
                    }
                     catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
                }
        }

        private double[] GetPoint(int x, int y)
        {
            return new double[2] { x * unitsPerPixel, -(y * unitsPerPixel - units / 2) };
        }
        private int[] GetPixel(double a, double b)
        {
            return new int[2] { (int)(a * pixelsPerUnit), (int)((-b + units / 2) * pixelsPerUnit) };
        }

        private void imgboxBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 2);
            Brush br = new SolidBrush(Color.Black);
            Font f = new Font("Arial", 12);
            Pen pGreen = new Pen(Color.Green, 1);
            Pen pRed = new Pen(Color.Red, 1);
            Pen pBlue = new Pen(Color.Blue, 1);
            Pen pPurple = new Pen(Color.Purple, 1);

            //axes
            g.DrawString("y", f, br, 5, 5);
            g.DrawString("x", f, br, size-17, size/2+5);
            g.DrawLine(p, 0, 0, 0, size);
            g.DrawLine(p, 0, size / 2, size, size / 2);

            //directions field
            if (showDF)
            {
                int k = 0;
                for (int i = 0; i < size; i += step)
                    for (int j = 0; j < size; j += step)
                    {
                        double[] point = GetPoint(i + step / 2, j + step / 2);
                        double x = point[0];
                        double y = point[1];

                        double a = Math.Sqrt(Math.Pow(lineLength * unitsPerPixel, 2) / (1 + Math.Pow(slopes[k], 2)));
                        double b = a * slopes[k];
                        int[] points = GetPixel(x + a, y + b);
                        int p1x = points[0];
                        int p1y = points[1];
                        points = GetPixel(x - a, y - b);
                        int p2x = points[0];
                        int p2y = points[1];

                        g.DrawLine(pGreen, p1x, p1y, p2x, p2y);
                        k++;
                    }
            }

            //solution
            //setting starting point
            if (showSolution)
            {
                double y1 = EDO.EDO.ResultEvaluator(0, solution);
                int[] points1 = GetPixel(0, y1);
                int pxPrev = points1[0];
                int pyPrev = points1[1];

                for (double i = precision; i < units; i += precision)
                {
                    try
                    {
                        double y = EDO.EDO.ResultEvaluator(i, solution);
                        int[] points = GetPixel(i, y);
                        int px = points[0];
                        int py = points[1];
                        if (px >= 0 && px <= size && py >= 0 && py <= size)
                        {
                            g.DrawLine(pRed, px, py, pxPrev, pyPrev);
                            pxPrev = px;
                            pyPrev = py;
                        }
                    }
                    catch { }
                }
            }

            if (showEuler)
            {
                //Eulers method
                int[] points0 = GetPixel(x0, y0);
                int pxPrev = points0[0];
                int pyPrev = points0[1];

                //forward
                foreach (double[] point in EDO.EDO.EulerMethod(x0, y0, units, iterations, function))
                {
                    int[] points = GetPixel(point[0], point[1]);
                    int px = points[0];
                    int py = points[1];
                    if (px >= 0 && px <= size && py >= 0 && py <= size)
                    {
                        g.DrawLine(pPurple, px, py, pxPrev, pyPrev);
                        pxPrev = px;
                        pyPrev = py;
                    }
                }

                pxPrev = points0[0];
                pyPrev = points0[1];

                //backward
                foreach (double[] point in EDO.EDO.EulerMethod(x0, y0, 0, iterations, function))
                {
                    int[] points = GetPixel(point[0], point[1]);
                    int px = points[0];
                    int py = points[1];
                    if (px >= 0 && px <= size && py >= 0 && py <= size)
                    {
                        g.DrawLine(pPurple, px, py, pxPrev, pyPrev);
                        pxPrev = px;
                        pyPrev = py;
                    }
                }
            }

            //isoclines
            if (showIsoclines)
            {
                int pxPrev = 0, pyPrev = 0;
                for (double m = isoBotValue; m < isoTopValue; m += isoDensity)
                {
                    bool first = true;
                    for (double x = 0; x < units; x += precision)
                    {
                        if (first)
                        {
                            try
                            {
                                double y1 = EDO.EDO.Evaluator(m, x, isoclines, 'm', 'x');
                                int[] point1 = GetPixel(x, y1);

                                if (point1[0] >= 0 && point1[0] <= size && point1[1] >= 0 && point1[1] <= size)
                                {
                                    pxPrev = point1[0];
                                    pyPrev = point1[1];
                                    first = false;
                                }
                            }
                            catch { }
                        }
                        else
                        {
                            try
                            {
                                double y = EDO.EDO.Evaluator(m, x, isoclines, 'm', 'x');
                                int[] point = GetPixel(x, y);
                                int px = point[0];
                                int py = point[1];
                                if (px >= 0 && px <= size && py >= 0 && py <= size)
                                {
                                    g.DrawLine(pBlue, px, py, pxPrev, pyPrev);
                                    pxPrev = px;
                                    pyPrev = py;
                                }
                            }
                            catch { }
                        }
                    }
                }
            }
        }

        private void numudStep_ValueChanged(object sender, EventArgs e)
        {
            step = (int)numudStep.Value;
            GetSlopes();
            pboxBoard.Refresh();
        }

        private void numudSlopeLength_ValueChanged(object sender, EventArgs e)
        {
            lineLength = (int)numudSlopeLength.Value;
            pboxBoard.Refresh();
        }

        private void numudUnits_ValueChanged(object sender, EventArgs e)
        {
            units = (int)numudUnits.Value;
            pixelsPerUnit = (double)size / units;
            unitsPerPixel = (double)units / size;

            GetSlopes();
            pboxBoard.Refresh();
        }

        private void numudPrecision_ValueChanged(object sender, EventArgs e)
        {
            precision = (float)numudPrecision.Value;
            pboxBoard.Refresh();
        }

        private void numudX_ValueChanged(object sender, EventArgs e)
        {
            x0 = (double)numudX.Value;
            pboxBoard.Refresh();
        }

        private void numudY_ValueChanged(object sender, EventArgs e)
        {
            y0 = (double)numudY.Value;
            pboxBoard.Refresh();
        }

        private void chboxDF_CheckedChanged(object sender, EventArgs e)
        {
            showDF = chboxDF.Checked;
            pboxBoard.Refresh();
        }

        private void numudIsoBot_ValueChanged(object sender, EventArgs e)
        {
            isoBotValue = (double)numudIsoBot.Value;
            numudIsoTp.Minimum = (decimal)isoBotValue;
            pboxBoard.Refresh();
        }

        private void numudIsoTp_ValueChanged(object sender, EventArgs e)
        {
            isoTopValue = (double)numudIsoTp.Value;
            numudIsoBot.Maximum = (decimal)isoTopValue;
            pboxBoard.Refresh();
        }

        private void numudIsoStep_ValueChanged(object sender, EventArgs e)
        {
            isoDensity = (double)numudIsoStep.Value;
            pboxBoard.Refresh();
        }

        private void chboxSolution_CheckedChanged(object sender, EventArgs e)
        {
            showSolution = chboxSolution.Checked;
            pboxBoard.Refresh();
        }

        private void chBoxIso_CheckedChanged(object sender, EventArgs e)
        {
            showIsoclines = chBoxIso.Checked;
            pboxBoard.Refresh();
        }

        private void chboxEuler_CheckedChanged(object sender, EventArgs e)
        {
            showEuler = chboxEuler.Checked;
            pboxBoard.Refresh();
        }

        private void numudIter_ValueChanged(object sender, EventArgs e)
        {
            iterations = (int)numudIter.Value;
            pboxBoard.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                function = Function.Read(txtFunction.Text);
                solution = Function.Read(txtSolution.Text);
                isoclines = Function.Read(txtIsoclines.Text);
                GetSlopes();
                pboxBoard.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
