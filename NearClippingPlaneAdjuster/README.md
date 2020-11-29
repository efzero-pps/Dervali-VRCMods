This is a collection of a few simple mods I have made. 
They all require [Melon Loader](https://melonwiki.xyz/#/README?id=installation-on-il2cpp-games) and [UIExpansionKit](https://github.com/knah/VRCMods/)

**USE IT AT YOUR OWN RISK. Modding the client is against VRChat's ToS. I am not responsible for any bans or any punishments you may get by using these mods**

**This was made in my free time, and is provided AS IS without warranty of any kind, express or implied. Any use is at your own risk and you accept all responsibility**


# VRC-NearClippingPlaneAdjuster
This is a mod for adjusting the near clipping plane for the player's camera. This can allow you to get much closer to objects before they start clipping and be used for seeing your limbs with a VERY small avatar. 

Note: This mod will not fix your menu breaking at small avatar sizes. However, the keyboard shortcut 'Ctrl + \\' works for setting you to the default avatar size. 

This mod requires [Melon Loader](/https://melonwiki.xyz/#/README?id=installation-on-il2cpp-games) and [UIExpansionKit](https://github.com/knah/VRCMods/)

Once you install the mod you should see new options to the left of your Settings menu. 

![Ingame Menu](https://user-images.githubusercontent.com/4786654/86502853-7b8acb80-bd6d-11ea-8d7f-94be7136abd0.png)

Very rarely using .0001 near plane distance will stop you from being able to interact with your menu, I have only ever seen this in a handful of worlds where the player location is far from the origin of the map. However .01 should always be safe to use as that is the normal minimum size Unity lets you use. 


VRChat will set this back to default every world change. This mod will set the near plane clipping distance to .01 15 seconds after you load into a world.  (Reason for the delay is that we can't know exactly when the world's referenceCamera's settings are copied onto the player's camera)

Now adjusts the clipping plane on your photo camera thanks to an addition by tylerhasman.
