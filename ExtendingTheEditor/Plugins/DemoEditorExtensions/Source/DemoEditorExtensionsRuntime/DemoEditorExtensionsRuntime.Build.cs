using UnrealBuildTool;

public class DemoEditorExtensionsRuntime : ModuleRules
{
	public DemoEditorExtensionsRuntime(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        PublicDependencyModuleNames.AddRange(
			new string[] {
				"Core",
				"CoreUObject",
				"Engine",
				"Slate"
			}
		);
	}
}