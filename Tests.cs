using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using NUnit.Framework;

namespace Lab2
{
    public class SortsTests
    {
        private static readonly Random Random = new Random();
        private static readonly XmlDocument xDoc = new XmlDocument();
        private static readonly Dictionary<string, long> times = new Dictionary<string, long>();
        private List<string> orderedWordsCollection;
        private List<string> shuffledWordsCollection;

        [Test]
        public void BubbleSortTest()
        {
            xDoc.Load("C:\\Labs\\Lab2\\Path.xml");
            var xmlRoot = xDoc.DocumentElement.SelectSingleNode("./BubbleSort");
            var reader = new StreamReader(xmlRoot.InnerText);
            orderedWordsCollection = new List<string>();
            while (!reader.EndOfStream)
                orderedWordsCollection.Add(reader.ReadLine());
            reader.Close();

            shuffledWordsCollection = ShuffleCollection(orderedWordsCollection);

            var timer = new Stopwatch();
            timer.Start();
            BubbleSort.MakeBubbleSort(shuffledWordsCollection);
            timer.Stop();
            times["BubbleSort"] = timer.ElapsedTicks;
            for (var i = 0; i < orderedWordsCollection.Count; ++i)
                Assert.AreEqual(orderedWordsCollection[i], shuffledWordsCollection[i]);
        }

        [Test]
        public void QuickSortTest()
        {
            xDoc.Load("C:\\Labs\\Lab2\\Path.xml");
            var xmlRoot = xDoc.DocumentElement.SelectSingleNode("./QuickSort");
            var reader = new StreamReader(xmlRoot.InnerText);
            orderedWordsCollection = new List<string>();
            while (!reader.EndOfStream)
                orderedWordsCollection.Add(reader.ReadLine());
            reader.Close();

            shuffledWordsCollection = ShuffleCollection(orderedWordsCollection);
            
            var timer = new Stopwatch();
            timer.Start();
            shuffledWordsCollection.MakeQuickSort();
            timer.Stop();
            times["QuickSort"] = timer.ElapsedTicks;
            
            for (var i = 0; i < orderedWordsCollection.Count; ++i)
                Assert.AreEqual(orderedWordsCollection[i], shuffledWordsCollection[i]);
        }

        [Test]
        public void TreeSortTest()
        {
            xDoc.Load("C:\\Labs\\Lab2\\Path.xml");
            var xmlRoot = xDoc.DocumentElement.SelectSingleNode("./TreeSort");
            var reader = new StreamReader(xmlRoot.InnerText);
            orderedWordsCollection = new List<string>();
            while (!reader.EndOfStream)
                orderedWordsCollection.Add(reader.ReadLine());
            reader.Close();

            shuffledWordsCollection = ShuffleCollection(orderedWordsCollection);
            var timer = new Stopwatch();
            timer.Start();
            shuffledWordsCollection = TreeSort.MakeTreeSort(shuffledWordsCollection);
            timer.Stop();
            times["TreeSort"] = timer.ElapsedTicks;
            for (var i = 0; i < orderedWordsCollection.Count; ++i)
                Assert.AreEqual(orderedWordsCollection[i], shuffledWordsCollection[i]);
        }

        [Test]
        public void InsertSortTest()
        {
            xDoc.Load("C:\\Labs\\Lab2\\Path.xml");
            var xmlRoot = xDoc.DocumentElement.SelectSingleNode("./InsertSort");
            var reader = new StreamReader(xmlRoot.InnerText);
            orderedWordsCollection = new List<string>();
            while (!reader.EndOfStream)
                orderedWordsCollection.Add(reader.ReadLine());
            reader.Close();

            shuffledWordsCollection = ShuffleCollection(orderedWordsCollection);
            var timer = new Stopwatch();
            timer.Start();
            InsertSort.MakeInsertSort(shuffledWordsCollection);
            timer.Stop();
            times["InsertSort"] = timer.ElapsedTicks;
            for (var i = 0; i < orderedWordsCollection.Count; ++i)
                Assert.AreEqual(orderedWordsCollection[i], shuffledWordsCollection[i]);
        }

        [Test]
        public void MergeSortTest()
        {
            xDoc.Load("C:\\Labs\\Lab2\\Path.xml");
            var xmlRoot = xDoc.DocumentElement.SelectSingleNode("./MergeSort");
            var reader = new StreamReader(xmlRoot.InnerText);
            orderedWordsCollection = new List<string>();
            while (!reader.EndOfStream)
                orderedWordsCollection.Add(reader.ReadLine());
            reader.Close();

            shuffledWordsCollection = ShuffleCollection(orderedWordsCollection);
            var timer = new Stopwatch();
            timer.Start();
            MergeSort.MakeMergeSort(shuffledWordsCollection);
            timer.Stop();
            times["MergeSort"] = timer.ElapsedTicks;
            for (var i = 0; i < orderedWordsCollection.Count; ++i)
                Assert.AreEqual(orderedWordsCollection[i], shuffledWordsCollection[i]);
        }

        [Test]
        public void HeapSortTest()
        {
            xDoc.Load("C:\\Labs\\Lab2\\Path.xml");
            var xmlRoot = xDoc.DocumentElement.SelectSingleNode("./HeapSort");
            var reader = new StreamReader(xmlRoot.InnerText);
            orderedWordsCollection = new List<string>();
            while (!reader.EndOfStream)
                orderedWordsCollection.Add(reader.ReadLine());
            reader.Close();

            shuffledWordsCollection = ShuffleCollection(orderedWordsCollection);
            var timer = new Stopwatch();
            timer.Start();
            HeapSort.MakeHeapSort(shuffledWordsCollection);
            timer.Stop();
            times["HeapSort"] = timer.ElapsedTicks;
            for (var i = 0; i < orderedWordsCollection.Count; ++i)
                Assert.AreEqual(orderedWordsCollection[i], shuffledWordsCollection[i]);
        }

        [Test]
        public void RadixSortTest()
        {
            xDoc.Load("C:\\Labs\\Lab2\\Path.xml");
            var xmlRoot = xDoc.DocumentElement.SelectSingleNode("./RadixSort");
            var reader = new StreamReader(xmlRoot.InnerText);
            orderedWordsCollection = new List<string>();
            while (!reader.EndOfStream)
                orderedWordsCollection.Add(reader.ReadLine());
            reader.Close();

            shuffledWordsCollection = ShuffleCollection(orderedWordsCollection);
            var timer = new Stopwatch();
            timer.Start();
            RadixSort.MakeRadixSort(shuffledWordsCollection);
            timer.Stop();
            times["RadixSort"] = timer.ElapsedTicks;
            for (var i = 0; i < orderedWordsCollection.Count; ++i)
                Assert.AreEqual(orderedWordsCollection[i], shuffledWordsCollection[i]);
        }

        [Test]
        public void zRedBlackTreeSortTest()
        {
            xDoc.Load("C:\\Labs\\Lab2\\Path.xml");
            var xmlRoot = xDoc.DocumentElement.SelectSingleNode("./RedBlackTreeSort");
            var reader = new StreamReader(xmlRoot.InnerText);
            orderedWordsCollection = new List<string>();
            while (!reader.EndOfStream)
                orderedWordsCollection.Add(reader.ReadLine());
            reader.Close();

            shuffledWordsCollection = ShuffleCollection(orderedWordsCollection);
            var timer = new Stopwatch();
            timer.Start();
            shuffledWordsCollection = RBSort.MakeRBSort(shuffledWordsCollection);
            timer.Stop();
            times["RedBlackTreeSort"] = timer.ElapsedTicks;
            foreach(var time in times.OrderBy(t => t.Value))
                Console.WriteLine(time.Key + ": " + time.Value);
            for (var i = 0; i < orderedWordsCollection.Count; ++i)
                Assert.AreEqual(orderedWordsCollection[i], shuffledWordsCollection[i]);
        }

        private List<string> ShuffleCollection(List<string> collection)
        {
            var result = collection.ToList();

            for (var i = 0; i < result.Count; ++i)
            {
                var next = Random.Next(0, result.Count);
                var temp = result[i];
                result[i] = result[next];
                result[next] = temp;
            }

            return result;
        }
    }
}