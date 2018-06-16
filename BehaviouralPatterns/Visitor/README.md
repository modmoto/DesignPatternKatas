# Visitor Pattern
The visitor pattern lets you seperate business rules from rules that add additional value like presenting the business object or implementing different behaviour like pricing or similar things.

## Pick this Kata if code like this bothers you
```
public interface Element {
    string Name { get; set; }
    string Id { get; set; }
    
    string printAsHtml();
    byte[] printAsPdf();
    
    double calculatePrice();
    double calculateTenPercentOffPrice();
    double calculateThreeForTwoPrice();
}
```

## The Kata
You will implement a checkout system with different pricing models that change from the selected product.

### Sprint 1
In your webshop are three kinds of things you can buy:
 - Books (has Authorname, PublishingYear and Title, PrizePerItem)
 - Movies (has Title, AmmountOfOscars, PublishingYear, PrizePerItem)
 - Games (has Title, PublisherName, AmmountOfMinimumPlayers, AmmountOfMaximumPlayers, PrizePerItem)

### Sprint 2
The three classes will have a html representation to show it in the browser (just return some html string that kind of fits a html structure)

### Sprint 3
The three classes will have a pdf representation to print invoices. Just return a combination of the strings as byte array

### Sprint 4
Implement a way to realize a 20% prize off for all classes

### Sprint 5
Implement a way to realize a buy two get one for free for all classes, except the movie class.

## The Problem

## The Explanation

## The Solution