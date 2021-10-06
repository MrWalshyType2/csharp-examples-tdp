using Examples.ConsoleAppExample.Data.Model;
using Examples.ConsoleAppExample.Data.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Examples.ConsoleAppExample.Repositories
{
    internal class ItemRepository : ICrdRepository<Item, int>
    {
        private readonly MySqlConnection connection;

        public ItemRepository(MySqlConnection mySqlConnection)
        {
            connection = mySqlConnection;
        }

        public Item Create(Item toCreate)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO item(name) VALUES('{toCreate.Name}')";

            connection.Open();
            command.ExecuteNonQuery(); // ExecuteNonQuery() - use it for CREATE, INSERT, DELETE or any modification
            connection.Close();

            Item item = new Item();
            item.ID = (int)command.LastInsertedId;
            item.Name = toCreate.Name;

            return item;
        }

        public IList<Item> Read()
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM item";

            connection.Open();
            MySqlDataReader reader = command.ExecuteReader(); // returns a reader object

            IList<Item> items = ItemsFromReader(reader);

            connection.Close();

            return items;
        }

        public void Delete(int id)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM item WHERE id={id}";

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IList<Item> ItemsFromReader(MySqlDataReader reader)
        {
            IList<Item> items = new List<Item>();
            while (reader.Read())
            {
                // get values from current row in reader
                int id = reader.GetFieldValue<int>("id");
                string name = reader.GetFieldValue<string>("name");

                Item item = new Item() { ID = id, Name = name };
                items.Add(item);
            }
            return items;
        }

        public bool Exists(int u)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM item WHERE id=@id"; // @id is a placeholder/parameter for prepared statements
            command.Parameters.AddWithValue("@id", u); // adding value to prepared statement

            connection.Open();
            command.Prepare(); // prepare the statement to be executed
            int result = Convert.ToInt32(command.ExecuteScalar()); // ExecuteScalar returns a single value
            connection.Close();

            return result > 0;
        }
    }
}