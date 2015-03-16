using MySql.Data;
using MySql.Data.MySqlClient;

class DBConect
{
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    private void Initialize()
    {
        server = "localhost";
        database = "connectcsharptomysql";
        uid = "username";
        password = "password";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }
}