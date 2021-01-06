using mavroudis_orestis_assignment_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mavroudis_orestis_assignment_4.Interfaces
{
    interface ISortStrategy
    {
        void SortSizeAscending(List<Tshirt> tshirts);
        void SortSizeDescending(List<Tshirt> tshirts);
        void SortColorAscending(List<Tshirt> tshirts);
        void SortColorDescending(List<Tshirt> tshirts);
        void SortFabricAscending(List<Tshirt> tshirts);
        void SortFabricDescending(List<Tshirt> tshirts);
        void SortTshirtAscending(List<Tshirt> tshirts);
        void SortTshirtDescending(List<Tshirt> tshirts);
    }
}
