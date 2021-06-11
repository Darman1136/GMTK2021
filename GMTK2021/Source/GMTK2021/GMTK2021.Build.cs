// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GMTK2021 : ModuleRules
{
	public GMTK2021(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
