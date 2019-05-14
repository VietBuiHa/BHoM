﻿/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2019, the respective contributors. All rights reserved.
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
using BH.oM.Environment.Fragments;

namespace BH.oM.Environment.Gains
{
    public class InternalCondition : BHoMObject, IEnvironmentObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public List<Emitter> Emitters { get; set; } = new List<Emitter>();

        public bool IncludeSolarInMeanRadiantTemp { get; set; } = true;

        public List<SimulationDayType> DayTypes { get; set; } = new List<SimulationDayType>();

        public List<Gain> Gains { get; set; } = new List<Gain>();

        public Thermostat Thermostat { get; set; } = new Thermostat();

        public List<IBHoMFragment> FragmentProperties { get; set; } = new List<IBHoMFragment>();
        /***************************************************/
    }
}