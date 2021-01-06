using mavroudis_orestis_assignment_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mavroudis_orestis_assignment_4.Models
{
    class QuickSortStrategy : ISortStrategy
    {
        public void SortSizeAscending(List<Tshirt> tshirts)
        {
            if (tshirts.Count > 0)
            {
                int low = 0;
                int high = tshirts.Count - 1;
                int pivot = SizeAscendingPartition(tshirts, low, high);
                SortSizeAscending(tshirts, low, pivot - 1);
                SortSizeAscending(tshirts, pivot + 1, high);
            }
        }

        private void SortSizeAscending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pivot = SizeAscendingPartition(tshirts, low, high);
                SortSizeAscending(tshirts, low, pivot - 1);
                SortSizeAscending(tshirts, pivot + 1, high);
            }
        }

        private int SizeAscendingPartition(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt temp;
            int j = low;
            Size pivot = tshirts[high].Size;
            for (int i = low; i < high; i++)
            {
                if (tshirts[i].Size < pivot)
                {
                    temp = tshirts[j];
                    tshirts[j] = tshirts[i];
                    tshirts[i] = temp;
                    j++;
                }
            }
            temp = tshirts[j];
            tshirts[j] = tshirts[high];
            tshirts[high] = temp;
            return j;
        }

        public void SortSizeDescending(List<Tshirt> tshirts)
        {
            if (tshirts.Count > 0)
            {
                int low = 0;
                int high = tshirts.Count - 1;
                int pivot = SizeDescendingPartition(tshirts, low, high);
                SortSizeDescending(tshirts, low, pivot - 1);
                SortSizeDescending(tshirts, pivot + 1, high);
            }
        }

        private void SortSizeDescending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pivot = SizeDescendingPartition(tshirts, low, high);
                SortSizeDescending(tshirts, low, pivot - 1);
                SortSizeDescending(tshirts, pivot + 1, high);
            }
        }

        private int SizeDescendingPartition(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt temp;
            int j = low;
            Size pivot = tshirts[high].Size;
            for (int i = low; i < high; i++)
            {
                if (tshirts[i].Size > pivot)
                {
                    temp = tshirts[j];
                    tshirts[j] = tshirts[i];
                    tshirts[i] = temp;
                    j++;
                }
            }
            temp = tshirts[j];
            tshirts[j] = tshirts[high];
            tshirts[high] = temp;
            return j;
        }

        public void SortColorAscending(List<Tshirt> tshirts)
        {
            if (tshirts.Count > 0)
            {
                int low = 0;
                int high = tshirts.Count - 1;
                int pivot = ColorAscendingPartition(tshirts, low, high);
                SortColorAscending(tshirts, low, pivot - 1);
                SortColorAscending(tshirts, pivot + 1, high);
            }
        }

        private void SortColorAscending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pivot = ColorAscendingPartition(tshirts, low, high);
                SortColorAscending(tshirts, low, pivot - 1);
                SortColorAscending(tshirts, pivot + 1, high);
            }
        }

        private int ColorAscendingPartition(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt temp;
            int j = low;
            Color pivot = tshirts[high].Color;
            for (int i = low; i < high; i++)
            {
                if (tshirts[i].Color < pivot)
                {
                    temp = tshirts[j];
                    tshirts[j] = tshirts[i];
                    tshirts[i] = temp;
                    j++;
                }
            }
            temp = tshirts[j];
            tshirts[j] = tshirts[high];
            tshirts[high] = temp;
            return j;
        }

        public void SortColorDescending(List<Tshirt> tshirts)
        {
            if (tshirts.Count > 0)
            {
                int low = 0;
                int high = tshirts.Count - 1;
                int pivot = ColorDescendingPartition(tshirts, low, high);
                SortColorDescending(tshirts, low, pivot - 1);
                SortColorDescending(tshirts, pivot + 1, high);
            }
        }

        private void SortColorDescending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pivot = ColorDescendingPartition(tshirts, low, high);
                SortColorDescending(tshirts, low, pivot - 1);
                SortColorDescending(tshirts, pivot + 1, high);
            }
        }

        private int ColorDescendingPartition(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt temp;
            int j = low;
            Color pivot = tshirts[high].Color;
            for (int i = low; i < high; i++)
            {
                if (tshirts[i].Color > pivot)
                {
                    temp = tshirts[j];
                    tshirts[j] = tshirts[i];
                    tshirts[i] = temp;
                    j++;
                }
            }
            temp = tshirts[j];
            tshirts[j] = tshirts[high];
            tshirts[high] = temp;
            return j;
        }

        public void SortFabricAscending(List<Tshirt> tshirts)
        {
            if (tshirts.Count > 0)
            {
                int low = 0;
                int high = tshirts.Count - 1;
                int pivot = FabricAscendingPartition(tshirts, low, high);
                SortFabricAscending(tshirts, low, pivot - 1);
                SortFabricAscending(tshirts, pivot + 1, high);
            }
        }

        private void SortFabricAscending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pivot = FabricAscendingPartition(tshirts, low, high);
                SortFabricAscending(tshirts, low, pivot - 1);
                SortFabricAscending(tshirts, pivot + 1, high);
            }
        }

        private int FabricAscendingPartition(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt temp;
            int j = low;
            Fabric pivot = tshirts[high].Fabric;
            for (int i = low; i < high; i++)
            {
                if (tshirts[i].Fabric < pivot)
                {
                    temp = tshirts[j];
                    tshirts[j] = tshirts[i];
                    tshirts[i] = temp;
                    j++;
                }
            }
            temp = tshirts[j];
            tshirts[j] = tshirts[high];
            tshirts[high] = temp;
            return j;
        }

        public void SortFabricDescending(List<Tshirt> tshirts)
        {
            if (tshirts.Count > 0)
            {
                int low = 0;
                int high = tshirts.Count - 1;
                int pivot = FabricDescendingPartition(tshirts, low, high);
                SortFabricDescending(tshirts, low, pivot - 1);
                SortFabricDescending(tshirts, pivot + 1, high);
            }
        }

        private void SortFabricDescending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pivot = FabricDescendingPartition(tshirts, low, high);
                SortFabricDescending(tshirts, low, pivot - 1);
                SortFabricDescending(tshirts, pivot + 1, high);
            }
        }

        private int FabricDescendingPartition(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt temp;
            int j = low;
            Fabric pivot = tshirts[high].Fabric;
            for (int i = low; i < high; i++)
            {
                if (tshirts[i].Fabric > pivot)
                {
                    temp = tshirts[j];
                    tshirts[j] = tshirts[i];
                    tshirts[i] = temp;
                    j++;
                }
            }
            temp = tshirts[j];
            tshirts[j] = tshirts[high];
            tshirts[high] = temp;
            return j;
        }

        public void SortTshirtAscending(List<Tshirt> tshirts)
        {
            if (tshirts.Count > 0)
            {
                int low = 0;
                int high = tshirts.Count - 1;
                int pivot = TshirtAscendingPartition(tshirts, low, high);
                SortTshirtAscending(tshirts, low, pivot - 1);
                SortTshirtAscending(tshirts, pivot + 1, high);
            }
        }

        private void SortTshirtAscending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pivot = TshirtAscendingPartition(tshirts, low, high);
                SortTshirtAscending(tshirts, low, pivot - 1);
                SortTshirtAscending(tshirts, pivot + 1, high);
            }
        }

        private int TshirtAscendingPartition(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt temp;
            int j = low;
            Tshirt pivot = tshirts[high];
            for (int i = low; i < high; i++)
            {
                if (tshirts[i].Size < pivot.Size)
                {
                    temp = tshirts[j];
                    tshirts[j] = tshirts[i];
                    tshirts[i] = temp;
                    j++;
                }
                else if (tshirts[i].Size == pivot.Size)
                {
                    if (tshirts[i].Color < pivot.Color)
                    {
                        temp = tshirts[j];
                        tshirts[j] = tshirts[i];
                        tshirts[i] = temp;
                        j++;
                    }
                    else if (tshirts[i].Color == pivot.Color)
                    {
                        if (tshirts[i].Fabric < pivot.Fabric)
                        {
                            temp = tshirts[j];
                            tshirts[j] = tshirts[i];
                            tshirts[i] = temp;
                            j++;
                        }
                    }
                }
            }
            temp = tshirts[j];
            tshirts[j] = tshirts[high];
            tshirts[high] = temp;
            return j;
        }

        public void SortTshirtDescending(List<Tshirt> tshirts)
        {
            if (tshirts.Count > 0)
            {
                int low = 0;
                int high = tshirts.Count - 1;
                int pivot = TshirtDescendingPartition(tshirts, low, high);
                SortTshirtDescending(tshirts, low, pivot - 1);
                SortTshirtDescending(tshirts, pivot + 1, high);
            }
        }

        private void SortTshirtDescending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pivot = TshirtDescendingPartition(tshirts, low, high);
                SortTshirtDescending(tshirts, low, pivot - 1);
                SortTshirtDescending(tshirts, pivot + 1, high);
            }
        }

        private int TshirtDescendingPartition(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt temp;
            int j = low;
            Tshirt pivot = tshirts[high];
            for (int i = low; i < high; i++)
            {
                if (tshirts[i].Size > pivot.Size)
                {
                    temp = tshirts[j];
                    tshirts[j] = tshirts[i];
                    tshirts[i] = temp;
                    j++;
                }
                else if (tshirts[i].Size == pivot.Size  )
                {
                    if (tshirts[i].Color > pivot.Color)
                    {
                        temp = tshirts[j];
                        tshirts[j] = tshirts[i];
                        tshirts[i] = temp;
                        j++;
                    }
                    else if (tshirts[i].Color == pivot.Color)
                    {
                        if (tshirts[i].Fabric > pivot.Fabric)
                        {
                            temp = tshirts[j];
                            tshirts[j] = tshirts[i];
                            tshirts[i] = temp;
                            j++;
                        }
                    }
                }
            }
            temp = tshirts[j];
            tshirts[j] = tshirts[high];
            tshirts[high] = temp;
            return j;
        }
    }
}