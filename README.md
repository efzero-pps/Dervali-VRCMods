# Crashing after the last VRChat Update?

#### With the most recent VRChat update 1017 there are some conflicts between mods, mostly related to emmVRC. If you are crashing I recommend to try installing Advanced Safety https://github.com/knah/VRCMods/releases/tag/updates-2020-11-22  which seems to resolve the conflicts. Or removing one of the mods for the time being. 






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

# VRC-CameraResChanger
Another simple mod that does just one thing! This uses [UIExpansionKit](https://github.com/knah/V.RCMods/) to add a few buttons to your camera menu, allowing you to set the VRC camera resolution to, Default (1920x1080), 4K (3840x2160), 6k (5760x3240), 8k (7680x4320).

![image](https://user-images.githubusercontent.com/4786654/86955451-370c8080-c11d-11ea-8038-4b39c7c10979.png)

Couple notes: 
* Larger resolutions will cause your game to hang for a few seconds while it renders the image, I have not had VRC crash outright though, but in one instance an 8k photo took 30 seconds. 
* This will not work with Virtual Lens, that camera has a lot of hard coded resolution values in it's shaders. Using anything but the default resolution will just result in a picture of you. 

I would also recommend [CameraMinus](https://github.com/knah/VRCMods) for some other camera QoL. 

# VRC-RemoveChairs
Very simple mod which adds an Enable and Disable Chairs button to the Worlds menu that will locally toggle all active chairs in a world. Useful for when map makers put chairs in inconvenient locations and don't have a way to disable them.

![image](https://user-images.githubusercontent.com/68404726/97644297-ec8a7900-1a17-11eb-90ea-5280b1a6a78a.png)

# VRC-PlayerSpeedAdjSlower
Did you ever want to move slower in game? This mod lets you do that! This is a very simple mod that uses [UIExpansionKit](https://github.com/knah/VRCMods/) to add three buttons to your settings menu. Default Speed, Half speed and 1/10 speed. 
Honestly the main purpose for making this was use with very small avatars. 

![image](https://user-images.githubusercontent.com/4786654/86955342-07f60f00-c11d-11ea-8ef3-8e0e004efe52.png)

Count it as either a bug or a feature, but this does not affect the strafe speed, so you still can move side to side at full speed. 

After pressing the button it will set the speed every 30 seconds for 5 minutes, to allow you to switch avatars and keep the set speed.

