using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssettoCorsaSharedMemory
{
    public enum ACC_FLAG_TYPE
    {
        ACC_NO_FLAG = 0,
        ACC_BLUE_FLAG = 1,
        ACC_YELLOW_FLAG = 2,
        ACC_BLACK_FLAG = 3,
        ACC_WHITE_FLAG = 4,
        ACC_CHECKERED_FLAG = 5,
        ACC_PENALTY_FLAG = 6
    }

    public enum ACC_STATUS
    {
        AC_OFF = 0,
        AC_REPLAY = 1,
        AC_LIVE = 2,
        AC_PAUSE = 3
    }

    public enum ACC_SESSION_TYPE
    {
        ACC_UNKNOWN = -1,
        ACC_PRACTICE = 0,
        ACC_QUALIFY = 1,
        ACC_RACE = 2,
        ACC_HOTLAP = 3,
        ACC_TIME_ATTACK = 4,
        ACC_DRIFT = 5,
        ACC_DRAG = 6,
        ACC_HOTSTINT = 7,
        ACC_HOTSTINTSUPERPOLE = 8
    }
    public enum ACC_PENALTY_TYPE
    {
        ACC_None = 0,
        ACC_DriveThrough_Cutting = 1,
        ACC_StopAndGo_10_Cutting = 2,
        ACC_StopAndGo_20_Cutting = 3,
        ACC_StopAndGo_30_Cutting = 4,
        ACC_Disqualified_Cutting = 5,
        ACC_RemoveBestLaptime_Cutting = 6,
        ACC_DriveThrough_PitSpeeding = 7,
        ACC_StopAndGo_10_PitSpeeding = 8,
        ACC_StopAndGo_20_PitSpeeding = 9,
        ACC_StopAndGo_30_PitSpeeding = 10,
        ACC_Disqualified_PitSpeeding = 11,
        ACC_RemoveBestLaptime_PitSpeeding = 12,
        ACC_Disqualified_IgnoredMandatoryPit = 13,
        ACC_PostRaceTime = 14,
        ACC_Disqualified_Trolling = 15,
        ACC_Disqualified_PitEntry = 16,
        ACC_Disqualified_PitExit = 17,
        ACC_Disqualified_Wrongway = 18,
        ACC_DriveThrough_IgnoredDriverStint = 19,
        ACC_Disqualified_IgnoredDriverStint = 20,
        ACC_Disqualified_ExceededDriverStintLimit = 21
    }
    public enum ACC_TRACK_GRIP_STATUS
    {
        ACC_GREEN = 0,
        ACC_FAST = 1,
        ACC_OPTIMUM = 2,
        ACC_GREASY = 3,
        ACC_DAMP = 4,
        ACC_WET = 5,
        ACC_FLOODED = 6
    }
    public enum ACC_RAIN_INTENSITY
    {
        ACC_NO_RAIN = 0,
        ACC_DRIZZLE = 1,
        ACC_LIGHT_RAIN = 2,
        ACC_MEDIUM_RAIN = 3,
        ACC_HEAVY_RAIN = 4,
        ACC_THUNDERSTORM = 5
    }
    public class GraphicsEventArgs : EventArgs
    {
        public GraphicsEventArgs(Graphics graphics)
        {
            this.Graphics = graphics;
        }

        public Graphics Graphics { get; private set; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct Graphics
    {
        public int PacketId;
        public ACC_STATUS Status;
        public ACC_SESSION_TYPE Session;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public String CurrentTime;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public String LastTime;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public String BestTime;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public String Split;

        public int CompletedLaps;
        public int Position;
        public int iCurrentTime;
        public int iLastTime;
        public int iBestTime;
        public float SessionTimeLeft;
        public float DistanceTraveled;
        public int IsInPit;
        public int CurrentSectorIndex;
        public int LastSectorTime;
        public int NumberOfLaps;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public String TyreCompound;

        public float ReplayTimeMultiplier;
        public float NormalizedCarPosition;
        public int ActiveCars;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 180)]
        public float[] CarCoordinates;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public int[] CarID;

        public int PlayerCarID;
        public float PenaltyTime;
        public ACC_FLAG_TYPE Flag;
        public ACC_PENALTY_TYPE Penalty;
        public int IdealLineOn;
        // since 1.5
        public int IsInPitLane;
        public float SurfaceGrip;

        // since 1.13
        public int MandatoryPitDone;

        public float WindSpeed;
        public float WindDirection;
        public float IsSetupMenuVisible;
        public int MainDisplayIndex;
        public int SecondaryDisplyIndex;
        public int TC;
        public int TCCUT;
        public int EngineMap;
        public int ABS;
        public float FuelXLap;
        public int Rainlights;
        public int FlashingLights;
        public int LightsStage;
        public float ExhaustTemperature;
        public int WiperLV;
        public int DriverStintTotalTimeLeft;
        public int DriverStintTimeLeft;
        public int RainTyres;
        public int SessionIndex;
        public float UsedFuel;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public String DeltaLapTime;

        public int iDeltaLapTime;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public String EstimatedLapTime;

        public int iEstimatedLapTime;
        public int IsDeltaPositive;
        public int iSplit;
        public int IsValidLap;
        public float FuelEstimatedLaps;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public String TrackStatus;

        public int MissingMandatoryPits;
        public float Clock;
        public int DirectionLightsLeft;
        public int DirectionLightsRight;
        public int GlobalYellow;
        public int GlobalYellow1;
        public int GlobalYellow2;
        public int GlobalYellow3;
        public int GlobalWhite;
        public int GlobalGreen;
        public int GlobalChequered;
        public int GlobalRed;
        public int MfdTyreSet;
        public float MfdFuelToAdd;
        public float MfdTyrePressureLF;
        public float MfdTyrePressureRF;
        public float MfdTyrePressureLR;
        public float MfdTyrePressureRR;
        public ACC_TRACK_GRIP_STATUS TrackGripStatus;
        public ACC_RAIN_INTENSITY RainIntensity;
        public ACC_RAIN_INTENSITY RainIntensityIn10Min;
        public ACC_RAIN_INTENSITY RainIntensityIn30Min;
    }
}
