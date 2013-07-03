using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace RungeKutta4
{
    public partial class FormMy : Form
    {
        public static double a, b, x0, y0, h;
        public static int countDots = 0;
        public static Massive X;
        public static Massive Y;
        public static int precision; //точность

        public FormMy()
        {
            InitializeComponent();
            zedGraph.GraphPane.Title.Text = "Метод Рунге-Кутты";
        }

        public double f(double x, double y)
        {
            return Math.Pow(x,-1) / y;
        }

        public void readVariables()
        {
            a = Convert.ToDouble(textBox_a.Text);
            b = Convert.ToDouble(textBox_b.Text);
            x0 = Convert.ToDouble(textBox_x0.Text);
            y0 = Convert.ToDouble(textBox_y0.Text);
            if (textBox_h.Text.Contains('.') == true)
            {
                textBox_h.Text = textBox_h.Text.Replace('.', ',');
            }
            h = Convert.ToDouble(textBox_h.Text);
            precision = Convert.ToInt32(textBox1.Text);
            checkVariables();
            
        }
        // валидация параметров
        private void checkVariables()
        {
            if (b < a)
            {
                throw new Exception("a не может быть больше b! Указан неверный диапазон");
            }
            if (b <= x0)
            {
                throw new Exception("x0 не может быть больше или равно b. Указан неверный диапазон");
            }

        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            try
            {
                readVariables();

                countDots = Convert.ToInt32(((b - a) / h));

                X = new Massive(countDots, precision);
                Y = new Massive(countDots, precision);

                X[0] = a;

                for (int i = 0; i < countDots - 1; ++i)
                {
                    X[i + 1] = X[i] + h;
                    if (X[i] == b) break;
                }

                Y[0] = y0;

                double k1 = 0.0, k2 = 0.0, k3 = 0.0, k4 = 0.0;

                for (int i = 0; i < countDots - 1; ++i)
                {
                    k1 = h * f(X[i], Y[i]);
                    k2 = h * f(X[i] + h / 2, Y[i] + 1 / 2 * k1);
                    k3 = h * f(X[i] + h / 2, Y[i] + 1 / 2 * k2);
                    k4 = h * f(X[i] + h, Y[i] + k3);
                    Y[i + 1] = Y[i] + (k1 + (2 * k2) + (2 * k3) + k4) / 6;
                }


                GraphPane pane = zedGraph.GraphPane;
                pane.CurveList.Clear();
                PointPairList list = new PointPairList();
                for (int j = 0; j < countDots; ++j)
                {
                    list.Add(X[j], Y[j]);
                }
                LineItem myCurve = pane.AddCurve("y' = 1 / xy", list, Color.Green, SymbolType.None);
                zedGraph.AxisChange();
                zedGraph.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.Show();
        }

        private void RandomSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            // получаем точность 
            int presision = rnd.Next(1, 5);
            textBox1.Text = presision.ToString();
            //получаем параметр a
            textBox_a.Text = Math.Round(rnd.NextDouble() * 10, presision).ToString();
            textBox_b.Text = Math.Round(rnd.NextDouble() * 10, presision).ToString();
            textBox_x0.Text = Math.Round(rnd.NextDouble() * 10, presision).ToString();
            textBox_y0.Text = Math.Round(rnd.NextDouble() * 10, presision).ToString();
            textBox_h.Text = Math.Round(rnd.NextDouble() / 1, 1).ToString();
        }

        private void изФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (ofd.ShowDialog() != DialogResult.Cancel)
            {
                string fileName = ofd.FileName;
                //Открываем файл и считываем из него данные построчно
                if (fileName != null && fileName != "")
                {

                    StreamReader reader = new StreamReader(fileName);
                    try
                    {
                        textBox_a.Text = reader.ReadLine();
                        textBox_b.Text = reader.ReadLine();
                        textBox_x0.Text = reader.ReadLine();
                        textBox_y0.Text = reader.ReadLine();
                        textBox_h.Text = reader.ReadLine();
                        textBox1.Text = reader.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        reader.Close();
                    }
                }
            }
        }
        // Задание данных по формуле y=0.1*x+x
        private void FormulaSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // сгененерируем х для а
            Random rnd = new Random();
            int x = rnd.Next(0, 10);
            textBox_a.Text = (0.1 * x + x).ToString();
            // сгененерируем х для b
            x = rnd.Next(x, x + 10);
            textBox_b.Text = (0.1 * x + x).ToString();
            // устанавливаем для х0 значение а
            textBox_x0.Text = textBox_a.Text;
            // устанавливаем для y0 значение 0
            textBox_y0.Text = "0";
            //устанавливаем для h значение
            double h0 = ((double)rnd.Next(1, 10)) / 10;
            textBox_h.Text = (0.1 * h0 + h0).ToString();

            //устанавливаем точность
            textBox1.Text = (rnd.Next(1, 5)).ToString();
        }
        // Сохранение в текстовый файл
        private void ToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (sfd.ShowDialog() != DialogResult.Cancel)
            {
                string fileName = sfd.FileName;
                //Записываем в файл данные построчно
                if (fileName != null && fileName != "")
                {

                    StreamWriter writer = new StreamWriter(fileName);
                    try
                    {
                        for (int i = 0; i < countDots; i++)
                        {
                            writer.WriteLine("X: " + X[i].ToString() + " , Y: " + Y[i].ToString());
                        }
                        writer.Flush();
                        MessageBox.Show("Сохранение в текстовый файл завершено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        writer.Close();
                    }
                }
            }
        }
        // Сохранение в файл Word
        private void ToWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // вывод отчета в ворд
                Microsoft.Office.Interop.Word.Application msWord;

                Microsoft.Office.Interop.Word.Document doc;

                object objMiss;

                object endofdoc = "\\endofdoc";

                msWord = new Microsoft.Office.Interop.Word.Application();
                objMiss = System.Reflection.Missing.Value;
                msWord.Visible = true;

                doc = msWord.Documents.Add(ref objMiss, ref objMiss, ref objMiss, ref objMiss);

                Microsoft.Office.Interop.Word.Table tbl1;

                Microsoft.Office.Interop.Word.Range wordRange = doc.Bookmarks.get_Item(ref endofdoc).Range;

                int rowsNum = countDots + 1;

                tbl1 = doc.Content.Tables.Add(wordRange, rowsNum, 2, ref objMiss, ref objMiss);

                tbl1.Borders.Enable = 1;

                tbl1.Cell(1, 1).Range.Text = "Координата Х";
                tbl1.Cell(1, 2).Range.Text = "Координата Y";

                // добавляем в таблицу данные
                for (int i = 2; i <= rowsNum; i++)
                {

                    // добавляем текст
                    tbl1.Cell(i, 1).Range.Text = X[i - 2].ToString();
                    tbl1.Cell(i, 2).Range.Text = Y[i - 2].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
