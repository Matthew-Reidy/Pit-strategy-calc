using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ksBroadcastingNetwork;
using AssettoCorsaSharedMemory;
using System.Security.Policy;
using ksBroadcastingNetwork.Structs;

namespace ACCPitstopCalcGUI
{
    internal class Program
    {
        /*public static CarInfo carInfo;
        public static RealtimeCarUpdate realTimeCarUpdate;
        public static RealtimeUpdate realTimeUpdate;
        public static TrackData trackData;
        public static BroadcastingEvent broadcastingEvents;
        public static ACCUdpRemoteClient client;
        public static BroadcastingNetworkProtocol protocol;*/
        public static Graphics graphics;
        public static Physics physics;
        public static StaticInfo staticInfo;
        public static AssettoCorsaSharedMemory.AssettoCorsa sharedMemory;

        public static bool memoryConnected = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            sharedMemory = new();
            //client = new("127.0.0.1", 9000, "Shentar", "asd", "", 10);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmGUI());
        }
        
    }
}
