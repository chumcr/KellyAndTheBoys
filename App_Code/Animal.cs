using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Animal
/// </summary>
public class Animal
{
    //Attributes
    private int ID;
    private string name;
    private char type; //This value will either be 'B' for bird, 'M' for Mammal, or 'R' for Reptile
    private int age;
    private DateTime dateAdded;

    private DateTime lastUpdated;
    private string lastUpdatedBy;

    //Animal constructor
    public Animal(int ID, string name, char type, int age, DateTime dateAdded, DateTime lastUpdated, string lastUpdatedBy)
    {
        setAnimalAge(age);
        setAnimalID(ID);
        setAnimalType(type);
        setAnimalName(name);
        setAnimalDateAdded(dateAdded);
        setLastUpdated(lastUpdated);
        setLastUpdatedBy(lastUpdatedBy);
    }

    //Getters
    public int getAnimalID()
    {
        return this.ID;
    }
    public string getAnimalName()
    {
        return this.name;
    }
    public char getAnimalType()
    {
        return this.type;
    }
    public int getAnimalAge()
    {
        return this.age;
    }
    public DateTime getDateAdded()
    {
        return this.dateAdded;
    }
    public DateTime getLastUpdated()
    {
        return this.lastUpdated;
    }
    public string getLastUpdatedBy()
    {
        return this.lastUpdatedBy;
    }

    //Setters
    public void setAnimalID(int x)
    {
        this.ID = x;
    }
    public void setAnimalType(char x)
    {
        this.type = x;
    }
    public void setAnimalAge(int x)
    {
        this.age = x;
    }
    public void setAnimalName(string x)
    {
        this.name = x;
    }
    public void setAnimalDateAdded(DateTime x)
    {
        this.dateAdded = x;
    }
    public void setLastUpdated(DateTime x)
    {
        this.lastUpdated = x;
    }
    public void setLastUpdatedBy(string x)
    {
        this.lastUpdatedBy = x;
    }
}