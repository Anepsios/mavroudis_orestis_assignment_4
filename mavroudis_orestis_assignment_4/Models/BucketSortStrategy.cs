﻿using mavroudis_orestis_assignment_4.Interfaces;
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
            List<Tshirt>[] buckets = new List<Tshirt>[tshirts.Count];
            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = (int)tshirts[i].Size / tshirts.Count;
                buckets[bucket].Add(tshirts[i]);
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = buckets[i].OrderBy(x=>x.Size).ToList();
            }

            int index = 0;
            for (int i = 0 ; i < tshirts.Count; i++) 
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }

        public void SortSizeDescending(List<Tshirt> tshirts)
        {
            List<Tshirt>[] buckets = new List<Tshirt>[tshirts.Count];
            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = (int)tshirts[i].Size / tshirts.Count;
                buckets[bucket].Add(tshirts[i]);
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = buckets[i].OrderByDescending(x => x.Size).ToList();
            }

            int index = 0;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }

        public void SortColorAscending(List<Tshirt> tshirts)
        {
            List<Tshirt>[] buckets = new List<Tshirt>[tshirts.Count];
            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = (int)tshirts[i].Color / tshirts.Count;
                buckets[bucket].Add(tshirts[i]);
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = buckets[i].OrderBy(x => x.Color).ToList();
            }

            int index = 0;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }

        public void SortColorDescending(List<Tshirt> tshirts)
        {
            List<Tshirt>[] buckets = new List<Tshirt>[tshirts.Count];
            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = (int)tshirts[i].Color / tshirts.Count;
                buckets[bucket].Add(tshirts[i]);
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = buckets[i].OrderByDescending(x => x.Color).ToList();
            }

            int index = 0;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }

        public void SortFabricAscending(List<Tshirt> tshirts)
        {
            List<Tshirt>[] buckets = new List<Tshirt>[tshirts.Count];
            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = (int)tshirts[i].Fabric / tshirts.Count;
                buckets[bucket].Add(tshirts[i]);
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = buckets[i].OrderBy(x => x.Fabric).ToList();
            }

            int index = 0;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }

        public void SortFabricDescending(List<Tshirt> tshirts)
        {
            List<Tshirt>[] buckets = new List<Tshirt>[tshirts.Count];
            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = (int)tshirts[i].Fabric / tshirts.Count;
                buckets[bucket].Add(tshirts[i]);
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = buckets[i].OrderByDescending(x => x.Fabric).ToList();
            }

            int index = 0;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }
        
        public void SortTshirtAscending(List<Tshirt> tshirts)
        {
            List<Tshirt>[] buckets = new List<Tshirt>[tshirts.Count];
            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = (int)tshirts[i].Size / tshirts.Count;
                buckets[bucket].Add(tshirts[i]);
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = buckets[i].OrderBy(x => x.Size).ThenBy(y => y.Color).ThenBy(u => u.Fabric).ToList();
            }

            int index = 0;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }

        public void SortTshirtDescending(List<Tshirt> tshirts)
        {
            List<Tshirt>[] buckets = new List<Tshirt>[tshirts.Count];
            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = (int)tshirts[i].Size / tshirts.Count;
                buckets[bucket].Add(tshirts[i]);
            }

            for (int i = 0; i < tshirts.Count; i++)
            {
                buckets[i] = buckets[i].OrderBy(x => x.Size).ThenBy(y => y.Color).ThenBy(u => u.Fabric).ToList();
            }

            int index = 0;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    tshirts[index++] = buckets[i][j];
                }
            }
        }
    }
}
