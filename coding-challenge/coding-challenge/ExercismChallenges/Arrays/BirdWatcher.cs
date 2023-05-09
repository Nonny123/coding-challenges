using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.ExercismChallenges.Arrays
{
    class BirdCount
    {
        private int[] birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek()
        {
            int[] lastWeek = { 0, 2, 5, 3, 7, 8, 4 };
            return lastWeek;
        }

        public int Today()
        {
            return birdsPerDay[birdsPerDay.Length - 1];
        }

        public void IncrementTodaysCount()
        {
            throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
        }

        public bool HasDayWithoutBirds()
        {
            throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
        }

        public int CountForFirstDays(int numberOfDays)
        {
            throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
        }

        public int BusyDays()
        {
            throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
        }
    }

}
