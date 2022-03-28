the code from this repo has now been merged into [NeosExposePatchedMethods](https://github.com/EIA485/NeosExposePatchedMethods)



# ExposePatchedMethodsEverywhere

A [NeosModLoader](https://github.com/zkxs/NeosModLoader) mod for [Neos VR](https://neos.com/) that exposes what mods you have loaded. it does this by creating a slot called "Loaded mods" under your userroot and userspace rootslot with its children being all of the harmony ids that had been used to patch a method at the time this mod was called. mods are called in mod file name alphabetical order. if you want this mod to exposes all mods then prefix it's file name with zz. if you want to only expose what mods you have loaded to your userspace but not under your userroot you can use [NeosExposePatchedMethods](https://github.com/EIA485/NeosExposePatchedMethods). this mod is a temporary mod that will exist till the [NeosModLoader](https://github.com/zkxs/NeosModLoader) implements a config system. once the [NeosModLoader](https://github.com/zkxs/NeosModLoader) implements a config system this mod will be merged into [NeosExposePatchedMethods](https://github.com/EIA485/NeosExposePatchedMethods).
## Installation
1. Install [NeosModLoader](https://github.com/zkxs/NeosModLoader).
1. Place [ExposePatchedMethodsEverywhere.dll](https://github.com/eia485/NeosExposePatchedMethodsEverywhere/releases/latest/download/ExposePatchedMethodsEverywhere.dll) into your `nml_mods` folder. This folder should be at `C:\Program Files (x86)\Steam\steamapps\common\NeosVR\nml_mods` for a default install. You can create it if it's missing, or if you launch the game once with NeosModLoader installed it will create the folder for you.
1. Start the game. If you want to verify that the mod is working you can check your Neos logs.
