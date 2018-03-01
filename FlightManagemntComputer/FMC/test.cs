﻿using Fds.IFAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagemntComputer
{
    public class test
    {
        public void changeAltitude()
        {
            /// This code is to set a specific altitude on the autopilot and enable the VNAV
            int testaltitude1 = 29000;
            int testaltitude2 = 33000;
            int testaltitude3 = 1000;
            int testaltitude4 = 50000;
            {
                {
                    "Command": "Commands.Autopilot.SetHeading",
                    "Parameters": [{ "Value": 270 }]
                }
            }



            client.ExecuteCommand("Commands.Autopilot.Setaltitude");
            IFAPI.commands.autopilot.setaltitude(testaltitude1);
            commands.autopilot.setaltitudestate(on);

        }
        /*public void printToConsole()
        {
            /// This tests the major getstate methods required for the FMC
            Console.Write("The current aircraft status is: " + airplane.getstate);
            Console.Write("The AutoPilot (AP) is currently: " + autopilot.getstate);
        }
        */
    }
}
