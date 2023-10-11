using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Муравей
{
    internal class AntAlgorithm
    {
        private AntColonySet antColony = new AntColonySet();
        private Graph graph = new Graph();
        private Random random = new Random();
        private List<int> finalTrack = new List<int>();
        private int globalShortestTrack = int.MaxValue;
        private int globalQ = 4;

        public Random Random { get => random; set => random = value; }
        public List<int> FinalTrack { get => finalTrack; set => finalTrack = value; }
        public int GlobalShortestTrack { get => globalShortestTrack; set => globalShortestTrack = value; }
        public int GlobalQ { get => globalQ; set => globalQ = value; }
        internal AntColonySet AntColony { get => antColony; set => antColony = value; }
        internal Graph Graph { get => graph; set => graph = value; }

        public void antAlg()
        {

            List<List<double>> trackPheromon = new List<List<double>>();
            for (int i = 0; i < graph.getVertex(); i++)
            {
                List<double> line = new List<double>();
                for (int j = 0; j < graph.getVertex(); j++)
                {
                    if (graph.getEdges()[i][j] != 0)
                    {
                        line.Add(antColony.Pheromon);
                    }
                    else
                    {
                        line.Add(0);
                    }
                }
                trackPheromon.Add(line);
            }

            for (int iteration = 0; iteration < antColony.CountIter; iteration++) //задали кол-во итераций
            {
                List<List<int>> trackOfAnt = new List<List<int>>();
                for (int i = 0; i < antColony.CountAnt; i++)
                {
                    trackOfAnt.Add(new List<int>());
                }

                for (int antNumber = 0; antNumber < antColony.CountAnt; antNumber++) //количество муравьев(путей) на итерации
                {
                    List<int> visitedVertex = new List<int>();                       //какие вершины муравей посетил

                    int currVertex = random.Next(0, graph.getVertex()); //случайно выбираем первую вершину
                    int startVertex = currVertex;
                    visitedVertex.Add(currVertex);
                    for (int visit = 0; visit < graph.getVertex() + 1; visit++) //необходимо посетить все вершины (включая первую, чтобы замкнуть путь)
                    {
                        List<int> canVisit = new List<int>();   //список для вершин, которые можем посетить из текущей
                        List<double> possibilities = new List<double>(); //матрица вероятностей пойти из i в j

                        for (int neighbourVertex = 0; neighbourVertex < graph.getVertex(); neighbourVertex++) //считаем вершины, которые можем посетить
                        {
                            if (graph.getEdges()[currVertex][neighbourVertex] != 0 && !visitedVertex.Contains(neighbourVertex))
                            { //если между вершинами есть путь и мы ещё не посещали эту вершину
                                canVisit.Add(neighbourVertex);           //то добавляем её в список тех, которые можем посетить
                            }
                        }

                        if (visit == graph.getVertex()) { canVisit.Add(startVertex); } //на последнем посещении для возвращения в первую вершину

                        //if (canVisit.Count == 0) { break; } //если закончились вершины

                        for (int currNeighbour = 0; currNeighbour < canVisit.Count; currNeighbour++)
                        {       //считаем вероятности для посещения вершины P(i,j)
                            possibilities.Add(
                                Math.Pow(trackPheromon[currVertex][canVisit[currNeighbour]], antColony.Alpha) *
                                Math.Pow((1.0d / graph.getEdges()[currVertex][canVisit[currNeighbour]]), antColony.Beta));
                        }


                        double possibilitiesSum = possibilities.Sum();
                        for (int possibilityToCity = 0; possibilityToCity < possibilities.Count; possibilityToCity++)
                        { //пересчитываем по формуле новые вероятности
                            possibilities[possibilityToCity] = (possibilities[possibilityToCity]) / possibilitiesSum;
                        }

                        double toGo = 0;

                        if (possibilities.Count > 0)
                        {
                            toGo = random.NextDouble(); //определяем случайно число от 0 до 1}
                        }

                        double toChoose = 0; //для подсчёта суммы

                        int toVertex = 0; //для следующей врешины

                        while (toChoose < toGo)
                        {   //ищем вершину, попавшую в вероятность
                            toChoose += possibilities[toVertex];
                            toVertex++;
                        }
                        toVertex--;

                        if (visit != 0 && visit < graph.getVertex())
                        {
                            visitedVertex.Add(currVertex);
                        } //добавляем обработанную в посещенные 

                        if (possibilities.Count > 0)
                        {
                            currVertex = canVisit[toVertex]; //следующая вершина становится текущей
                        }

                        if (visit == graph.getVertex())
                        {
                            visitedVertex.Add(currVertex);
                        }

                    }//один муравей прошёл

                    trackOfAnt[antNumber] = visitedVertex; //сохраняем пути, пройденные каждым муравьём на итерации

                }

                //прошли все на одной итерации

                for (int i = 0; i < trackPheromon.Count; i++)   //испаряем феромон для новой итерации
                {
                    for (int j = 0; j < trackPheromon[i].Count; j++)
                    {
                        trackPheromon[i][j] *= antColony.VaporSpeed;
                    }
                }

                int shortestTrackOnIter = int.MaxValue; //кратчайший путь итерации
                int bestAntOnIter = 0;

                for (int ant = 0; ant < antColony.CountAnt - 1; ant++) //добавляем феромон в зависимости от маршрутов
                {
                    int trackLength = 0;
                    for (int curr = 0; curr < graph.getVertex(); curr++) //считаем длину пути (+1переход к старту)
                    {
                        trackLength += graph.getEdges()[trackOfAnt[ant][curr]][trackOfAnt[ant][curr + 1]];
                    }

                    if (trackLength < shortestTrackOnIter) //подсчёты для вывода
                    {
                        shortestTrackOnIter = trackLength;
                        bestAntOnIter = ant;
                    }

                    for (int curr = 0; curr < graph.getVertex(); curr++) //добавляем феромон к пути
                    {
                        trackPheromon[trackOfAnt[ant][curr]][trackOfAnt[ant][curr + 1]] += globalQ / trackLength;
                    }
                }

                if (globalShortestTrack > shortestTrackOnIter) //записываем лучший результат 
                {
                    globalShortestTrack = shortestTrackOnIter;
                    finalTrack = trackOfAnt[bestAntOnIter];
                }
                outPut(iteration, trackOfAnt, bestAntOnIter, shortestTrackOnIter);
                //вывод в output номер итерации, все пути, длина shortest, сам путь через trackOfAnt[bestAnt]

            }

        }

        private void outPut(int iteration, List<List<int>> trackOfAnt, int bestAntOnIter, int shortesrTrackOnIter)
        {
            string bestWay = "";
            for (int way = 0; way < trackOfAnt[bestAntOnIter].Count; way++)
            {
                bestWay += trackOfAnt[bestAntOnIter][way].ToString() + " ";
            }
            string textToOut = "Итерация № " + (iteration + 1).ToString() + "\n";
            for (int way = 1; way < antColony.CountAnt; way++)
            {
                textToOut += "Путь № " + way.ToString() + "\n";
                string currWay = "";
                for (int ver = 0; ver < trackOfAnt[way].Count; ver++)
                {
                    currWay += trackOfAnt[way][ver].ToString() + " ";
                }
                currWay += "\n";
                textToOut += currWay;
            }
            textToOut += "Лучший путь: " + bestWay + "\nЕго длина: " + shortesrTrackOnIter.ToString() + "\n" + "\n";
            string path = @"D:\My projects\VS repos\AntAlg\out.txt";
            if (iteration == 0)
            {
                FileStream fsAppend = new FileStream(path, FileMode.Create);
                using (StreamWriter writer = new StreamWriter(fsAppend))
                {
                    writer.Write(textToOut);
                }
            }
            else
            {
                FileStream fsAppend = new FileStream(path, FileMode.Append);
                using (StreamWriter writer = new StreamWriter(fsAppend))
                {
                    writer.Write(textToOut);
                }
            }

        }
    }
}
