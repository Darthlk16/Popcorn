using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieViewing
{
    class SeatPlan
    {
        private int iD;
        private int auditoriumID;
        


        public SeatPlan(int auditoriumID)
        {
            this.auditoriumID = auditoriumID;
        }
        

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public int AuditoriumID
        {
            get { return auditoriumID; }
            set { auditoriumID = value; }
        }

    }
}
