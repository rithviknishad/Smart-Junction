using System.ComponentModel.DataAnnotations;

namespace GUI.Core.Support.Priorities
{

    public enum PriorityLevels
    {
        Skip = 0,
        Null = 1,
        Normal_MIN = 33, Normal = 49, Normal_MAX = 64,
        High_MIN = 97, High = 105, High_MAX = 112,
        Emergency_MIN = 193, Emergency = 209, Emergency_MAX = 224,

        GreenLock = 255
    }

    public class Priority
    {

        private ushort _Level = (ushort)PriorityLevels.Skip;
        private PriorityLevels _DefaultPriorityPreference = PriorityLevels.Normal;

        public Priority(ushort level = (ushort)PriorityLevels.Normal, bool defaultPreferenceIsHigh = false)
        {
            Level = level;
            DefaultPreferenceIsHigh = defaultPreferenceIsHigh;
        }

        public ushort Level
        {
            get { return _Level; }
            set => _Level = (ushort)value;
        }

        public bool DefaultPreferenceIsHigh
        {
            get { return (_DefaultPriorityPreference == PriorityLevels.High ? true : false); }
            set
            {
                if (value)
                {
                    _DefaultPriorityPreference = PriorityLevels.High;
                }
                else
                {
                    _DefaultPriorityPreference = PriorityLevels.Normal;
                }
            }
        }

        public static PriorityLevels PriorityClassifier(ushort level)
        {
            return (
                level == (ushort)PriorityLevels.Skip ? PriorityLevels.Skip : (

                level >= (ushort)PriorityLevels.Normal_MIN &&
                level <= (ushort)PriorityLevels.Normal_MAX ?
                PriorityLevels.Normal : (

                level >= (ushort)PriorityLevels.High_MIN &&
                level <= (ushort)PriorityLevels.High_MAX ?
                PriorityLevels.High : (

                level >= (ushort)PriorityLevels.Emergency_MIN &&
                level <= (ushort)PriorityLevels.Emergency_MAX ?
                PriorityLevels.Emergency : (

                level == (ushort)PriorityLevels.GreenLock ? PriorityLevels.GreenLock : PriorityLevels.Null
                )))));
        }

        public void Set(PriorityLevels PriorityCAT, [Range(0, 100)] ushort Perc)
        {
            switch (PriorityCAT)
            {
                case PriorityLevels.Normal_MIN:
                case PriorityLevels.Normal_MAX:
                case PriorityLevels.Normal:
                    _Level = (ushort)(((Perc / 100) * (1 + PriorityLevels.Normal_MAX - PriorityLevels.Normal_MIN)) + PriorityLevels.Normal_MIN);
                    break;

                case PriorityLevels.High_MIN:
                case PriorityLevels.High_MAX:
                case PriorityLevels.High:
                    _Level = (ushort)(((Perc / 100) * (1 + PriorityLevels.High_MAX - PriorityLevels.High_MIN)) + PriorityLevels.High_MIN);
                    break;

                case PriorityLevels.Emergency_MIN:
                case PriorityLevels.Emergency_MAX:
                case PriorityLevels.Emergency:
                    _Level = (ushort)(((Perc / 100) * (1 + PriorityLevels.Emergency_MAX - PriorityLevels.Emergency_MIN)) + PriorityLevels.Emergency_MIN);
                    break;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            _Level = (ushort)obj.GetHashCode();
            return true;
        }

        public override int GetHashCode()
        {
            return _Level;
        }

        public override string ToString()
        {
            return Priority.PriorityClassifier(_Level).ToString();
        }
    }

}