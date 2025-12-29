# Architect Arithmetic (C#)

A C# console application that calculates the estimated construction cost of famous monuments using basic geometry.

## Description

The program calculates areas of rectangles, circles, and triangles to estimate the total surface area of each monument.  
The total area is then multiplied by a fixed cost per square meter to determine the construction cost in pesos.

## Cost Assumption

- Cost per square meter: **180 pesos**

## Monuments Included

- Teotihuacan  
- Taj Mahal  
- Great Mosque of Mecca  

## How It Works

1. The program calculates geometric areas.
2. Each monument’s total area is computed using those shapes.
3. The total area is multiplied by the cost per square meter.
4. The user selects a monument from a menu to see its cost.

## How to Run

Run the program using the .NET CLI:

```bash
dotnet run
