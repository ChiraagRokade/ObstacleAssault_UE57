// Fill out your copyright notice in the Description page of Project Settings.


#include "MovingPlatform.h"

// Sets default values
AMovingPlatform::AMovingPlatform()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void AMovingPlatform::BeginPlay()
{
	Super::BeginPlay();
	StartLocation = GetActorLocation();
}

// Called every frame
void AMovingPlatform::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

	MovingPlatform(DeltaTime);
	RotatePlatform(DeltaTime);
}

void AMovingPlatform::MovingPlatform(float DeltaTime)
{
	// Move the platform by adding the velocity to the current location
	FVector CurrentLocation = GetActorLocation();
	// We multiply the velocity by DeltaTime to ensure consistent movement regardless of frame rate
	CurrentLocation = CurrentLocation + (PlatformVelocity * DeltaTime);
	SetActorLocation(CurrentLocation);
	// We also calculate the distance moved from the starting location to keep track of how far the platform has traveled
	DistanceMoved = FVector::Dist(StartLocation, CurrentLocation);
	if (DistanceMoved >= MoveDistance)
	{
		// If the platform has moved the specified distance, we reverse the velocity to make it move back
		PlatformVelocity = -PlatformVelocity;
		StartLocation = CurrentLocation;
	}
}

void AMovingPlatform::RotatePlatform(float DeltaTime)
{
	// Rotate the platform

//	FRotator CurrentRotation = GetActorRotation();
//	CurrentRotation = CurrentRotation + (PlatformVelocity * DeltaTime);
//	SetActorRotation(CurrentRotation);
}
