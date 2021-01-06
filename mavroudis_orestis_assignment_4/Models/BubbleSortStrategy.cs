using mavroudis_orestis_assignment_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mavroudis_orestis_assignment_4.Models
{
    class BubbleSortStrategy : ISortStrategy
    {
        public void SortSizeAscending(List<Tshirt> tshirts)
        {
            // bool swapped;
            Tshirt temp;
            for (int i = 0; i < tshirts.Count - 1; i++)
            {
                //swapped = false;
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    if (tshirts[j].Size > tshirts[j + 1].Size)
                    {
                        //swapped=true;
                        temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                }
                //if (!swapped)
                //    break;
            }
        }

        public void SortSizeDescending(List<Tshirt> tshirts)
        {
            // bool swapped;
            Tshirt temp;
            for (int i = 0; i < tshirts.Count - 1; i++)
            {
                //swapped = false;
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    if (tshirts[j].Size < tshirts[j + 1].Size)
                    {
                        //swapped=true;
                        temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                }
                //if (!swapped)
                //    break;
            }
        }

        public void SortColorAscending(List<Tshirt> tshirts)
        {
            // bool swapped;
            Tshirt temp;
            for (int i = 0; i < tshirts.Count - 1; i++)
            {
                //swapped = false;
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    if (tshirts[j].Color > tshirts[j + 1].Color)
                    {
                        //swapped=true;
                        temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                }
                //if (!swapped)
                //    break;
            }
        }

        public void SortColorDescending(List<Tshirt> tshirts)
        {
            // bool swapped;
            Tshirt temp;
            for (int i = 0; i < tshirts.Count - 1; i++)
            {
                //swapped = false;
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    if (tshirts[j].Color < tshirts[j + 1].Color)
                    {
                        //swapped=true;
                        temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                }
                //if (!swapped)
                //    break;
            }
        }

        public void SortFabricAscending(List<Tshirt> tshirts)
        {
            // bool swapped;
            Tshirt temp;
            for (int i = 0; i < tshirts.Count - 1; i++)
            {
                //swapped = false;
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    if (tshirts[j].Fabric > tshirts[j + 1].Fabric)
                    {
                        //swapped=true;
                        temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                }
                //if (!swapped)
                //    break;
            }
        }

        public void SortFabricDescending(List<Tshirt> tshirts)
        {
            // bool swapped;
            Tshirt temp;
            for (int i = 0; i < tshirts.Count - 1; i++)
            {
                //swapped = false;
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    if (tshirts[j].Fabric < tshirts[j + 1].Fabric)
                    {
                        //swapped=true;
                        temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                }
                //if (!swapped)
                //    break;
            }
        }

        public void SortTshirtAscending(List<Tshirt> tshirts)
        {
            //bool swapped;
            Tshirt temp;
            for (int i = 0; i < tshirts.Count - 1; i++)
            {
                //swapped = false;
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    if (tshirts[j].Size > tshirts[j + 1].Size)
                    {
                        //swapped = true;
                        temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                    else if (tshirts[j].Size == tshirts[j + 1].Size && tshirts[j].Color > tshirts[j + 1].Color)
                    {
                        //swapped = true;
                        temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                    else if (tshirts[j].Size == tshirts[j + 1].Size && tshirts[j].Color == tshirts[j + 1].Color && tshirts[j].Fabric > tshirts[j + 1].Fabric)
                    {
                        //swapped = true;
                        temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                }
                //if (!swapped)
                //    break;
            }
        }

        public void SortTshirtDescending(List<Tshirt> tshirts)
        {
            // bool swapped;
            Tshirt temp;
            for (int i = 0; i < tshirts.Count - 1; i++)
            {
                //swapped = false;
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    if (tshirts[j].Size < tshirts[j + 1].Size)
                    {
                        //swapped=true;
                        temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                    else if(tshirts[j].Size == tshirts[j + 1].Size && tshirts[j].Color < tshirts[j + 1].Color)
                    {
                        //swapped=true;
                        temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                    else if(tshirts[j].Size == tshirts[j + 1].Size && tshirts[j].Color == tshirts[j + 1].Color && tshirts[j].Fabric < tshirts[j + 1].Fabric)
                    {
                        //swapped=true;
                        temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                }
                //if (!swapped)
                //    break;
            }
        }
    }
}
