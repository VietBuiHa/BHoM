/*
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

using BH.oM.Environment.Fragments;
using BH.oM.Environment.Gains;
using BH.oM.Architecture.Elements;

using BH.oM.Geometry;
using System.ComponentModel;

using BH.oM.Environment.Ventilation;
using BH.oM.Dimensional;

namespace BH.oM.Environment.Elements
{
    [Description("A space object is an analytical depiction of a room defined by its environmental conditions (internal gains)")]
    public class Space : BHoMObject, IEnvironmentObject, IElement2D
    {
        [Description("Zones denotes the list of zones that this particular space is associated with. Zones are collections of spaces with similar internal gains and exterior envelope conditions.")]
        public virtual List<string> Zones { get; set; } = new List<string>();

        [Description("Lighting gains are objects that are defined as the amount of heat contributed by light fixtures within the space")]
        public virtual Gains.Lighting LightingGain { get; set; } = new Gains.Lighting();

        [Description("Equipment gains are objects that are defined as the amount of heat contributed by equipment within the space")]
        public virtual Gains.Equipment EquipmentGain { get; set; } = new Gains.Equipment();

        [Description("People gains are objects that are defined as the amount of heat contributed by people based on their assumed activity level within the space (dancing, sitting, etc)")]
        public virtual Gains.People PeopleGain { get; set; } = new Gains.People();

        [Description("Infiltration gains are objects that are defined as the amount of heat or heat loss contributed by cracks in the exterior envelope of the building which allow unconditioned outside air to be introduced to the space")]
        public virtual Gains.Infiltration Infiltration { get; set; } = new Gains.Infiltration();

        [Description("Ventilation is an object that defines the amount of outside air that should be introduced to a space, which is typically based on the number of occupants breathing the air and the area of the space.")]
        public virtual Ventilation.Ventilation Ventilation { get; set; } = new Ventilation.Ventilation();

        [Description("Exhaust is an object that defines the amount of air that should be extracted from a space, which is either based on the objects within the space (toilets, showers) or the space type (kitchen, bathroom).")]
        public virtual Gains.Exhaust Exhaust { get; set; } = new Gains.Exhaust();

        [Description("Occupant Density is an object that defines the area occupied by each individual in a space (2 m2 per person).")]
        public virtual Occupancy OccupantDensity { get; set; } = new Occupancy();

        [Description("Acoustics for an Environments Space define the noise within the space, by noise created by the velocity of the air within the ducts in the space, the Noise Rating, and decibel.")]
        public virtual Gains.Acoustics Acoustics { get; set; } = new Gains.Acoustics();

        [Description("Project Space Type is a string that defines how the space is used on a given project(Museum, Corridor, etc)")]
        public virtual string ProjectSpaceType { get; set; } = "";

        [Description("Space Type is an enum that defines how the space is used (Museum, Corridor, etc)")]
        public virtual SpaceType SpaceType { get; set; } = SpaceType.Undefined;

        [Description("A point in 3D space providing a location point of the space")]
        public virtual Point Location { get; set; } = new Point();

        [Description("A 2D curve defining the external boundaries of the floor of the space")]
        public virtual ICurve Perimeter { get; set; } = new Polyline();
    }
}

