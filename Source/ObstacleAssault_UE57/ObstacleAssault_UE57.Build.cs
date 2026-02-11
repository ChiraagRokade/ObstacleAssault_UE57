// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ObstacleAssault_UE57 : ModuleRules
{
	public ObstacleAssault_UE57(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ObstacleAssault_UE57",
			"ObstacleAssault_UE57/Variant_Platforming",
			"ObstacleAssault_UE57/Variant_Platforming/Animation",
			"ObstacleAssault_UE57/Variant_Combat",
			"ObstacleAssault_UE57/Variant_Combat/AI",
			"ObstacleAssault_UE57/Variant_Combat/Animation",
			"ObstacleAssault_UE57/Variant_Combat/Gameplay",
			"ObstacleAssault_UE57/Variant_Combat/Interfaces",
			"ObstacleAssault_UE57/Variant_Combat/UI",
			"ObstacleAssault_UE57/Variant_SideScrolling",
			"ObstacleAssault_UE57/Variant_SideScrolling/AI",
			"ObstacleAssault_UE57/Variant_SideScrolling/Gameplay",
			"ObstacleAssault_UE57/Variant_SideScrolling/Interfaces",
			"ObstacleAssault_UE57/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
