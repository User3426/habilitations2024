using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024
{
    public class BddManager
    {
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private readonly MySqlConnection connection;
        /// <summary>
        /// Objet de connexion à la BDD à partir d'une chaîne de connexion
        /// </summary>
        private static BddManager instance = null;

        private BddManager(string stringConnect)
        {
            connection = new MySqlConnection(stringConnect);
            connection.Open();
        }

        /// <summary>
        /// creation d'une instance unique de la classe
        /// </summary>
        /// <param name="stringConnect"></param>
        /// <returns></returns>
        public static BddManager getInstance(string stringConnect)
        {
            if (BddManager.instance == null)
            {
                BddManager.instance = new BddManager(stringConnect);
            }
            return BddManager.instance;
        }

        public void reqUpdate(string stringQuery, Dictionary<string, object> parametres)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (!(parametres is null))
            {
                foreach (KeyValuePair<string, object> parametre in parametres)
                {
                    command.Parameters.Add(new MySqlParameter(parametre.Key, parametre.Value));
                }
            }
            command.Prepare();
            command.ExecuteNonQuery();

        }
    }
}
