using Data_Structures;
using System;
using System.Collections.Generic;

public class BFSandDFS
{
    public void AddEdge(List<List<int>> adj, int u, int v)
    {
        adj[u].Add(v);
        adj[v].Add(u);
    }

    public void BFS(List<List<int>> adj, int c)
    {
        Queue<int> q = new Queue<int>();
        bool[] visited = new bool[adj.Count];

        visited[c] = true;
        q.Enqueue(c);

        Console.WriteLine("********* BFS Traversal *********");

        List<int> result = new List<int>();

        while (q.Count > 0)
        {
            int curr = q.Dequeue();
            result.Add(curr);

            foreach (int x in adj[curr])
            {
                if (!visited[x])
                {
                    visited[x] = true;
                    q.Enqueue(x);
                }
            }
        }

        Console.WriteLine(string.Join(" → ", result));
    }

    public void DFSRecord(List<List<int>> adj, bool[] visited, int s, int depth = 0)
    {
        visited[s] = true;

        Console.WriteLine(new string(' ', depth * 4) + "└── " + s);

        foreach (int i in adj[s])
        {
            if (!visited[i])
            {
                DFSRecord(adj, visited, i, depth + 1);
            }
        }
    }

    public void DFS(List<List<int>> adj, int s)
    {
        bool[] visited = new bool[adj.Count];

        Console.WriteLine("\n********* DFS Traversal *********");

        DFSRecord(adj, visited, s);
    }

    public void StartBFS()
    {
        Console.Clear();

        int V = 6;
        List<List<int>> adj = new List<List<int>>(V);
        for (int i = 0; i < V; i++)
        {
            adj.Add(new List<int>());
        }

        AddEdge(adj, 0, 1);
        AddEdge(adj, 0, 2);
        AddEdge(adj, 1, 3);
        AddEdge(adj, 1, 4);
        AddEdge(adj, 2, 5);

        BFS(adj, 0);
    }

    public void StartDFS()
    {
        int V = 6;
        List<List<int>> adj = new List<List<int>>(V);
        for (int i = 0; i < V; i++)
        {
            adj.Add(new List<int>());
        }

        int[,] edges = {
            { 0, 1 }, { 0, 2 }, { 1, 3 }, { 1, 4 }, { 2, 5 }
        };

        for (int i = 0; i < edges.GetLength(0); i++)
        {
            AddEdge(adj, edges[i, 0], edges[i, 1]);
        }

        int source = 0;
        DFS(adj, source);

        Console.ReadKey();
        Program program = new Program();
        program.MainMenu();
    }
}
