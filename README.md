# DariDateTime

DariDateConverter is a C# utility library that enables the conversion of Dari (Shamsi) dates to Gregorian (Miladi) dates.


## Installation


package manager
``` 
Install-Package DariDateTime
	@@ -22,49 +21,28 @@ var DariDate = miladiDate.ToDari();
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
```c#
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
```C#
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

