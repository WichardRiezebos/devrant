# DevRant
[![Build status](https://ci.appveyor.com/api/projects/status/mecpjf5cwqpdgd67?svg=true)](https://ci.appveyor.com/project/WichardRiezebos/devrant) [![NuGet](https://buildstats.info/nuget/DevRant)](https://www.nuget.org/packages/DevRant/) [![Join the chat at https://gitter.im/devrant-csharp/Lobby](https://badges.gitter.im/devrant-csharp/Lobby.svg)](https://gitter.im/devrant-csharp/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

Unofficial **csharp-client** for the *public* [devRant](https://www.devrant.io/) API. 
*Based on: [danillouz/devrant](https://github.com/danillouz/devrant)*

![Cartoon 2](https://www.devrant.io/static/devrant/img/cartoon2.png)

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
using DevRant.Dtos;
....
using(var devRant = new DevRantClient())
{
    var profile = await devRant.GetProfileAsync("WichardRiezebos");
	var topTenRants = await devRant.GetRantsAsync(sort: RantSort.Top, limit: 10);
}
```

## Methods
All the available rest-api method(s) are described below:

| API | METHOD |  DESCRIPTION |
| --- | --- | --- | 
| [/api/user/{id}/](https://devrant.io/api/users/404181?app=3) | [GetProfileAsync](#getprofileasync) | Gets the complete profile of a devRant user. |
| [/api/devrant/rants/](https://devrant.io/api/devrant/rants?app=3&sort=algo&limit=50&skip=0) | [GetRantsAsync](#getrantsasync) | Gets a collection with rants. |

### GetProfileAsync

###### Arguments
| NAME | MANDATORY |  TYPE |
| --- | --- | --- |  
| username |  yes | string | 

### GetRantsAsync

###### Arguments
| NAME | MANDATORY |  TYPE | DEFAULT |
| --- | --- | --- | --- |
| sort |  no | enum (algo, recent and top) | algo |
| limit |  no | int | 50 |
| skip |  no | int | 0 |

## Limitations

- Not all methods are available yet. 
- Explicit use of `Task Async`.