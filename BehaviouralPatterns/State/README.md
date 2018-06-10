# State Pattern
The state pattern aims to put the state of an object inside the object so you need less if else when using the object.

## Pick this Kata if code like this bothers you
```
if (!(user.IsDisabled | user.IsBanned)) ;
    user.Name = newName;

...

if (user.IsBanned) return new List<string>();
else return user.Names;
```

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

## The Problem
if/else is logic from outside the domain objects
Single Responsibility
Open Close

## The Pattern Explanation

### Reasons not to use it
many new state changes, meaning new functions, meaning touching all states

## The Solution