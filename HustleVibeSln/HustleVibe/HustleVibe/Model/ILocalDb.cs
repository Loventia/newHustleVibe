using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SQLite;

namespace HustleVibe.Model
{
    public  interface ILocalDb
    {
        SQLiteConnection GetConnection();
    }
}
