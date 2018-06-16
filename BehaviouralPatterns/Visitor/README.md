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

## The Problem

## The Explanation

## The Solution