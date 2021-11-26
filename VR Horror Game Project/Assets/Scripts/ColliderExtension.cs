﻿using UnityEngine;

namespace Project.Core.Extensions
{
    public static class ColliderExtensions
    {
        public static bool IsTriggerButton(this Collider col)
        {
            return col.tag == "ButtonActivator";
        }
    }
}