using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public string date;
    public string prompt;
    public string response;

    public Entry ()
    {
        DateTime dateTime = DateTime.Now;
        date = dateTime.ToShortDateString();
    }
}