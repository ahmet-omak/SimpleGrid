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
  - [Header 3](#header-3)
  - [Examples](#examples)
    
</details>

## Introduction
A simple SO (Scriptable Object) based grid creator for puzzle games

    
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

## Header 3
This is header 3
```csharp 
    public class ExampleClass    
    {
    
    }
```
## Examples
Some examples










