﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.ExercismChallenges.Classes
{
    class RemoteControlCar
    {
        private int _distance = 0;

        private int _battery = 100;


        public static RemoteControlCar Buy()
        {
            return new RemoteControlCar();
        }

        public string DistanceDisplay()
        {
            return $"Driven {_distance} meters";
        }

        public string BatteryDisplay()
        {
            return _battery <= 0 ? $"Battery empty" : $"Battery at {_battery}%";
        }

        public void Drive()
        {
            if (_battery > 0)
            {
                _distance += 20;
                _battery -= 1;
            }

        }
    }
}
