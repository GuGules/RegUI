using Microsoft.Data.Sqlite;

namespace RegUI.localStorage
{
    public class LocalStorage
    {
        private SqliteConnection context;

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
            }
        }

        public void CreateRegistry(string name, string url, bool secured, string? username, string? password)
        {
            MessageBox.Show("TODO");
        }
    }
}
