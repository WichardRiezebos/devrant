# DevRant
 
Unofficial devrant.io public api client.

| | |
| --- | --- |
| **Build** | [![Build status](https://ci.appveyor.com/api/projects/status/mecpjf5cwqpdgd67?svg=true)](https://ci.appveyor.com/project/WichardRiezebos/devrant) |
| **NuGet** | [![NuGet](https://buildstats.info/nuget/DevRant)](https://www.nuget.org/packages/DevRant/) |
| **Gitter** |  [![Join the chat at https://gitter.im/devrant-csharp/Lobby](https://badges.gitter.im/devrant-csharp/Lobby.svg)](https://gitter.im/devrant-csharp/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) |

## Prerequisites

- .NET Framework 4.5

## Installation

Install the NuGet package using the command below:

```
Install-Package DevRant
```

...or search for `DevRant` in the NuGet index.

## Getting started
The code below is an example how to use the library.

```
using DevRant;

using(var devRant = new DevRantClient())
{
    var profile = await devRant.GetProfileAsync("WichardRiezebos");
}
```

## Methods

- GetProfileAsync(username)


## Limitations

Not all methods are available yet.