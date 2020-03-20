﻿/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BH.oM.Base;
using System.ComponentModel;

namespace BH.oM.Environment.Gains
{
    [Description("Exhaust is indicative of the amount of air that should be extracted from a space based on the space type (eg laboratory, woodshop) or fixtures contained within the space (eg toilets, showers)")]
    public class Exhaust : BHoMObject
    {
        [Description("The continuous exhaust rate associated with a particular space type (eg pet shop, printing room) measured in m3/s*m2")]
        public double SpaceTypeContinuous { get; set; } = 0.0;

        [Description("The exhaust rate associated with a particular fixture type (eg toilets, showers) that is run continuously, meaning that it is not triggered by a sensor or switch and is measured in m3/s*unit")]
        public double UnitContinuous { get; set; } = 0.0;

        [Description("The exhaust rate associated with a particular fixture type (eg toilets, showers) that is run intermittently, meaning that it is triggered by a sensor or switch and is measured in m3/s*unit")]
        public double UnitIntermittent { get; set; } = 0.0;

    }
}
