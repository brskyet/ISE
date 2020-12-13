using System;
using System.Collections.Generic;
using System.Linq;
using BFS_DFS_Iterator.BFS;
using BFS_DFS_Iterator.DFS;
using BFS_DFS_Iterator.Iterator;
using BFS_DFS_Iterator.Services;

namespace BFS_DFS_Iterator
{
    public static class BfsDfsIteratorExecutor
    {
        public static void Execute()
        {
            var shops = new ShopCollection();

            var depthFirstSearch = new DepthFirstSearch();
            var path1 = depthFirstSearch.Search(shops[5], shops[12]);
            PrintPath(path1);
            var path2 = depthFirstSearch.Search(shops[5], shops[14]);
            PrintPath(path2);

            var breadthFirstSearch = new BreadthFirstSearch();
            var path3 = breadthFirstSearch.Search(shops[5], shops[12]);
            PrintPath(path3);
            var path4 = breadthFirstSearch.Search(shops[5], shops[14]);
            PrintPath(path4);
        }
        
        private static void PrintPath(List<Shop> path)
        {
            Console.WriteLine();
            if (path.Count == 0)
            {
                Console.WriteLine("Can't find path!");
            }
            else
            {
                Console.WriteLine(string.Join(" -> ", path.Select(x => x.Name)));
            }
        }
    }
}