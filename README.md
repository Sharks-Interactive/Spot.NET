
<p align='center'>
  <img src="https://i.imgur.com/FiqCe1Z.png" />
</p>

![npm version](https://img.shields.io/nuget/v/@sharks-interactive/spot.net)  ![npm downloads](https://img.shields.io/nuget/dt/@sharks-interactive/spot.net)  ![npm downloads](https://img.shields.io/github/license/@sharks-interactive/spot.net)

# Spot​​ .NET
**Spot .NET** is a lightweight C# SDK for controlling [Boston Dynamics](https://www.bostondynamics.com/) robots.

## Functionality
- Easily **connect and authenticate** to multiple robots of different types over grpc connection
- Support for **commands** for standing, sitting, walking and more!
- Containerised and easily extensible **commands** for adding new functionality
- **Full C# compiled Boston Dynamics protobufs**, for building out your own commands
- **Exposes authenticated Spot Channel** to add your own functionality such as receiving data from Spot

## Usage:
```
nuget install @sharks-interactive/spot.net
```

## Quick Examples:
#### Connecting to Spot
```csharp
using Sharks.Spot;

// Or whatever your entrypoint/function is
public static int main()
{
	// Create Spot Robot object with credentials to authenticate with it
	Robot Spot = new Robot(
		new Credentials()
		{
			Username = "SpotUsername",
			Password = "SpotPassword",
			Address = "192.168.0.0.2:443"
		}
	);

	// When your ready call connect to create the authenticated channel
	Spot.Connect();

	// Calling this will aquire a lease if we haven't already
	Sit(Spot); // Call a sit command on the Robot we've connected to
}
```

### Walk (with callback)
```csharp
using Sharks.Spot;

// Or whatever your entrypoint/function is
public static int main()
{
	// Create Spot Robot object with credentials to authenticate with it
	Robot Spot = new Robot(
		new Credentials()
		{
			Username = "SpotUsername",
			Password = "SpotPassword",
			Address = "192.168.0.0.2:443"
		}
	);

	Spot.Connect();

	// Api subject to change
	Walk(Spot, 5.0f, Direction.Forwards, WalkFinishedCallback);
}

private void WalkFinishedCallback()
{
	Console.WriteLine("Done walking!");
}
```

## Features:
- **.Connect()** authenticates and connects to a Robot
- **AquireLease(Robot)** Gets a lease for the given robot
- **Sit(Robot)** sends a command for a Robot to sit
- **Stand(Robot)** sends a command for a Robot to stand
- **Walk(Robot, Distance, Direction, Callback(optional))** sends a command for a Robot to walk
- **.Shutdown()** disconnects from a Robot and cleans up all channels
- **.ContactInfo** struct with all the information you need to contact a Robot for custom commands

## Options (Required)

| Option | Type | Description |
| ------ | ---- | ----------- |
| Creds  | Credentials | A struct containing all the necessary credentials to authenticate with the Robot. |


## How it works:
This library opens an authenticated GRPC channel to a Robot and contains Boston Dynamics protobufs compiled to C#, allowing you to send whatever commands you want to it.

**Read the wiki for extra documentation.**
  
Project created and maintained by Sharks Interactive.
  
### Developing:
  - Commit to ``staging`` and pr to ``prod`` for changes

### Code Style:
  - Continuous Integration will handle formatting for you.. Eventually. Do your best to adhere to what's already there if you're contributing.

## Acknowledgements:
**README.MD and general SDK structure, styling, practices etc, modelled after and taken from the excellent [Toucan-JS](https://github.com/robertcepa/toucan-js)**
