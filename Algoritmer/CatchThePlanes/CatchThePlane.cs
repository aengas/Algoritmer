using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Algoritmer.CatchThePlanes
{
    public static class CatchThePlane
    {
        private static List<Node> s_pathList;
        
        public static void Calculate(IConsole console)
        {
            // Steg 1: Les input
            (int pathCount, int stationCount, long maxArriveTime, List<Node> pathList) input = LoadInput(console);
            s_pathList = input.pathList;
            
            // Steg 2: Lag en virtuell initiell node
            var initNode = new Node(0, 0, 0, -1, 1);
            
            // Steg 3: Kjør metoden for å lage treet
            BuildTree(initNode);
            
            // Steg 4: Kjør metoden som skal beregne sannsynlighet
            console.WriteLine(CalculateProbability(initNode).ToString(CultureInfo.InvariantCulture));
        }

        // Bygg et tre fra en rutetabell

        private static void BuildTree(Node node)
        {
            if (node != null)
            {
                // Fallback finner alle veier som starter fra den siste avgangen og legger alle til det høyre sub-treet
                List<Node> rightStations = FindNodeStartAs(node.StartStation, node.StartTime);
                
                // Finn alle rutene som starter på den nåværende stasjon og velg den første som det venstre sub-treet
                List<Node> leftStations = FindNodeStartAs(node.EndStation, node.EndTime);
                Node leftNode = null;
                if (leftStations.Count > 0)
                {
                    leftNode = leftStations[0];
                }
                
                // Uansett hva sannsynligheten er, den første avgående bussen er satt til leftNode
                if (node.EndStation != 1)
                {
                    node.LeftNode = leftNode;
                }
                // Lag venstre tre rekursivt
                BuildTree(node.LeftNode);
                
                // Siden avgangssansynligheten er mindre enn 1, så trengs andre hensyn slik at et høyre sub-tre blir laget
                if (node.PT < 1)
                {
                    node.RightNodes = rightStations;
                    // Bygg det høyre sub-treet rekursivt
                    foreach (Node rnode in node.RightNodes)
                    {
                        BuildTree(rnode);
                    }
                }
                    
            }
        }

        private static List<Node> FindNodeStartAs(long startStation, long lastEndTime)
        {
            var stations = new List<Node>();
            foreach (Node node in s_pathList)
            {
                if (node.StartStation == startStation && node.StartTime > lastEndTime)
                {
                    stations.Add(node);
                }
            }

            return stations;
        }

        private static double CalculateProbability(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            
            // Finn maksimum sannsynlighet på det høyre sub-treet rekursivt, det vil si maks sannsynlighet for avgang feil og overgang
            List<double> rightNodesP = new List<double>();
            double rightP = 0;
            if (node.RightNodes.Count > 0)
            {
                foreach (Node rnode in node.RightNodes)
                {
                    rightNodesP.Add(CalculateProbability(rnode));
                    rightP = rightNodesP.Max();
                }
            }
            
            // Finn maksimum sannsynlighet på det venstre sub-treet rekursivt, det vil si den normale avgangssansynligheten
            double leftP = 1;
            if (node.LeftNode != null)
            {
                leftP = CalculateProbability(node.LeftNode);
            }
            else
            {
                leftP = 1;
            }
            
            // Venstre sub-tre sin sannsynlighet pluss høyre sub-tre sin sannsynlighet
            return node.PT * leftP + node.PF * rightP;
        }

        private static (int pathCount, int stationCount, long maxArriveTime, List<Node> pathList) LoadInput(IConsole console)
        {
            var pathList = new List<Node>();
            int ln = 0;
            string line;
            int pathCount = 0;
            int stationCount = 0;
            long maxArriveTime = 0;
            while ((line = console.ReadLine()) != null)
            {
                if (ln == 0)
                {
                    string[] split = line.Split(' ');
                    pathCount = int.Parse(split[0]);
                    stationCount = int.Parse(split[1]);
                }
                else
                {
                    if (ln == 1)
                    {
                        maxArriveTime = long.Parse(line);
                    }
                    else
                    {
                        string[] split = line.Split(' ');
                        pathList.Add(new Node(long.Parse(split[0]), long.Parse(split[1]), long.Parse(split[2]), long.Parse(split[3]), double.Parse(split[4], CultureInfo.InvariantCulture)));
                    }
                }

                ln++;
            }

            return (pathCount, stationCount, maxArriveTime, pathList);
        }
    }

    public class Node
    {
        public long StartStation { get; }
        public long EndStation { get; }
        public long StartTime { get; }
        public long EndTime { get; }
        public double PT { get; }
        public double PF => 1 - PT;
        public Node LeftNode { get; set; }
        public List<Node> RightNodes { get; set; }

        public Node(long startStation, long endStation, long startTime, long endTime, double pT)
        {
            StartStation = startStation;
            EndStation = endStation;
            StartTime = startTime;
            EndTime = endTime;
            PT = pT;
            LeftNode = null;
            RightNodes = new List<Node>();
        }
    }
}
