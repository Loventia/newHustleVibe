using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using HustleVibe.Model;
using SQLite;

namespace HustleVibe.Services
{
    public class HustleVibeLocalDb : ILocalDb
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "MyDatabase.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dbPath = Path.Combine(documentsPath, sqliteFileName);

            var connection = new SQLiteConnection(dbPath);

            return connection;
        }

    
    }
}
