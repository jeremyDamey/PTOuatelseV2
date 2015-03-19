using MySql.Data;
using MySql.Data.MySqlClient;

class DBConect
{
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    public void Initialize()
    {
        server = "info-viviane.iut.bx1";
        database = "pt_ouatelse1";
        uid = "pt_ouatelse1";
        password = "DYwBqVhnNL5SPddK";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
        connection.Open();
    }

    public string requete(string req, string variable)
    {

        //string strRequete = "SELECT nom FROM clients" ;
        string varNom="";
        MySqlCommand myCommand = new MySqlCommand(req,connection);
        MySqlDataReader mySqDataReader = myCommand.ExecuteReader();
        while (mySqDataReader.Read()){
        if(mySqDataReader[variable]!= System.DBNull.Value){
            varNom += mySqDataReader[variable].ToString() + "\n";
        }else{
            varNom = " ";
        }
    }
return varNom;
}
}
