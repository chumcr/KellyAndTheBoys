using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Payment
/// </summary>
public class Address
{
    //Attributes
    private int addressID;
    private string streetName, city, county, zipCode;

    private DateTime lastUpdated;
    private string lastUpdatedBy;
    //Address constructor
    public Address(int addressID, string streetName, string city, string county, string zipCode, DateTime lastUpdated, string lastUpdatedBy)
    {
        setAddressID(addressID);
        setStreetName(streetName);
        setCity(city);
        setCounty(county);
        setZipCode(zipCode);
        setLastUpdated(lastUpdated);
        setLastUpdatedBy(lastUpdatedBy);
    }

    //Getters
    public int getAddressID()
    {
        return this.addressID;
    }
    public string getStreetName()
    {
        return this.streetName;
    }
    public string getCity()
    {
        return this.city;
    }
    public string getCounty()
    {
        return this.county;
    }
    public string getZipCode()
    {
        return this.zipCode;
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
    public void setAddressID(int x)
    {
        this.addressID = x;
    }
    public void setStreetName(string x)
    {
        this.streetName = x;
    }
    public void setCity(string x)
    {
        this.city = x;
    }
    public void setCounty(string x)
    {
        this.county = x;
    }
    public void setZipCode(string x)
    {
        this.zipCode = x;
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