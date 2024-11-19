using Microsoft.Data.Sqlite;

public class SQLiteConnectionManager
{
    private string connectionString;

    public SQLiteConnectionManager(string databasePath)
    {
        connectionString = $"Data Source={databasePath};Version=3;";
    }

    public SqliteConnection GetConnection()
    {
        return new SqliteConnection(connectionString);
    }

    public void OpenConnection(SqliteConnection connection)
    {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void CloseConnection(SqliteConnection connection)
    {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }

    public void ExecuteNonQuery(string query)
    {
        using (var connection = GetConnection())
        {
            OpenConnection(connection);

            using (var command = new SqliteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }

            CloseConnection(connection);
        }
    }

    public SqliteDataReader ExecuteQuery(string query)
    {
        var connection = GetConnection();
        OpenConnection(connection);

        var command = new SqliteCommand(query, connection);
        return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
    }
}