using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NewProgram
/// </summary>
public class NewProgram
{
    private int newProgramID, programID, numKids, numAdults, totalPeople, assignEmployeeID, assignAnimalID, invoiceID;
    private DateTime programDate;

    private DateTime lastUpdated;
    private string lastUpdatedBy;
    public NewProgram(string lastUpdatedBy)
    {
        
        setLastUpdated(lastUpdated);
        setLastUpdatedBy(lastUpdatedBy);
    }
    //Getters
    public int getNewProgramID()
    {
        return this.newProgramID;
    }
    public int getProgramID()
    {
        return this.programID;
    }
    public int getNumKids()
    {
        return this.numKids;
    }
    public int getNumAdults()
    {
        return this.numAdults;
    }
    public int getTotalPeople()
    {
        return this.totalPeople;
    }
    public int getAssignEmployeeID()
    {
        return this.assignEmployeeID;
    }
    public int getAssignAnimalID()
    {
        return this.assignAnimalID;
    }
    public int getInvoiceID()
    {
        return this.invoiceID;
    }
    public DateTime getProgramDate()
    {
        return this.programDate;
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
    public void setNewProgramID(int x)
    {
        this.newProgramID = x;
    }
    public void setProgramID(int x)
    {
        this.programID = x;
    }
    public void setNumKids(int x)
    {
        this.numKids = x;
    }
    public void setNumAdults(int x)
    {
        this.numAdults = x;
    }
    public void setTotalPeople(int x)
    {
        this.totalPeople = x;
    }
    public void setAssignEmployeeID(int x)
    {
        this.assignEmployeeID = x;
    }
    public void setAssignAnimalID(int x)
    {
        this.assignAnimalID = x;
    }
    public void setInvoiceID(int x)
    {
        this.invoiceID = x;
    }
    public void setProgramDate(DateTime x)
    {
        this.programDate = x;
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