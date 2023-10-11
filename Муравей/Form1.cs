using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;




namespace Муравей
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        AntColonySet antColony = new AntColonySet();
        Graph graph = new Graph();

        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Text = "N/A";
            label10.Text = "N/A";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                antColony.CountAnt = Convert.ToInt32(countAntInp.Text);
                antColony.CountIter = Convert.ToInt32(countIterInp.Text);
                antColony.Alpha = Convert.ToDouble(alphaInp.Text);
                antColony.Beta = Convert.ToDouble(betaInp.Text);
                antColony.Pheromon = Convert.ToDouble(pheromonInp.Text);
                antColony.VaporSpeed = Convert.ToDouble(vaporSpeedInp.Text);
                label9.Text = "Выполняется муравьиный алгоритм. Подробный результат будет \nпредставлен в файле output.txt";
                AntAlgorithm antAlgorithm = new AntAlgorithm();
                antAlgorithm.AntColony = antColony;
                antAlgorithm.Graph = graph;
                antAlgorithm.antAlg();
                string bestWay = "";
                for (int way = 0; way < antAlgorithm.FinalTrack.Count; way++)
                {
                    bestWay += antAlgorithm.FinalTrack[way].ToString() + " ";
                }
                label8.Text = antAlgorithm.GlobalShortestTrack.ToString();
                label10.Text = bestWay.ToString();
            }
            catch (Exception)
            {
                label9.Text = "Введены не все параметры и/или не выбран файл, \nлибо предаставлены некорректные данные";
            }
            
        }

        private async Task parseFileAsync(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            string number = "";
            int currentVertex = 0;
            while (!reader.EndOfStream)
            {

                string line = reader.ReadLine();

                if (graph.getVertex() == 0)
                {
                    graph.setVertex(Convert.ToInt32(line));
                }
                else
                {
                    List<int> matrixLine = new List<int>();
                    for (int i = 0; i < line.Length; i++)
                    {

                        while (line[i] != ' ')
                        {
                            number += line[i];
                            if (i == line.Length - 1)
                            {
                                break;
                            }
                            i++;
                        }
                        if (line[i] == ' ' || i == line.Length - 1)
                        {

                            matrixLine.Add(Convert.ToInt32(number));
                            number = "";

                        }
                    }
                    graph.setEdges(matrixLine, currentVertex);
                    currentVertex++;
                    matrixLine.Clear();

                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            parseFileAsync(filename);
        }

    }
}
