using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.ExercismChallenges.Classes
{
    class NeedForSpeedRemoteControlCar
    {
        private int speed;
        private int batteryDrain;
   
        public NeedForSpeedRemoteControlCar(int speed, int batteryDrain)
        {
            this.speed = speed;
            this.batteryDrain = batteryDrain;
        }
     

        public bool BatteryDrained()
        {
            throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDrained() method");
        }

        public int DistanceDriven()
        {
            throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDriven() method");
        }

        public void Drive()
        {
            throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
        }

        public static RemoteControlCar Nitro()
        {
            throw new NotImplementedException("Please implement the (static) RemoteControlCar.Nitro() method");
        }
    }

    class RaceTrack
    {
        private int distance;

        public RaceTrack(int distance)
        {
            this.distance = distance;
        }

        public bool TryFinishTrack(RemoteControlCar car)
        {
            throw new NotImplementedException("Please implement the RaceTrack.TryFinishTrack() method");
        }
    }

}
