# State Pattern
The state pattern aims to put the state of an object inside the object so you need less if else when using the object.

## Pick this Kata if code like this bothers you
```
if (!(user.State == UserStates.Banned | user.State == UserStates.Disabled)) ;
    user.Name = newName;

...

if (user.IsBanned) return new List<string>();
else return user.Posts;
```

### Red Flags are
 - a class has a enum state variable
 - a class has boolean flags that are called in ifs from outside

## The Kata
You will implement a blogsystem with a basic user role system.

### Sprint 1
- a post ist just a string
- a user has a name and a list of posts that he published
- a user can publish posts

### Sprint 2
- a user can be banned
- if a user is banned, his published posts are hidden and his name is displayed as "Banned User"

### Sprint 3
- a user can be a read only user or a redakteur
- a read only user can not publish posts
- a redakteur can publish posts
- redakteurs can be made a readonly user
- a readonly user can be made a redakteur

### Sprint 4
- a redakteur can pin a post. This pinned post is always the first post in the list of posts he published
- if a user pins a post, an error occurs

### Sprint 5
- there will be a administrator role
- a administrator can not be banned, if it is tried, there will be an error

### Sprint 6
- there is a temporary Redakteur role
- a temporary redakteur role means a user can publish 3 posts like a redakteur

### Sprint 7
- the read only user role is no longer needed, all users are treated like redakteurs

### Sprint 8
- paint a picture that represents how the state of the application is changing when a operation is done.

## The Problem
The big problem here should be obviously, that the application is very dependant on if or switch cases that decide wheter a action is allowed or not. Also you have to store this decisions as some ifs will depend on the previous action. The reason why this is a problem is, that an if outside of an object usually means, that you are implementing domain logic outside of the domain object. That will lead to a lot of if/else or switch cases that have to be placed all around the domain object, to check if a action is available or not. For example if you have a `User` that has an `Age` Property and the rule of the domain is, that a user can not log in if he is not 18 yet, then this rule should belong to the `User` and it should not be the responsibility of the caller to determine if the user is 18. In the state pattern you could implement a `UnderagedUser` and a `FullAgedUser` to represent this state. This way you put the if into the classes or domain object itself and no clien ever has to deal with the age domain rule. Chances are that somebody will forget it or implement it wrong, eventually.

You also violate the Open Closed Principle by putting a lot of if/else/switch logic in your application. If there is a new state, you will eventually have to check all the if/else branches to see, if the conditions still make sense. Also if a condition changes you have to toich code that also does something else (Single Responsibility violated) and you might break something.

## The Pattern Explanation

![alt text](https://upload.wikimedia.org/wikipedia/de/7/70/StatePattern_Classdiagramm.png)

### Reasons not to use it
many new state changes, meaning new functions, meaning touching all states

## The Solution