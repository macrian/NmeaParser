﻿
namespace NmeaParser.NmeaLines
{
    public enum FixQuality : int
    {
        /// <summary>Fix not available or invalid</summary>
        Invalid = 0,
        /// <summary>GPS SPS Mode, fix valid</summary>
        GpsFix = 1,
        /// <summary>Differential GPS, SPS Mode, or Satellite Based Augmentation System (SBAS), fix valid</summary>
        DgpsFix = 2,
        /// <summary>GPS PPS (Precise Positioning Service) mode, fix valid</summary>
        PpsFix = 3,
        /// <summary>Real Time Kinematic (Fixed). System used in RTK mode with fixed integers</summary>
        Rtk = 4,
        /// <summary>Real Time Kinematic (Floating). Satellite system used in RTK mode, floating integers</summary>
        FloatRtk = 5,
        /// <summary>Estimated (dead reckoning) mode</summary>
        Estimated = 6,
        /// <summary>Manual input mode</summary>
        ManualInput = 7,
        /// <summary>Simulator mode</summary>
        Simulation = 8
    }
}
