# DariDateTime

DariDateConverter is a C# utility library that enables the conversion of Dari (Shamsi) dates to Gregorian (Miladi) dates.

## Installation


package manager
``` 
Install-Package DariDateTime
```

## Usage

Learn how to use DariDateConverter with the following examples:

### example 1: Convert with Default Format
```c#
var miladiDate = DateTime.Now;
var DariDate = miladiDate.ToDari();
//or
var DariDate = miladiDate.ToDari(DateFormat.YearMonthDay);
```
This will convert the current Gregorian date to Dari with the default format ("yyyy/MM/dd").
<br>
Sample Output:
```csharp
 1402/09/27
```

### example 2: Convert with month name
```c#
  var miladiDate = System.DateTime.Now;
  var DariDate = miladiDate.ToDari(DateFormat.YearMonthNameDay);
```
This will convert the current Gregorian date to Dari with the Month Name format ("yyyy MMMM dd").
<br>
Sample Output:
```csharp
 "27 قوس 1402"
```

### example 3: Convert with Custom Format
```C#
DateTime miladiDate = DateTime.Now;
var DariDate = miladiDate.ToDariDateTime(customFormat);
```

## Converet Dari Date to DateTime

```csharp
va rdariDate = "1402/09/27";
var miladiDate = dariDate.ToDateTime();
```
This method converts the given Dari (Shamsi) date to Gregorian (Miladi) dateم
<br>
Sample Output:

‍‍‍‍‍```csharp
2023/12/19
```

## Feedback
We appreciate your feedback! Connect with us:

[GitHub](https://github.com/NavedIhsas/)
<br>
[Facebook](https://www.facebook.com/qudratihsas/)
