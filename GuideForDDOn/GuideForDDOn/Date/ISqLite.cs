using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideForDDOn.Date
{
    public interface ISqLite
    {
        SQLiteConnection GetConnection();
    }
}
