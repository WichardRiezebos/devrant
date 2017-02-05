# DevRant
 
Unofficial devrant.io public api client.

| | |
| --- | --- |
| **Build** | - |
| **NuGet** | [![NuGet](https://buildstats.info/nuget/DevRant)](https://www.nuget.org/packages/DevRant/) |
| **Gitter** | |

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