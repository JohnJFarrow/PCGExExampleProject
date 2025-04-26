// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PCGExExampleProject : ModuleRules
{
	public PCGExExampleProject( ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[]
		{
			"AIModule",
			"Core",
			"CoreUObject",
            "EnhancedInput",
            "Engine",
            "InputCore",
			"MassCommon",
            "MassEntity",
			"MassMovement",
			"MassNavigation",
            "MassSpawner",
			"PCG"
		});

	}
}
