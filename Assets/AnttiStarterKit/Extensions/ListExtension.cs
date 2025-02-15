﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AnttiStarterKit.Extensions
{
    public static class ListExtension
    {
        public static T Random<T>(this IList<T> list)
        {
            return list.Any() ? list[UnityEngine.Random.Range(0, list.Count)] : default;
        }
    }
}