# Decorator Pattern
The decorator pattern lets you add functionality to a class without having to change the class itself. This is useful if you want to extend framework classes or add functionality that have nothing to do with the class you want to extend

## Pick this Kata if code like this bothers you
```
public string UpdateUser(User user) {
    Logger.Info("enter method UpdateUser");
    using (var connection = new DbConnection() {
        // do complicated DB Stuff
    }
    Logger.Info("leave method UpdateUser");
}
```
```
var response = await httpClient.PostAsync("uri", new FormUrlEncodedContent(parameters));
if (response.Code == 404) 
    throw NotFoundException;
if (response.Code == 403) 
    throw UnauthorizedException;
return await response.Content.ReadAsStringAsync();
```

## The Kata
You will implement a loggingsystem for a random program

### Sprint 1
- Pick a Kata you allready solved and implement a logging of that logs the entering o every function you call

### Sprint 2
- Extend the logging with a parameter that accepts a severity like info, error and warning. Everywhere.

## The Problem

## The Explanation

## The Solution
