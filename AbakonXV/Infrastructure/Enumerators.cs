﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbakonXVWPF.Infrastructure;

namespace AbakonXVWPF
{

    public enum WindowContextEnum
    {
        empty,
        persons,
        employees,
        measuringLabs,
        measuringDevices,
        documents,
        activities
    }

    public enum EquipmentTypeEnum
    {
        PrzyrzadyWszystkie = 0,
        Elektryczne = 1,
        Mechaniczne = 2,
        Sprawdziany = 3,
        SprawdzianyDoGwintow = 4
    }

}
