using BepInEx;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScannablePlayerItems
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        Plugin()
        {
            HarmonyPatches.ApplyHarmonyPatches();
        }

        void Init()
        {
            if (ScanNodeSetUp.instance == null)
            {
                HarmonyPatches.ApplyHarmonyPatches();
                ScanNodeSetUp.instance = new GameObject("CustomScanNodeScript").AddComponent<ScanNodeSetUp>();
                DontDestroyOnLoad(ScanNodeSetUp.instance.gameObject);
            }
        }
        void Start()
        {
            HarmonyPatches.ApplyHarmonyPatches();
            Init();
        }
        void OnDestory()
        {
            HarmonyPatches.ApplyHarmonyPatches();
            Init();
        }
    }

    public class ScanNodeSetUp : MonoBehaviour
    {
        public static volatile ScanNodeSetUp instance;
        static GameObject ScanNode;

        void Start()
        {
            HarmonyPatches.ApplyHarmonyPatches();
        }
        public static void AddNode(GrabbableObject obj)
        {
            if (ScanNode == null)
            {
                ScanNode = FindObjectOfType<ScanNodeProperties>().gameObject;
            }
            if (obj.GetType() == typeof(Shovel))
            {
                GameObject sn = Instantiate(ScanNode, obj.transform.position, Quaternion.Euler(Vector3.zero), obj.transform);
                ScanNodeProperties node = sn.GetComponent<ScanNodeProperties>();
                node.nodeType = 0;
                node.headerText = "Shovel";
                node.subText = "Hit Enemys";
                node.scrapValue = 0;
                node.minRange = 1; 
                node.maxRange = 13;
                node.creatureScanID = -1;
            }
            if (obj.GetType() == typeof(SprayPaintItem))
            {
                GameObject sn = Instantiate(ScanNode, obj.transform.position, Quaternion.Euler(Vector3.zero), obj.transform);
                ScanNodeProperties node = sn.GetComponent<ScanNodeProperties>();
                node.nodeType = 0;
                node.headerText = "Spary Paint";
                node.subText = "Mark A Trail";
                node.scrapValue = 0;
                node.minRange = 1;
                node.maxRange = 13;
                node.creatureScanID = -1;
            }
            if (obj.GetType() == typeof(FlashlightItem))
            {
                GameObject sn = Instantiate(ScanNode, obj.transform.position, Quaternion.Euler(Vector3.zero), obj.transform);
                ScanNodeProperties node = sn.GetComponent<ScanNodeProperties>();
                node.nodeType = 0;
                if (obj.name.Contains("BB"))
                {
                    node.headerText = "Pro Flashlight";
                    node.subText = "Flashlight But Better";
                }
                else
                {
                    node.headerText = "Flashlight";
                    node.subText = "Make Sure to Charge me!";
                }
                node.scrapValue = 0;
                node.minRange = 1; 
                node.maxRange = 13;
                node.creatureScanID = -1;
            }
            if (obj.GetType() == typeof(BoomboxItem))
            {
                GameObject sn = Instantiate(ScanNode, obj.transform.position, Quaternion.Euler(Vector3.zero), obj.transform);
                ScanNodeProperties node = sn.GetComponent<ScanNodeProperties>();
                node.nodeType = 0;
                node.headerText = "BoomBox";
                node.subText = "Boots'n-cats'n..";
                node.scrapValue = 0; node.minRange = 1; node.maxRange = 13;
                node.creatureScanID = -1;
            }
            if (obj.GetType() == typeof(PatcherTool))
            {
                GameObject sn = Instantiate(ScanNode, obj.transform.position, Quaternion.Euler(Vector3.zero), obj.transform);
                ScanNodeProperties node = sn.GetComponent<ScanNodeProperties>();
                node.nodeType = 0;
                node.headerText = "ZapGun";
                node.subText = "Stun Enemies";
                node.scrapValue = 0; 
                node.minRange = 1;
                node.maxRange = 13;
                node.creatureScanID = -1;
            }
            if (obj.GetType() == typeof(StunGrenadeItem))
            {
                GameObject sn = Instantiate(ScanNode, obj.transform.position, Quaternion.Euler(Vector3.zero), obj.transform);
                ScanNodeProperties node = sn.GetComponent<ScanNodeProperties>();
                node.nodeType = 1;
                node.headerText = "Stun Grenade";
                node.subText = "KABOOM!";
                node.scrapValue = 0; 
                node.minRange = 1; 
                node.maxRange = 13;
                node.creatureScanID = -1;
            }
            if (obj.GetType() == typeof(TetraChemicalItem))
            {
                GameObject sn = Instantiate(ScanNode, obj.transform.position, Quaternion.Euler(Vector3.zero), obj.transform);
                ScanNodeProperties node = sn.GetComponent<ScanNodeProperties>();
                node.nodeType = 0;
                node.headerText = "TZP";
                node.subText = "Good for Headaches";
                node.scrapValue = 0; 
                node.minRange = 1;
                node.maxRange = 13;
                node.creatureScanID = -1;
            }
            if (obj.GetType() == typeof(ExtensionLadderItem))
            {
                GameObject sn = Instantiate(ScanNode, obj.transform.position, Quaternion.Euler(Vector3.zero), obj.transform);
                ScanNodeProperties node = sn.GetComponent<ScanNodeProperties>();
                node.nodeType = 1;
                node.headerText = "Extendable Ladder";
                node.subText = "Deploy With Care";
                node.scrapValue = 0; 
                node.minRange = 1; 
                node.maxRange = 13;
                node.creatureScanID = -1;
            }
            if (obj.GetType() == typeof(WalkieTalkie))
            {
                GameObject sn = Instantiate(ScanNode, obj.transform.position, Quaternion.Euler(Vector3.zero), obj.transform);
                ScanNodeProperties node = sn.GetComponent<ScanNodeProperties>();
                node.nodeType = 0;
                node.headerText = "Walkie-Talkie";
                node.subText = "Communicate Easy";
                node.scrapValue = 0;
                node.minRange = 1;
                node.maxRange = 13;
                node.creatureScanID = -1;
            }
            if (obj.GetType() == typeof(LockPicker))
            {
                GameObject sn = Instantiate(ScanNode, obj.transform.position, Quaternion.Euler(Vector3.zero), obj.transform);
                ScanNodeProperties node = sn.GetComponent<ScanNodeProperties>();
                node.nodeType = 0;
                node.headerText = "Lock Pick";
                node.subText = "Who Needs Keys?";
                node.scrapValue = 0;
                node.minRange = 1;
                node.maxRange = 13;
                node.creatureScanID = -1;
            }
            if (obj.GetType() == typeof(JetpackItem))
            {
                GameObject sn = Instantiate(ScanNode, obj.transform.position, Quaternion.Euler(Vector3.zero), obj.transform);
                ScanNodeProperties node = sn.GetComponent<ScanNodeProperties>();
                node.nodeType = 1;
                node.headerText = "JetPack";
                node.subText = "WEEEE!";
                node.scrapValue = 0;
                node.minRange = 1;
                node.maxRange = 13;
                node.creatureScanID = -1;
            }
        }
    }
}
