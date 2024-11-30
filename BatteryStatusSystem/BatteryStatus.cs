using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryStatusSystem
{
    internal class BatteryStatus
    {

        public BatteryStatus() { }

        public float LevelBaterry()
        {
            PowerStatus powerStatus = SystemInformation.PowerStatus;
            return powerStatus.BatteryLifePercent * 100;
        }

        public bool ChargingStatus()
        {
            PowerStatus powerStatus = SystemInformation.PowerStatus;
            BatteryChargeStatus batteryStatus = powerStatus.BatteryChargeStatus;

            if ((batteryStatus & BatteryChargeStatus.Charging) == BatteryChargeStatus.Charging)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
    }
}
