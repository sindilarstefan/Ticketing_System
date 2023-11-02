﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.Common;

namespace ATM_Tiketing
{
    internal class IntroduInBD
    {
        BazaDate bd = BazaDate.GetInstance();

        public void insereazaUtilizator(string nume, string prenume, string mail, string nr_tel, string parola)
        {
            string query = $"INSERT INTO Utilizatori (nume, prenume, mail, nr_tel, parola) VALUES ('{nume}', " +
                $"'{prenume}', '{mail}', '{nr_tel}', '{parola}')";

            SqlConnection con = bd.getCon();
            SqlCommand cmd = new SqlCommand(query, con);
            int result = cmd.ExecuteNonQuery();

            try
            {
                if (result > 0)
                {
                    Console.WriteLine("Datele au fost inserate cu succes.");
                }
                else
                {
                    Console.WriteLine("Inserarea datelor a eșuat.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            bd.closeCon();

        }

        public bool verificaUtilizator(string mail, string parola)
        {
            bool rezultatVerificare = false;

            SqlConnection con = bd.getCon();
            string query = "SELECT COUNT(*) FROM Utilizatori WHERE mail = @mail AND parola = @parola";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@parola", parola);

            try
            {
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    rezultatVerificare = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            bd.closeCon();
            
            return rezultatVerificare;
        }

    }
}