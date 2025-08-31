using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryToSolve.Part02
{
    internal class DurationTo
    {

        #region Properties
        public int Hours { get; private set; }
        public int Minutes { get; private set; }

        public int Seconds { get; private set; } 
        #endregion
        public DurationTo(int hours, int minutes, int seconds)
        {
            Hours = Math.Max(0, hours);//Prevent negative value
            Minutes = Math.Max(0, minutes);//Prevent negative value
            Seconds = Math.Max(0, seconds);//Prevent negative value
        }

        public DurationTo(int totalSeconds)
        {
            if(totalSeconds<0)
                totalSeconds = 0;

            Hours = totalSeconds / 3600;
            totalSeconds%=3600;//He keeps the rest after we removed the hours.
            Minutes = totalSeconds / 60;//Converts the remainder to minutes.
            Seconds = totalSeconds % 60;//The last remainder is seconds.
            NormalizeTime();
        }

        private void NormalizeTime()
        {
            if(Seconds>=0)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
            if(Minutes>=0)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
            if(Hours<0||Minutes<0||Seconds<0)
                Hours=Minutes=Seconds=0;
        }

        private int ToTotalSecond()=>Hours*3600+Minutes*60+Seconds;

        private static DurationTo FromTotalSecondsClamped(int totalSeconds)
        {
            if(totalSeconds<0)
                totalSeconds = 0;
            return new DurationTo(totalSeconds);
        }
        #region Overriding Methods
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours:{Hours},Minutes:{Minutes},Seconds:{Seconds}";
            if (Minutes > 0)
                return $"Minutes:{Minutes} Seconds:{Seconds}";
            return $"Seconds{Seconds}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not DurationTo d)
                return false;

            return ToTotalSecond() == d.ToTotalSecond();
        }

        public override int GetHashCode() =>
            ToTotalSecond().GetHashCode();
        #endregion

        #region Overloading Methods

        public static DurationTo operator +(DurationTo d1, DurationTo d2)
        => new DurationTo(d1.ToTotalSecond()+d2.ToTotalSecond());
  
        public static DurationTo operator + (DurationTo d1 , int seconds)
         => FromTotalSecondsClamped(d1.ToTotalSecond()+ seconds);

        public static DurationTo operator - (DurationTo d1,DurationTo d2)
         => FromTotalSecondsClamped(d1.ToTotalSecond()- d2.ToTotalSecond());
        public static DurationTo operator -(DurationTo d1 , int seconds)
        => FromTotalSecondsClamped(d1.ToTotalSecond() - seconds);
        
        public static DurationTo operator ++ (DurationTo d)
         => FromTotalSecondsClamped(d.ToTotalSecond()+60);

        public static DurationTo operator -- (DurationTo d)
        =>FromTotalSecondsClamped(d.ToTotalSecond()-60);

        public static bool operator > (DurationTo d1, DurationTo d2)
        =>d1.ToTotalSecond()> d2.ToTotalSecond();

        public static bool operator <(DurationTo d1, DurationTo d2)
         => d1.ToTotalSecond() < d2.ToTotalSecond();

        public static explicit operator DateTime(DurationTo d)
            =>DateTime.Today.AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);


        #endregion



    }
}
