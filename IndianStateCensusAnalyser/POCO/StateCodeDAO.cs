using System;
using System.Collections.Generic;
using System.Text;
namespace IndianStateCensusAnalyser.POCO
{
    public class StateCodeDAO
    {
        public int serialNumber;
        public string stateName;
        public int tin;
        public string stateCode;
        public StateCodeDAO(string serialNumber, string state, string tin, string stateCode)
        {
            this.serialNumber = Convert.ToInt32(serialNumber);
            this.stateName = state;
            this.tin = Convert.ToInt32(tin);
            this.stateCode = stateCode;
        }
    }
}
