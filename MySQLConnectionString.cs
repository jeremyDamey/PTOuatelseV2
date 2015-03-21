using MySql.Data;
using MySql.Data.MySqlClient;
using System;

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

        string varNom = "";
        MySqlCommand myCommand = new MySqlCommand(req, connection);
        MySqlDataReader mySqDataReader = myCommand.ExecuteReader();
        while (mySqDataReader.Read())
        {
            if (mySqDataReader[variable] != System.DBNull.Value)
            {
                varNom += mySqDataReader[variable].ToString() + "\n";
            }
            else
            {
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



    #region Requêtes salarié
    public void insererSalarié(string identifiant, string password, string nom, string prénom, string adresse1, string adresse2, string tel, string mail, string naissance,int civ)
    {
        string requete = "INSERT INTO salaries (identifiant,mot_de_passe,nom,prenom,adresse1,adresse2,fixe,mail,naissance,roles_id,magasin_id,villes_id,pays_id,civilite_id) VALUES('" + identifiant + "','" + password + "','" + nom + "','" + prénom + "','" + adresse1 + "','" + adresse2 + "','" + tel + "','" + mail + "','" + naissance + "','1','1','1','1','"+ civ +"')";



        MySqlCommand cmd = new MySqlCommand(requete, connection);


        cmd.ExecuteNonQuery();


    }
    public void modifierSalarié(int var, string nom, string prénom, string adresse, string fixe, string mail)
    {
        string requete = "UPDATE salaries SET nom = '" + nom + "', prenom = '" + prénom + "', adresse1 = '" + adresse + "', fixe = '" + fixe + "', mail ='" + mail + "' WHERE id = " + var + " ;";

        MySqlCommand cmd = new MySqlCommand(requete, connection);
        cmd.ExecuteNonQuery();
        //da
    }

    public void supprimerSalarié(int var)
    {
        string requete = "DELETE FROM salaries WHERE id = " + var + ";";

        MySqlCommand cmd = new MySqlCommand(requete, connection);

        //Execute command
        cmd.ExecuteNonQuery();

    }
    #endregion

    #region Reqêtes client
    public void insererClient(string nom, string prénom, string adresse1, string adresse2, string tel, string mail, string naissance)
    {
        string requete = "INSERT INTO clients (nom,prenom,adresse1,adresse2,fixe,mail,naissance,nationalite,villes_id,civilite_id) VALUES('" + nom + "','" + prénom + "','" + adresse1 + "','" + adresse2 + "','" + tel + "','" + mail + "','" + naissance + "','1','1','1')";
        Console.Write(nom);
        MySqlCommand cmd = new MySqlCommand(requete, connection);

        cmd.ExecuteNonQuery();

    }

    public void modifierClient(int var, string nom, string prénom, string adresse, string fixe, string mail)
    {
        string requete = "UPDATE clients SET nom = '" + nom + "', prenom = '" + prénom + "', adresse1 = '" + adresse + "', fixe = '" + fixe + "', mail ='" + mail + "' WHERE id = " + var + " ;";

        MySqlCommand cmd = new MySqlCommand(requete, connection);
        cmd.ExecuteNonQuery();
    }


    public void supprimerClient(int var)
    {
        string requete = "DELETE FROM clients WHERE id = " + var + ";";

        MySqlCommand cmd = new MySqlCommand(requete, connection);

        //Execute command
        cmd.ExecuteNonQuery();

    }
    #endregion

    public void insererProduit(string identifiant, string designation, string prix_achat, string prix_vente, string tva, string code_ean, string quantite)
    {
        //string requete = "INSERT INTO clients (id,nom,prenom,adresse1,adresse2,fixe,mail,naissance,civilite_id,villes_id,nationalite) VALUES('" + identifiant + "','" + "','" + nom + "','" + prénom + "','" + adresse1 + "','" + adresse2 + "','" + tel + "','" + mail + "','" + naissance + "','1','1','1')";

        string requete = "INSERT INTO `pt_ouatelse1`.`produits` (`nom`, `designation`, `prix_achat`, `prix_vente`, `tva`, `code_ean`) VALUES ('" + identifiant + "','" + designation + "','" + prix_achat + "','" + prix_vente + "','" + tva + "','" + code_ean + "')";
        string requete2 = "INSERT INTO `pt_ouatelse1`.`mouvement_stock` (`quantite`, `produits_id`,`magasin_id`) VALUES ('" + quantite + "', (select id from produits where nom = '" + identifiant + "') , '1') ";
        MySqlCommand cmd = new MySqlCommand(requete, connection);
        MySqlCommand cmd2 = new MySqlCommand(requete2, connection);
        cmd.ExecuteNonQuery();
        cmd2.ExecuteNonQuery();
    }


    public void supprimerProduit(int var)
    {
        string requete = "DELETE FROM produits WHERE id = " + var + ";";

        MySqlCommand cmd = new MySqlCommand(requete, connection);

        //Execute command
        cmd.ExecuteNonQuery();

    }
    public void destockerProduit(int var)
    {
        string requete = "UPDATE mouvement_stock set quantite = 0 where produits_id in (select id FROM produits where id = " + var + ");";

        MySqlCommand cmd = new MySqlCommand(requete, connection);

        //Execute command
        cmd.ExecuteNonQuery();

    }


}
