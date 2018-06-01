# State Pattern
The mediator pattern solves the problem when you have a lot of objects that have to exchange messages and therefore are tightly coupled together. Through the mediator pattern the objects do not need to know each other and therefore are more easily to exchange.

## Pick this Kata if code like this bothers you
```
class Lamp {
    public void TurnOff() {
        this.TurnedOn = false;
        this.parent.TugnOff(this);
        for(int i = 0; i < this.children.length; i++) {
            if (i % 2 == 0) {
                this.children[i].TurnOff();
            }
        }
    }
}

...

public void TurnOff(Lamp lamp) {
    if (Lamp.index == 3) {
        this.TurnedOn = false;
    }
}
```

## The Kata
You will implement a traffic light system for a crossroad.

### Sprint 1
- the crossroads consists of four traffic lights
- each traffic light can be red or green

### Sprint 2
- if a traffic light switches to green, the traffic light on the opposite site has to switch to green, too. Also the other traffic light have to switch to red.

### Sprint 3
- each traffic light can also be faulty or out of order and then flashes yellow
- if one traffic light is faulty, all other traffic lights have to be set into out of order state

### Sprint 4
- on one road there is a pedestian walk
- if the pedestrian presses the light, the next phase on this road will be red, so the pedestrians can pass

### Sprint 5
- on one road (you can pick one) are train tracks with a traffic light for trains
- if the traffic light for trains is set to green, the traffic light on the same road and on the opposite site have to switch to red

### Sprint 6
- on one road are train tracks with a traffic light for trains
- if the traffic light for trains is set to green, the traffic light on the same road and on the opposite site have to switch to red

### Sprint 7
- if the traffic light for trains is faulty, the traffic lights on the same road have to switch to faulty, too, the other roads can switch to red and green like bevore

### Sprint 8
- the train can now pass via a bridge, so the traffic light can be ignored again

## The Problem

## The Explanation

## The Solution