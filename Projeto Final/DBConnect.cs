﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Final
{
    class DBConnect
       {
           private MySqlConnection connection;
           private string server;
           private string database;
           private string uid;
           private string password;
   
           //Constructor
           public DBConnect()
           {
               Initialize();
           }
   
           //Initialize values
           private void Initialize()
          {
             server = "localhost";
               database = "connectcsharptomysql";
               uid = "username";
               password = "password";
               string connectionString;
               connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
   
                connection = new MySqlConnection(connectionString);
        }
  
           //open connection to database
           private bool OpenConnection()
           {
               try
               {
                   connection.Open();
                   return true;
               }
               catch (MySqlException ex)
               {
                   //When handling errors, you can your application's response based on the error number.
                   //The two most common error numbers when connecting are as follows:
                   //0: Cannot connect to server.
                   //1045: Invalid user name and/or password.
                   switch (ex.Number)
                   {
                       case 0:
                           MessageBox.Show("Cannot connect to server.  Contact administrator");
                           break;
   
                       case 1045:
                           MessageBox.Show("Invalid username/password, please try again");
                           break;
                   }
                   return false;
               }
           }
  
           //Close connection
           private bool CloseConnection()
           {
               try
               {
                   connection.Close();
                  return true;
               }
               catch (MySqlException ex)
               {
                   MessageBox.Show(ex.Message);
                   return false;
               }
           }
   
           //Insert statement
           public void Insert()
           {
               string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";
   
               //open connection
               if (this.OpenConnection() == true)
               {
                     //create command and assign the query and connection from the constructor
                   MySqlCommand cmd = new MySqlCommand(query, connection);
    
                   //Execute command
                   cmd.ExecuteNonQuery();
    
                   //close connection
                   this.CloseConnection();
                }
          }




}
    }    
    
