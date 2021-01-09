using mavroudis_orestis_assignment_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mavroudis_orestis_assignment_4.Models
{
    class BucketSortStrategy : ISortStrategy
    {
        public void SortSizeAscending(List<Tshirt> tshirts)
        {
            if (tshirts == null || tshirts.Count <= 1)
                return;

            int m = Enum.GetNames(typeof(Size)).Length;
            int n = tshirts.Count / m;
            List<Tshirt>[] buckets = new List<Tshirt>[n];
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = (int)tshirts[i].Size;
                buckets[bucket].Add(tshirts[i]);
            }

            ISortStrategy strategy = new BubbleSortStrategy();
            for (int i = 0; i < n; i++)
            {
                strategy.SortSizeAscending(buckets[i]);
            }

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }

        public void SortSizeDescending(List<Tshirt> tshirts)
        {
            if (tshirts == null || tshirts.Count <= 1)
                return;

            int m = Enum.GetNames(typeof(Size)).Length;
            int n = tshirts.Count / m;
            List<Tshirt>[] buckets = new List<Tshirt>[n];
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = ((int)Enum.GetNames(typeof(Size)).Length - 1) - (int)tshirts[i].Size;
                buckets[bucket].Add(tshirts[i]);
            }

            ISortStrategy strategy = new BubbleSortStrategy();
            for (int i = 0; i < n; i++)
            {
                strategy.SortSizeDescending(buckets[i]);
            }

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }

        public void SortColorAscending(List<Tshirt> tshirts)
        {
            if (tshirts == null || tshirts.Count <= 1)
                return;

            int m = Enum.GetNames(typeof(Color)).Length;
            int n = tshirts.Count / m;
            List<Tshirt>[] buckets = new List<Tshirt>[n];
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = (int)tshirts[i].Color;
                buckets[bucket].Add(tshirts[i]);
            }

            ISortStrategy strategy = new BubbleSortStrategy();
            for (int i = 0; i < n; i++)
            {
                strategy.SortColorAscending(buckets[i]);
            }

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }

        public void SortColorDescending(List<Tshirt> tshirts)
        {
            if (tshirts == null || tshirts.Count <= 1)
                return;

            int m = Enum.GetNames(typeof(Color)).Length;
            int n = tshirts.Count / m;
            List<Tshirt>[] buckets = new List<Tshirt>[n];
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = ((int)Enum.GetNames(typeof(Color)).Length - 1) - (int)tshirts[i].Color;
                buckets[bucket].Add(tshirts[i]);
            }

            ISortStrategy strategy = new BubbleSortStrategy();
            for (int i = 0; i < n; i++)
            {
                strategy.SortColorDescending(buckets[i]);
            }

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }

        public void SortFabricAscending(List<Tshirt> tshirts)
        {
            if (tshirts == null || tshirts.Count <= 1)
                return;

            int m = Enum.GetNames(typeof(Fabric)).Length;
            int n = tshirts.Count / m;
            List<Tshirt>[] buckets = new List<Tshirt>[n];
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = (int)tshirts[i].Fabric;
                buckets[bucket].Add(tshirts[i]);
            }

            ISortStrategy strategy = new BubbleSortStrategy();
            for (int i = 0; i < n; i++)
            {
                strategy.SortFabricAscending(buckets[i]);
            }

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }

        public void SortFabricDescending(List<Tshirt> tshirts)
        {
            if (tshirts == null || tshirts.Count <= 1)
                return;

            int m = Enum.GetNames(typeof(Fabric)).Length;
            int n = tshirts.Count / m;
            List<Tshirt>[] buckets = new List<Tshirt>[n];
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = ((int)Enum.GetNames(typeof(Fabric)).Length - 1) - (int)tshirts[i].Fabric;
                buckets[bucket].Add(tshirts[i]);
            }

            ISortStrategy strategy = new BubbleSortStrategy();
            for (int i = 0; i < n; i++)
            {
                strategy.SortFabricDescending(buckets[i]);
            }

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }
        
        public void SortTshirtAscending(List<Tshirt> tshirts)
        {
            if (tshirts == null || tshirts.Count <= 1)
                return;

            int m = Enum.GetNames(typeof(Size)).Length;
            int n = tshirts.Count / m;
            List<Tshirt>[] buckets = new List<Tshirt>[n];
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = (int)tshirts[i].Size;
                buckets[bucket].Add(tshirts[i]);
            }

            ISortStrategy strategy = new BubbleSortStrategy();
            for (int i = 0; i < n; i++)
            {
                strategy.SortTshirtAscending(buckets[i]);
            }

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }

        public void SortTshirtDescending(List<Tshirt> tshirts)
        {
            if (tshirts == null || tshirts.Count <= 1)
                return;

            int m = Enum.GetNames(typeof(Size)).Length;
            int n = tshirts.Count / m;
            List<Tshirt>[] buckets = new List<Tshirt>[n];
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = ((int)Enum.GetNames(typeof(Size)).Length - 1) - (int)tshirts[i].Size;
                buckets[bucket].Add(tshirts[i]);
            }

            ISortStrategy strategy = new BubbleSortStrategy();
            for (int i = 0; i < n; i++)
            {
                strategy.SortTshirtDescending(buckets[i]);
            }

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }
    }
}
