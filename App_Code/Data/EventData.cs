using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EventData
/// </summary>
public class EventData
{
    public EventData()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static DataTable Select()
    {
        return DataAccess.GetData("SELECT * FROM EventsView");
    }



}