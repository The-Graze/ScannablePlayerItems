using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace ScannablePlayerItems.Patches
{       
    [HarmonyPatch(typeof(GrabbableObject))]
    [HarmonyPatch("Start", MethodType.Normal)]
    internal class ItemPatches
    {
        private static void Postfix(GrabbableObject __instance)
        {
            if (__instance.GetComponentInChildren<ScanNodeProperties>() == null)
            {
                ScanNodeSetUp.AddNode(__instance);
            }
        }
    }
}