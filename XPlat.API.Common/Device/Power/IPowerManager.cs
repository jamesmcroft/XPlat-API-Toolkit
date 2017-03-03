﻿namespace XPlat.API.Device.Power
{
    using System;

    public interface IPowerManager
    {
        /// <summary>
        /// Occurs when BatteryStatus changes.
        /// </summary>
        event EventHandler<BatteryStatus> BatteryStatusChanged;

        /// <summary>
        /// Occurs when RemainingChargePercent changes.
        /// </summary>
        event EventHandler<int> RemainingChargePercentChanged;

        /// <summary>
        /// Gets the device's battery status.
        /// </summary>
        BatteryStatus BatteryStatus { get; }

        /// <summary>
        /// Gets the total percentage of charge remaining from all batteries connected to the device.
        /// </summary>
        int RemainingChargePercent { get; }
    }
}