using Microsoft.Data.Sqlite;
using RegUI.models;
using System.Data;
using System.Text;

namespace RegUI.localStorage;

public class RegistryRepository : LocalStorage
{
    public void CreateRegistry(Registry registry)
    {
        context.Open();
        using (var cmd = context.CreateCommand())
        {
            cmd.CommandText = @"INSERT INTO Registries(Name,Url,Secured,Username,Password) VALUES (@Name, @Url, @Secured, @Username, @Password)";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqliteParameter("@Name", registry.Name));
            cmd.Parameters.Add(new SqliteParameter("@Url", registry.Url));
            cmd.Parameters.Add(new SqliteParameter("@Secured", registry.Secured));
            cmd.Parameters.Add(new SqliteParameter("@Username", registry.Secured ? registry.Username : String.Empty));
            cmd.Parameters.Add(new SqliteParameter("@Password", registry.Secured ? registry.Password : String.Empty));

            cmd.ExecuteNonQuery();
        }
        context.Close();
    }

    public List<Registry> getRegistries()
    {
        context.Open();

        List<Registry> registries = [];
        using (var cmd = context.CreateCommand())
        {
            cmd.CommandText = @"SELECT * FROM Registries";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    registries.Add(new Registry
                    {
                        Id = reader.GetInt16("Id"),
                        Name = reader.GetString("Name"),
                        Url = reader.GetString("Url"),
                        Secured = reader.GetBoolean("Secured"),
                        Username = reader.GetString("Username"),
                        Password = reader.GetString("Password")
                    });
                }
            }
        }
        context.Close();

        return registries;
    }

    public void updateRegistry(Registry r)
    {
        context.Open();

        using (var cmd = context.CreateCommand())
        {
            cmd.CommandText = @"
                UPDATE Registries SET Name = @name, Url = @url, Secured = @secured, Username = @username, @Password = password
                WHERE Id = @id
            ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqliteParameter("@id", r.Id));
            cmd.Parameters.Add(new SqliteParameter("@name", r.Name));
            cmd.Parameters.Add(new SqliteParameter("@secured", r.Secured));
            cmd.Parameters.Add(new SqliteParameter("@username", r.Username));
            cmd.Parameters.Add(new SqliteParameter("@password", r.Password));

            cmd.ExecuteNonQuery();
        }

        context.Close();
    }

    public void deleteRegistry(Registry r)
    {
        context.Open();

        using (var cmd = context.CreateCommand())
        {
            cmd.CommandText = @"DELETE FROM Registries WHERE Id = @Id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqliteParameter("@Id", r.Id));

            cmd.ExecuteNonQuery();
        }
    }
}

