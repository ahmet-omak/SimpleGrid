# Simple Grid

## Table Of Contents 
 
<details>
<summary>Details</summary>

  - [Introduction](#introduction)
  - [Quick Look](#what-a-grid-looks-like)
  - [Grid Types](#grid-types)
  - [Common Settings](#common-settings)
  - [Quadral Settings](#quadral-settings)
  - [Hexagonal Settings](#hexagonal-settings)
  - [Creating Grid](#how-to-create-a-grid)
  - [Getting Data](#getting-data)
  - [Extending SimpleGrid](#extending-simplegrid)
    
</details>

## Introduction
Simple, Scriptable Object based grid creator for puzzle games

    
## What A Grid Looks Like
I am gonna explain how to create a grid in later parts. But, if you want to have an earlier look, go ahead "Window/SimpleGrid/Create Grid" to see what a grid looks like.
 

## Grid Types
 - SimpleGrid consists of two grid types: Quadral and Hexagonal
 - Each type has its own settings

## Common Settings
 - Initial Pos: World Pos where the grid is gonna start to shape into
 - Grid Prefab: The object that each grid will represent
 - Width: The width of the grid
 - Height: The height of the grid
 - Width Offset: The width offset of the grid
 - Height Offset: The height offset of the grid

 
## Quadral Settings
1 - Quadral Settings 

![quadral grid](https://github.com/cpp-bender/SimpleGrid/assets/59537269/3d12f62d-2aa2-4881-9386-fe8e82c75dfb)



## Hexagonal Settings
1 - Hexagonal Settings

 - Hexagonal Offset: The hexagonal offset between grid objects
 
![hexagonal grid](https://github.com/cpp-bender/SimpleGrid/assets/59537269/37ee88ed-6609-4eab-a259-6f2a28055e14)


## How to create a grid
https://user-images.githubusercontent.com/59537269/163681571-8ca3e6a5-587a-4e03-8e1e-ca9f6e6a0ba3.mp4


## Getting Data

- SimpleGrid creates individual objects in the given order and stores them inside a list of cells. Cell is basically a Serializable C# class.
- You can access SimpleGrid's data like below.

```csharp 
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public BaseGridSettings gridSettings;

    private void Start()
    {
        gridSettings.Create();
        Debug.Log("First Cell is at: " + gridSettings.Cells[0].worldPos);
    }
}
```
