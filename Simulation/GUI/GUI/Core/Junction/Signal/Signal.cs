namespace GUI.Core.Junction.Signals
{

    public enum SignalStates
    {
        Off = 0,
        Red,
        Amber,
        Green,
        Emergency,
        Warn,
        Other
    }

    public class Signal
    {
        private SignalStates STATE = SignalStates.Off;
        private byte SIGNALID = 0;

        public SignalStates State
        {
            get
            {
                return STATE;
            }
            set
            {
                STATE = (SignalStates)value;
            }
        }

        public byte SignalID
        {
            get
            {
                return SIGNALID;
            }
            private set
            {
                SIGNALID = (byte)value;
            }
        }

        public Signal(byte signalID, SignalStates initialState = SignalStates.Off)
        {
            SignalID = signalID;
            State = initialState;
        }

        public override string ToString()
        {
            return State.ToString();
        }

        public override int GetHashCode()
        {
            return (int)SignalID;
        }
    }

}