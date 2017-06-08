using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieViewing
{
    class Session
    {
        private int sessionID;
        private string time;
        private int movieID;
        private int seatPlanID;
        private int auditoriumID;

       
        public int SessionID
        {
            get { return sessionID; }
            set { sessionID = value; }
        }
        public string Time
        {
            get { return time;  }
            set { time = value; }
        }
        public int MovieID
        {
            get { return movieID; }
            set { movieID = value; }
        }
        public int SeatPlan
        {
            get { return seatPlanID; }
            set { seatPlanID = value; }
        }
        public int AuditoriumID
        {
            get { return auditoriumID; }
            set { auditoriumID = value; }
        }

    }
}
