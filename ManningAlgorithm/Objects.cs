using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManningAlgorithm
{
    public class Vessel
    {
        public string name;
        public List<Seafarer> seafarersOnBoard = new List<Seafarer>();
        
    }

    public class Seafarer
    {
        public string name;
        public  string rank;
        public string rankType; //indicates if snr officer, jnr officer or rating
        public Vessel currentVessel = new Vessel(); //current vessel
        public Vessel lastVessel = new Vessel(); //last vessel
        public List<Vessel> vesselHistory = new List<Vessel>(); //a list of past vessels
        public DateTime time = new DateTime(); //time
        public bool available = false; //if seafarer is available to go on board
        public int onBoardLeft = 0; //days left onboard
        public int onLeaveLeft = 0; //days left on leave
        
    }



    
}
