using System;
using System.Data;
using System.Threading;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Team2PetProject
{
    /// <summary>
    /// Класс для объединения проекта и баз
    /// </summary>
    class DB
    {
        //объект подключения к SQL серверу
        private static SqlConnection connection = null;
        //Метод для создания динамического изменения строки подключения
        //исключает пробелему отличия пути подключения на разных машинах
        public static void ConnectToDatabase()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string connectionString = ConfigurationManager.ConnectionStrings["PetProject_ConnStr"].ConnectionString;
            connectionString = connectionString.Replace("{BASE_DIR}", baseDir);

            connection = new SqlConnection(connectionString);
        }
        //проверка на подлючения к БД
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        //Проверка на закрытие подключения
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        //Возвращение подключения
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
