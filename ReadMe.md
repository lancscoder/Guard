# A Simple .NET Guard Class

[![Build status](https://ci.appveyor.com/api/projects/status/bnfvp4kdnmvutiiy)](https://ci.appveyor.com/project/lancscoder/guard)

Allows chaining of conditions.

## Nuget

Coming soon

## Example 

```
string s = null;

// Throws NullException
Guard.For(s)
     .IsNotNull();

int i = 10;

// Passes
Guard.For(i)
     .IsGreaterThan(5)
	 .IsLessThanOrEqualTo(10);

```

## General conditions

Condition | Description
--------- | -----------
IsNotNull | Checks against nulls

## IComparable conditions

Condition | Description
--------- | -----------
IsGreaterThan | 
IsGreaterThanOrEqualTo | 
IsLessThan | 
IsLessThanOrEqualTo | 
IsEqualTo | 
IsNotEqualTo | 

##String Conditions

Condition | Description
--------- | -----------
IsNotNullOrEmptyWhiteSpace | Checks against nulls, empty strings and whitespaces
