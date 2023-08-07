﻿using AutoRetainer.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRetainer.Scheduler.Tasks.Voyage
{
    internal static class TaskEnterMenu
    {
        internal static void Enqueue(VoyageType type)
        {
            if (type == VoyageType.Airship)
            {
                P.TaskManager.Enqueue(SchedulerVoyage.SelectAirshipManagement);
            }
            else if (type == VoyageType.Submersible)
            {
                P.TaskManager.Enqueue(SchedulerVoyage.SelectSubManagement);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(type));
            }
        }
    }
}
