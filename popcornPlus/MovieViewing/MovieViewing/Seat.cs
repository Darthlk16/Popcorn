using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieViewing
{
    class Seat
    {
        private int iD;
        private int seatPlanID;
        private bool reserved;
        private int seatNumber;
        

        public Seat(int seatPlanID, bool reserved, int seatNumber)
        {
            this.seatPlanID = seatPlanID;
            this.reserved = reserved;
            this.seatNumber = seatNumber;
        }
        public Seat()
        {

        }
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public int SeatPlanID
        {
            get { return seatPlanID; }
            set { seatPlanID = value; }
        }

        public bool Reserved
        {
            get { return reserved; }
            set { reserved = value; }
        }
        public int SeatNumber
        {
            get { return seatNumber; }
            set { seatNumber = value; }
        }

    }
}
