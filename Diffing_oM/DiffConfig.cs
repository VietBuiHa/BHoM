/*	
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
using System.ComponentModel;

namespace BH.oM.Diffing
{
    [Description("General configurations for the Diffing process, including settings for the Hash computation.")]
    public class DiffConfig : BHoMObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public double NumericTolerance { get; set; } = 1e-6;

        [Description("List of strings specifying the names of the properties that should be ignored in the diffing.\n" +
            "This includes any sub-object or sub-property. Any property with a name matching any of this list will be ignored.\n" +
            "By default it includes `BHoM_Guid`.")]
        public List<string> PropertiesToIgnore { get; set; } = new List<string>() { "BHoM_Guid" };

        [Description("Enables the property-level diffing: differences in object properties are stored in the `ModifiedPropsPerObject` dictionary.")]
        public bool EnablePropertyDiffing { get; set; } = true;

        [Description("If enabled, the Diff stores also the objects that did not change (`Unchanged` property).")]
        public bool StoreUnchangedObjects { get; set; } = false;

        /***************************************************/
    }
}