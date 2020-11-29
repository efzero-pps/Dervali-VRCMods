using System;
using System.Linq;
using System.Collections;
using MelonLoader;
using UIExpansionKit.API;
using UnityEngine;
using VRC.SDKBase;
using Boo.Lang;

[assembly: MelonInfo(typeof(RemoveChairs.Main), "RemoveChairs", "1.1.5", "Nirvash")]
[assembly: MelonGame("VRChat", "VRChat")]


namespace RemoveChairs
{
    public class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            MelonMod uiExpansionKit = MelonLoader.Main.Mods.Find(m => m.InfoAttribute.Name == "UI Expansion Kit");
            if (uiExpansionKit != null)
            {
                uiExpansionKit.InfoAttribute.SystemType.Assembly.GetTypes().First(t => t.FullName == "UIExpansionKit.API.ExpansionKitApi").GetMethod("RegisterWaitConditionBeforeDecorating", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static).Invoke(null, new object[]
                {
                    CreateQuickMenuButton()
                });
            }
        }

        private IEnumerator CreateQuickMenuButton()
        {
                while (QuickMenu.prop_QuickMenu_0 == null) yield return null;
               
                ExpansionKitApi.RegisterSimpleMenuButton(ExpandedMenu.WorldMenu, "Disable Active Chairs", new Action(() =>
                {
                    int countChange = 0;
                    var objects = Resources.FindObjectsOfTypeAll<VRCStation>();
                    foreach (var item in objects)
                    {
                        if (item.gameObject.active) //Only disable active chairs
                        {
                            countChange++;
                            objectsDisabled.Add(item); 
                            item.gameObject.SetActive(false); // item.gameObject finds the parent gameObject of the VRCStation 
                        }
                    }
                    MelonLogger.Log("Disabled " + countChange + " chair objects");
                }));
                ExpansionKitApi.RegisterSimpleMenuButton(ExpandedMenu.WorldMenu, "Re-enable Chairs", new Action(() =>
                {
                    int countChange = 0;
                    foreach (var item in objectsDisabled)
                    {
                        countChange++;
                        item.gameObject.SetActive(true);
                    }
                    MelonLogger.Log("Enabled " + countChange + " chair objects");
                    objectsDisabled.Clear();
                }));
        }

        List<VRCStation> objectsDisabled = new List<VRCStation>();

        public override void OnLevelWasLoaded(int level)
        {
            
            switch (level)//Without switch this would run 3 times at world load
            {
                case 0: //App
                case 1: //ui
                    break;
                default:
                    objectsDisabled.Clear(); //Clear the list if we change worlds 
                    break;
            }
        }


    }
}