#pragma once

#include "BaseEditorTool.h"
#include "MirrorTool1.generated.h"

UCLASS(Blueprintable)
class UMirrorTool1 : public UBaseEditorTool
{
	GENERATED_BODY()

public:
	UMirrorTool1();

public:
	UPROPERTY(EditAnywhere, Category = "Settings")
	FPlane MirrorPlane;

	UFUNCTION(Exec)
	void MirrorSelectedObjects();
};
