# Simple Grid

## Table Of Contents 
 
<details>
<summary>Details</summary>

  - [Introduction](#introduction)
  - [How To Use](#how-to-use)
  - [Grid Settings](#grid-settings)
  - [Common Settings](#common-settings)
  - [Quadral Settings](#quadral-settings)
  - [Hexagonal Settings](#hexagonal-settings)
  - [Getting Grid Data](#getting-grid-data)
  - [Example 1](#example-1)
  - [Example 2](#example-2)
    
</details>

## Introduction
Simple Scriptable Object based grid creator for puzzle games

    
## How to use
To use SimpleGrid, you will need a Gameobject in which a script called "GridManager" is attached to. There are two ways of creating this gameobject </br>
 
 - You can either create an empty gameobject and attach "GridManager" script to it or go to window menu and select "Create Simple Grid Object" </br>

https://user-images.githubusercontent.com/59537269/161431652-703db589-e783-459e-bd96-68d19784eb15.mp4

 - After that, In order for SimpleGrid to work, you need to attach a Grid Settings as shown below

https://user-images.githubusercontent.com/59537269/161432041-4ecd2c31-9065-41ee-8f85-cb1b409853cb.mp4
 

## Grid Settings
 - SimpleGrid consists of two grid types: Quadral and Hexagonal
 - Each type has its own settings

## Common Settings
 - Initial Pos: World Pos where the grid is gonna start to shape into
 - Grid Coord: The coordinate system of the grid
 - Width: The width of the grid
 - Height: The height of the grid
 - Width Offset: The width offset of the grid
 - Height Offset: The height offset of the grid

## Getting Grid Data
 - SimpleGrid does not only generate real/virtual grids, It also stores each individual grid object and calls them "Cell"
 - You can access any Cell via GridManager by calling "cells[index].(cell-data)"
 - Basically, Cell is nothing but a serializable C# class and looks like this
  ![cell](https://user-images.githubusercontent.com/59537269/161443197-61e4fb60-0a13-4008-ade3-3c54455c2e5e.png)
 - You can also extend Cell's data and use it as you wish

 
## Quadral Settings
1 - Quadral Settings
 - Grid Prefab: The object of each grid
 - Parent Name: Parent name of the grid
 - Child Name: The name of each grid object
 
![Screen Shot 4-3-2022 at 5 18 PM](https://user-images.githubusercontent.com/59537269/161432390-0a6b9ae5-adb9-4d03-b9ac-da0255f88113.png)

2 - Virtual Quadral Settings

![Screen Shot 4-3-2022 at 5 24 PM](https://user-images.githubusercontent.com/59537269/161432677-c7b0b337-129b-443c-82da-936cd0139a12.png)



## Hexagonal Settings
1 - Hexagonal Settings
 - Grid Prefab: The object of each grid
 - Parent Name: Parent name of the grid
 - Child Name: The name of each grid object
 - Hexagonal Offset: The hexagonal offset between grid objects
 
 ![Screen Shot 4-3-2022 at 5 25 PM](https://user-images.githubusercontent.com/59537269/161432737-60a4bddc-4ec4-4fdf-89d7-d4eb1af8d3c3.png)

2 - Virtual Hexagonal Settings
 - Hexagonal Offset: The hexagonal offset between grid objects

![Screen Shot 4-3-2022 at 5 27 PM](https://user-images.githubusercontent.com/59537269/161432832-9e40f30b-4cbd-4630-a787-60fce123936b.png)


## Example 1

## Generate Grid Inside Simple Grid Object
https://user-images.githubusercontent.com/59537269/161442913-5f24edf5-c316-4bfe-9671-4c1325b2f778.mp4



## Example 2

## Generate Grid From Another MonoBehaviour
 - SimpleGrid allows you to initialize grid from another MonoBehaviour
 - For example, If you want to use different grids for your levels you can make a list of grid settings and attach different grid data for each level like below

```csharp 
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GridManager gridManager;
    public List<BaseGridSettings> gridSettings;
    public int levelIndex;

    private void Awake()
    {
        var currentGridSettings = gridSettings[levelIndex];
        gridManager.InitGrid(currentGridSettings);
    }
}
```

![generate-grid-another-monobehaviour](https://user-images.githubusercontent.com/59537269/161442425-8bea0a01-4bc1-4006-8fc9-978618a8122c.png)




