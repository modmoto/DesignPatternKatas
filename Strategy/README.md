# Strategy Pattern
The strategy pattern lets you change the behaviour of an object during runtime.

## Pick this Kata if code like this bothers you
```
if (printOnPrinter) 
    var pages = message.Length / 1000;
    Printer.Print(message, pages);
else if (printOnPdf) 
    var pages = message.Length / 2000;
    PdfPrinter.print(message);
else if (printToGoogleShare) 
    var pages = message.Length / 3000;
    GooglePrinter.print(message);
```

## The Kata
You will implement a printsystem for contracts. Printing will be simplified by a `Console.Writeline($"Printed to paper: {contract}");`

### Sprint 1
- a contract is just a simple string
- a document printer can print a contract on paper 
- a pdf printer can print a contract on pdf

### Sprint 2
- a document printer can print on two sides of a paper. To do that, he first has to print all the uneven pages and then the even ones

### Sprint 3
- a pdf printer has the ability to print several pages on one paper. It can print 1x1 (default), 2x2, 3X1 and 4x4

### Sprint 4
- There will be a google drive printer that stores the prints in the cloud. To store it correctly, the google printer has to print a newline after every 40 characters
- the pdf printer also has to print the newline, but only after 80 character

### Sprint 5
- The google printer will also support the feature of backward printing where the pages will start with the last, going to the first

### Sprint 6
- all the printers can print in a color that is given on the start

### Sprint 7
- the colors for the printers are given with hex code. The google printer understands hexcode, the document writer only knows cmyk and the pdf writer only rgb

### Sprint 8
- a customer wants a custom printer where he can input the kind of target (pdf, document or cloud), the color of the prints and the ammount of pages he want to have printed on one page. For examlpe a print("document", "4x4", #deb854) will order the software to print on a document printer a 4x4 ocument on the document printer with a yellowish color. This is called the custom printer.

## The Problem

## The Explanation

## The Solution