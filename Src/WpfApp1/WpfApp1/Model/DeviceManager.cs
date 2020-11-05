using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Model
{
    public class DeviceManager
    {
        #region " Property "
        /// <summary>
        /// SN
        /// </summary>
        public string SN;

        /// <summary>
        /// Device Model
        /// </summary>
        public string model;
        #endregion

        #region " Constructor "
        /// <summary>
        /// Handle the device manager
        /// </summary>
        public DeviceManager()
        {
            SN = "DT20201105";
            model = "AS332T";
        }
        #endregion

        #region " Method "
        /// <summary>
        /// Show the device info
        /// </summary>
        public void showInfo()
        {
            MessageBox.Show("The device model is " + model + "\r\n" + "SN: " + SN, "Device Information");
        }

        #endregion
    }
}
