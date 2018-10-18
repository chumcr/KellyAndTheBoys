using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Organization
/// </summary>
public class Organization
{
    //Attributes
    private int orgID, addressID, teacherID, paymentID;
    private string orgName;

    private DateTime lastUpdated;
    private string lastUpdatedBy;
    //Organization constructor
    public Organization(int orgID, int addressID, int teacherID, int paymentID, string orgName, DateTime lastUpdated, string lastUpdatedBy)
    {
        setOrgID(orgID);
        setAddressID(addressID);
        setTeacherID(teacherID);
        setPaymentID(paymentID);
        setOrgName(orgName);
        setLastUpdated(lastUpdated);
        setLastUpdatedBy(lastUpdatedBy);
    }

    //Getters
    public int getOrgID()
    {
        return this.orgID;
    }
    public int getAddressID()
    {
        return this.addressID;
    }
    public int getTeacherID()
    {
        return this.teacherID;
    }
    public int getPaymentID()
    {
        return this.paymentID;
    }
    public string getOrgName()
    {
        return this.orgName;
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
    public void setOrgID(int x)
    {
        this.orgID = x;
    }
    public void setAddressID(int x)
    {
        this.addressID = x;
    }
    public void setTeacherID(int x)
    {
        this.teacherID = x;
    }
    public void setPaymentID(int x)
    {
        this.paymentID = x;
    }
    public void setOrgName(string x)
    {
        this.orgName = x;
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