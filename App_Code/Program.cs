using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Program
/// </summary>
public class Program
{
    //Attributes
    private int ID;
    private string name;
    private int capacity;
    private char type; //This value will either be 'L' to indicate LIVE or 'O' to indicate ONLINE

    private DateTime lastUpdated;
    private string lastUpdatedBy;

    //Program constructor
    public Program(int programID, string programName, int capacity, char programType, DateTime lastUpdated, string lastUpdatedBy)
    {
        setProgramID(programID);
        setProgramName(programName);
        setCapacity(capacity);
        setProgramType(programType);
        setLastUpdated(lastUpdated);
        setLastUpdatedBy(lastUpdatedBy);
    }

    //Getters
    public int getProgramID()
    {
        return this.ID;
    }
    public string getProgramName()
    {
        return this.name;
    }
    public int getCapacity()
    {
        return this.capacity;
    }
    public char getProgramType()
    {
        return this.type;
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
    public void setProgramID(int x)
    {
        this.ID = x;
    }
    public void setProgramName(string x)
    {
        this.name = x;
    }
    public void setProgramType(char x)
    {
        this.type = x;
    }
    public void setCapacity(int x)
    {
        this.capacity = x;
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