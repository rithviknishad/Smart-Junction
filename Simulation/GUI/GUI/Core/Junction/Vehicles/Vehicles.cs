using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GUI.Core.Support.Priorities;

namespace GUI.Core.Junction.Vehicles
{

    //public enum EmergencyVehicleType
    //{
    //    Ambulance = 0, FireRescue, Police, GovtAuthority, Other
    //}
    public class Vehicle
    {
        private uint D2JNC;
        public uint Distance
        {
            get
            {
                return D2JNC;
            }
            set
            {
                D2JNC = value;
            }
        }

        static ulong VEH_PART_IN_JNC = 0;
        public ulong VehicleHashID = VEH_PART_IN_JNC++;

        public bool IsCleared = false;

        public ushort WaitTime = 0;
        public bool IsWaiting
        {
            get
            {
                if (WaitTime > 0)
                    return true;
                else
                    return false;
            }
        }

        public void Refresh()
        {
            if (Distance > 0)
            {
                --Distance;
            }

            if (Distance == 0)
            {
                ++WaitTime;
            }
        }

        public void Clear()
        {
            IsCleared = true;
        }

        public Vehicle(uint distance)
        {
            D2JNC = distance;
        }
    }


    public class EmergencyVehicle : Vehicle, IEquatable<EmergencyVehicle>
    {

        private string REG_NO = "NULL";
        public string RegistrationNumber
        {
            get
            {
                return REG_NO;
            }
            private set
            {
                REG_NO = value;
            }
        }

        public EmergencyVehicle(string registrationNo, uint distance = 18) : base(distance)
        {
            RegistrationNumber = registrationNo;
        }

        public ushort AVG_SPEED = 0;
        public uint TOPSPEED = 0;

        private string DESTINATION = "NULL";
        private string CURRENT_LOCATION = "NULL";

        public string Destination
        {
            get
            {
                return DESTINATION;
            }
            private set
            {
                DESTINATION = value;
            }
        }

        public string CurrentLocation {
            get
            {
                return CURRENT_LOCATION;
            }
            private set
            {
                CURRENT_LOCATION = value;
            }
        }

        public ushort DistanceToJunction = 0;

        public PriorityLevels PriorityLevel = PriorityLevels.Normal;

        public void ElevatePriority()
        {
            if (Priority.PriorityClassifier((ushort)PriorityLevel) == PriorityLevels.Normal)
            {
                PriorityLevel = PriorityLevels.Emergency_MIN;
            }
        }

        public void UpdateDestination(string location)
        {
            Destination = location;
            // code to update other stuff
        }

        public void UpdateCurrentLocation(string location)
        {
            CurrentLocation = location;
            //code to update priority levels
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as EmergencyVehicle);
        }

        public bool Equals(EmergencyVehicle other)
        {
            return other != null && REG_NO == other.REG_NO;
        }

        public override int GetHashCode()
        {
            return int.Parse(RegistrationNumber);
        }

        public static bool operator ==(EmergencyVehicle emergency1, EmergencyVehicle emergency2)
        {
            return EqualityComparer<EmergencyVehicle>.Default.Equals(emergency1, emergency2);
        }

        public static bool operator !=(EmergencyVehicle emergency1, EmergencyVehicle emergency2)
        {
            return !(emergency1 == emergency2);
        }
    }
}
