using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpracticeExercise
{
    class Home
    {
        public string Address;
        public DateTime YearofBuild;
        public int SqFootage;
        public bool GarageOpen { get; set; }
        public bool Pool;


        public void OpentheGarage()
        {
            GarageOpen = true;
        }

        public void ClosetheGarage()
        {
            GarageOpen = false;
        }


    }
}
