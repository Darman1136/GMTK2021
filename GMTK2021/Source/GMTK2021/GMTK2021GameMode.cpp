// Copyright Epic Games, Inc. All Rights Reserved.

#include "GMTK2021GameMode.h"
#include "GMTK2021Pawn.h"

AGMTK2021GameMode::AGMTK2021GameMode()
{
	// set default pawn class to our character class
	DefaultPawnClass = AGMTK2021Pawn::StaticClass();
}

