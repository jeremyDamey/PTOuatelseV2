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
        mySqDataReader.Close();
return varNom;
}

    public bool validerConnexion(string req, string variable, string id)
    {
        bool user = false;
        MySqlCommand myCommand = new MySqlCommand(req, connection);
        MySqlDataReader mySqDataReader = myCommand.ExecuteReader();
        while (mySqDataReader.Read())
        {
            if (mySqDataReader[variable] != System.DBNull.Value)
            {
                if (id == mySqDataReader[variable].ToString())
                {
                    user = true;
                    mySqDataReader.Close();
                    return user;
                }
            }
        }
        mySqDataReader.Close();
        return user;
    }

    public void insertSalarié(string identifiant,string password,string nom, string prénom, string adresse1, string adresse2, string tel, string mail, string naissance)
    {
        string query = "INSERT INTO salaries (identifiant,mot_de_passe,nom,prenom,adresse1,adresse2,fixe,mail,naissance,roles_id,magasin_id,villes_id,pays_id,civilite_id) VALUES('" + identifiant + "','"+password+"','" + nom + "','" + prénom + "','" + adresse1 + "','" + adresse2 + "','" + tel + "','" + mail + "','" + naissance + "','1','1','1','1','1')";


        //create command and assign the query and connection from the constructor
        MySqlCommand cmd = new MySqlCommand(query, connection);

        //Execute command
        cmd.ExecuteNonQuery();
        

    }

}
