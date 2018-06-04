# Builder Pattern
The Builder pattern is used when you have to initialize a complexe object and want to seperate the how to create it from the what to create.

## Pick this Kata if code like this bothers you
```
var car = new Car(12, true, "VW", 2017, 10, 8, Type.PKW, DoorType.FiveDoors, 8, "Germany");
```

## The Kata
You will implement a car assembly line. The car class is allready defined in the project. You are not allowed to remove or change properties, as the class is from a third party company ;)

### Sprint 1
- Initialize a car with some values and call it VwPolo
- Initialize aother car with appropriate values for a Ferrari
- Initialize aother car with appropriate values for a Mercedes Truck

### Sprint 2
- Write Tests for each car that check if the values are set correct

### Sprint 3
- Sort the properties and the constructor to group similar properties 

### Sprint 4
- Add the following properties: string SeatingMaterial and bool AutomaticDrive

### Sprint 5
initialize a VwPolo variant that has 2 properties different than the original one

### Sprint 6
- Remove the property "HasAirbag"

## The Problem

## The Explanation

## The Solution
