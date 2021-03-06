﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Password
/// </summary>
public class Password
{
    //Attributes
    private int userID;
    private string userName, passwordHash;

    private DateTime lastUpdated;
    private string lastUpdatedBy;
    //Password Constructor
    public Password(int userID, string userName, string passwordHash, DateTime lastUpdated, string lastUpdatedBy)
    {
        setUserID(userID);
        setUserName(userName);
        setPasswordHash(passwordHash);
        setLastUpdated(lastUpdated);
        setLastUpdatedBy(lastUpdatedBy);
    }

    //Getters
    public int getUserID()
    {
        return this.userID;
    }
    public string getUserName()
    {
        return this.userName;
    }
    public string getPasswordHash()
    {
        return this.passwordHash;
    }
    public DateTime getLastUpdated()
    {
        return this.lastUpdated
    }
    public string getLastUpdatedBy()
    {
        return this.lastUpdatedBy;
    }

    //Setters
    public void setUserID(int x)
    {
        this.userID = x;
    }
    public void setUserName(string x)
    {
        this.userName = x;
    }
    public void setPasswordHash(string x)
    {
        this.passwordHash = x;
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