# ToDari Date Converter

This C# utility package provides methods for seamless conversion between Gregorian (Miladi) and ToDari (Shamsi) calendars.

## Methods

### 1. ToDari
   - Converts a Gregorian date to ToDari (Shamsi).
   - Supports both default and custom date formats.

### 2. ToDari with Custom Format
   - Extends the conversion functionality by allowing users to specify a custom date format.

### 3. ToDateTime
   - Converts a ToDari (Shamsi) date to Gregorian (Miladi).

These methods empower developers to handle date conversions effortlessly within their C# applications, promoting compatibility with both calendar systems.


package manager

```
Install-Package DariDateTime
```
<br>
### example 1: Convert with defualt format
``` csharp
var miladiDate = DateTime.Now;
var DariDate = miladiDate.ToDari();
//or
var DariDate = miladiDate.ToDari(DateFormat.YearMonthDay);
```
This will convert the current Gregorian date to Dari with the default format ("yyyy/MM/dd").
<br>
<br>
Sample Output:
```csharp
 1402/09/27
```

### example 2: Convert with month name
```csharp
  var miladiDate = System.DateTime.Now;
  var DariDate = miladiDate.ToDari(DateFormat.YearMonthNameDay);
```
This will convert the current Gregorian date to Dari with the Month Name format ("yyyy MMMM dd").
<br>
<br>
Sample Output:
```csharp
 "27 قوس 1402"
```

### example 3: Convert with Custom Format
```csharp
var miladiDate = DateTime.Now;
var dariDate = miladiDate.ToDariDateTime(customFormat);
```

## Convert Date from Shamsi (Dari) to Gregorian

```csharp
va dariDate = "1402/09/27";
var miladiDate = dariDate.ToDateTime();
```
This method takes a string containing a Shamsi date as input and converts it to a Gregorian date. The output of this method is a DateTime object capable of representing the resulting Gregorian date. If the Shamsi date is not valid, the method returns null.
<br>
<br>
Sample Output:
```csahrp
2023/12/19
```

## Feedback
We appreciate your feedback! Connect with us:

[GitHub](https://github.com/NavedIhsas/)
<br>
[Facebook](https://www.facebook.com/qudratihsas/)

