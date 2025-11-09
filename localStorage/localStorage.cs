using Microsoft.Data.Sqlite;
using RegUI.models;
using System.Data;

namespace RegUI.localStorage
{
    public abstract class LocalStorage
    {
        protected SqliteConnection context;

        public LocalStorage()
        {
            context = new SqliteConnection("Data Source=./regui_localStorage.db");
            if (!File.Exists("./regui_localStorage.db"))
            {
                context.Open();
                using (var cmd = context.CreateCommand())
                {
                    cmd.CommandText = @"
                        CREATE TABLE Registries (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name varchar(255),
                            Url text,
                            Secured bool,
                            Username varchar(255),
                            Password varchar(255));
                    ";
                    cmd.ExecuteNonQuery();
                }
                context.Close();
            }
        }
    }
}
