using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Program
/// </summary>
public class Invoice
{
    //Attributes
    private int invoiceID, payID, total;
    private DateTime dateCreated;
    private Boolean status;

    private DateTime lastUpdated;
    private string lastUpdatedBy;

    //Invoice constructor
    public Invoice(int invoiceID, int payID, int total, DateTime dateCreated, Boolean status, DateTime lastUpdated, string lastUpdatedBy)
    {
        setInvoiceID(invoiceID);
        setPayID(payID);
        setTotal(total);
        setDateCreated(dateCreated);
        setInvoiceStatus(status);
        setLastUpdated(lastUpdated);
        setLastUpdatedBy(lastUpdatedBy);
    }

    //Getters
    public int getInvoiceID()
    {
        return this.invoiceID;
    }
    public int getPayID()
    {
        return this.payID;
    }
    public int getTotal()
    {
        return this.total;
    }
    public DateTime getDateCreated()
    {
        return this.dateCreated;
    }
    public Boolean getInvoiceStatus()
    {
        return this.status;
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
    public void setInvoiceID(int x)
    {
        this.invoiceID = x;
    }
    public void setPayID(int x)
    {
        this.payID = x;
    }
    public void setTotal(int x)
    {
        this.total = x;
    }
    public void setDateCreated(DateTime x)
    {
        this.dateCreated = x;
    }
    public void setInvoiceStatus(Boolean x)
    {
        this.status = x;
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