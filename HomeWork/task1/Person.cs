﻿namespace task1;

public class Person
{
    public string? FirstName;
    public string? LastName;
    public int Age;
    public string? Address;
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
    public int GetBirthYear()
    {
        return Age;
    }
    public string GetAddress()
    {
        return Address;
    }
}
