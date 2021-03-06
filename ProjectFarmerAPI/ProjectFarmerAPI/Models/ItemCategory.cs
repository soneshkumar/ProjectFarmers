﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.Models
{
    public enum ItemCategory
    {
        /// <summary>
        /// None is for invalid/wrong entry cases
        /// </summary>
        None = -1,
        /// <summary>
        /// We will be selling only Vegetables as of now
        /// </summary>
        Vegetable = 1,
        /// <summary>
        /// The Fruits
        /// </summary>
        Fruits = 2
    }
}