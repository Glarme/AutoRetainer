﻿using AutoRetainer.Modules.EzIPCManagers;
using AutoRetainer.UI.NeoUI;
using AutoRetainer.UI.Statistics;

namespace AutoRetainer.Services;
public static class AutoRetainerServiceManager
{
    public static NeoWindow NeoWindow { get; private set; }
    public static EzIPCManager EzIPCManager { get; private set; }
    public static FCPointsUpdater FCPointsUpdater { get; private set; }
    public static FCData FCData { get; private set; }
    public static GilDisplay GilDisplay { get; private set; }
    public static VentureStats VentureStatsManager { get; private set; }

}
