﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Mysqlx.Crud;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace HotelManagementSystem
{

    /* In this class 
     * add a new guest
     * update guest
     * delete guest
     * get all function for GuestForm
     * 
     * 
     * 
     */
    internal class GuestClass
    {

        DBConnect connect = new DBConnect();
        // create a function to insert a new guest
        public bool insertGuest(string id, string fname, string lname, string phone, string city)
        {
            string insertQuerry = "INSERT INTO `guest`(`GuestId`, `GuestFirstName`, `GuestLastName`, `GuestPhone`, `GuestCity`) VALUES(@id,@fname,@lname,@ph,@ct)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@id,@fname,@lname,@ph,@ct
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = city;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }

        // Create a function to get the guest list
        public DataTable getGuest()
        {
            string selectQuery = "SELECT * FROM `guest`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        // edit Guest function
        public bool editGuest(string id, string fname, string lname, string phone, string city)
        {
            string editQuerry = "UPDATE `guest` SET `GuestFirstName`=@fname,`GuestLastName`=@lname,`GuestPhone`=@ph,`GuestCity`=@ct WHERE `GuestId`=@id";
            MySqlCommand command = new MySqlCommand(editQuerry, connect.GetConnection());
            //@id,@fname,@lname,@ph,@ct
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = city;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }

        // now create a function to delete the selected guest
        // we only need the guest id for this

        public bool removeGuest(string id)
        {
            string insertQuerry = "DELETE FROM `guest` WHERE `GuestId`=@id";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@id
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }


    }
}
