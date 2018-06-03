# Flyweight Pattern
The Flyweight pattern is used when you have a lot of objects that are actually the same and you run into performance problems when creating them all one by one.

## Pick this Kata if code like this bothers you
```
var list = new List<MyObjecy>
for(int i = 0; i < 100000; i++) {
    var newObject = new MyObject();
    list.Add(newObject);
}
```

## The Kata
You will implement a system that generates characters.

### Sprint 1
- implement a class that generates 100 000 000 Objects that represent a Character of the alphabet repeatedly, like "A, B, ... Z, A..."

### Sprint 2
- make the class create the same ammount of objects with a random font size of 10-20

### Sprint 3
- put a while loop that escapes after 100ms in the constructor of the character objects to simulate heavy initialisation costs

## The Problem

## The Explanation

## The Solution
