using System;
using System.Linq;
using System.Collections;
using MelonLoader;
using UIExpansionKit.API;
using UnityEngine;
using VRC.SDKBase;

[assembly: MelonInfo(typeof(RemoveChairs.Main), "RemoveChairs", "1.0.0", "Nirvash")]
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
                ExpansionKitApi.RegisterSimpleMenuButton(ExpandedMenu.SettingsMenu, "Remove All Chairs", new Action(() =>
                {
                    var objects = Resources.FindObjectsOfTypeAll<VRCStation>();
                    foreach (var item in objects)
                    {
                        UnityEngine.Object.Destroy(item.gameObject); // item.gameObject finds the parent gameObject of the VRCStation 
                        MelonLogger.Log("Destroyed chair object");
                    }
                }));
        }

    }
}