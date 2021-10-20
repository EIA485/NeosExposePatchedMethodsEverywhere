using HarmonyLib;
using NeosModLoader;
using FrooxEngine;
using System.Reflection;
using System.Collections.Generic;

namespace ExposePatchedMethodsEverywhere
{
	public class ExposePatchedMethodsEverywhere : NeosMod
	{
		public override string Name => "ExposePatchedMethodsEverywhere";
		public override string Author => "eia485";
		public override string Version => "1.0.0";
		public override string Link => "https://github.com/EIA485/NeosExposePatchedMethodsEverywhere/";
		static HashSet<string> HarmonyIds = new HashSet<string>();
		public override void OnEngineInit()
		{
			foreach (MethodBase method in Harmony.GetAllPatchedMethods())
			{
				foreach (string owner in Harmony.GetPatchInfo(method).Owners)
				{
						HarmonyIds.Add(owner);
				}
			}
			Harmony harmony = new Harmony("net.eia485.ExposePatchedMethodsEverywhere");
			harmony.PatchAll();
		}

		[HarmonyPatch]
		class ExposePatchedMethodsEverywherePatch
		{
			[HarmonyPostfix]
			[HarmonyPatch(typeof(Userspace), "OnAttach")]
			static void UserspaceOnAttachPostfix(Userspace __instance)
			{
				GenList(__instance.World.RootSlot);
			}
			[HarmonyPostfix]
			[HarmonyPatch(typeof(User), "Root", MethodType.Setter)]
			static void UserRootSetterPostfix(User __instance)
            {
				GenList(__instance.Root.Slot);
            }
		}

		static void GenList(Slot slot)
		{
			Slot list = slot.AddSlot("Loaded mods", false);
			foreach (string harmonyId in HarmonyIds)
			{
				list.AddSlot(harmonyId);
			}
		}
	}
}