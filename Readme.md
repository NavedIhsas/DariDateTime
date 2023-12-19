# DariDateTime

DariDateConverter is a C# utility library that enables the conversion of Dari (Shamsi) dates to Gregorian (Miladi) dates.

## Getting Started

To use DariDateConverter, follow these simple steps:

### Prerequisites

There are no additional prerequisites for using DariDateTime beyond standard package installation.

## Usage
```bash
dotnet add package DariDateTime
```

Learn how to use DariDateConverter with the following examples:

### Method 1: Convert with Default Format

```c#
DateTime miladiDate = DateTime.Now;
string DariDate = miladiDate.ToDariDateTime();
```
This will convert the current Gregorian date to Dari with the default format ("yyyy/MM/dd").

### Method 2: Convert with Custom Format

```C#
DateTime miladiDate = DateTime.Now;
string customFormat = "yyyy/MMMM/dd";
string DariDate = miladiDate.ToDariDateTime(customFormat);
```

This will convert the current Gregorian date to Dari with the specified custom format.

## Feedback
We appreciate your feedback! Connect with us:

GitHub Issues
Twitter: @YourTwitterHandle