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
        BazaDate _bd = BazaDate.GetInstance();

        public void insereazaUtilizator(string nume, string prenume, string mail, string nr_tel, string parola)
        {
            string query = $"INSERT INTO Utilizatori (nume, prenume, mail, nr_tel, parola) VALUES ('{nume}', " +
                $"'{prenume}', '{mail}', '{nr_tel}', '{parola}')";

            SqlConnection con = _bd.getCon();
            
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
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
            }

            _bd.closeCon();

        }

        public bool verificaUtilizator(string mail, string parola)
        {
            bool rezultatVerificare = false;

            SqlConnection con = _bd.getCon();
            string query = "SELECT COUNT(*) FROM Utilizatori WHERE mail = @mail AND parola = @parola";
            
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
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
            }

            _bd.closeCon();
            
            return rezultatVerificare;
        }

        public bool verificaDisponibilitateCont(string mail)
        {
            bool rezultatVerificare = false;

            SqlConnection con = _bd.getCon();
            string query = "SELECT COUNT(*) FROM Utilizatori WHERE mail = @mail";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@mail", mail);

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
            }

            _bd.closeCon();

            return rezultatVerificare;
        }

        //TODO de atribuit un departament tichetului 
        public void insereazaTichet(string mail, string descriere, string departamet)
        {
            string _data_curenta = DateTime.Now.ToString("yyyy-MM-dd");
            int _id_utilizator = getIdUtilizator(mail);
            int _prioritate = 0;
            int _stare = 0;

            string query = $"INSERT INTO Tichete (id_utilizator, descriere,mail, prioritate, stare, data_tichet) VALUES (" +
                $"'{_id_utilizator}', '{descriere}', '{mail}', '{_prioritate}', '{_stare}', '{_data_curenta}')";

            SqlConnection con = _bd.getCon();

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
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
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            _bd.closeCon();

            // TODO
            //insereazaTichete_Departament();
        }

        public int getIdUtilizator(string mail)
        {
            int _id = -1;

            SqlConnection con = _bd.getCon();
            string query = "select u.id_utilizator from Utilizatori u where u.mail = @mail";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@mail", mail);

                try
                {
                    _id = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare: " + ex.Message);
                }
            }

            _bd.closeCon();

            return _id;
        }

        public void insereazaDepartament(string departament)
        {
            string query = $"INSERT INTO Departamente (departament) VALUES ('{departament}')";

            SqlConnection con = _bd.getCon();

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                
                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Datele au fost inserate cu succes.");
                    }
                    else
                    {
                        Console.WriteLine("Inserarea datelor a eșuat.");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine (e.Message);
                }
            }

            _bd.closeCon() ;
        }

        //TODO actualizare departament in functie de id_tichet
        public void insereazaTichete_Departament(int id_tichet, int id_departament)
        {
            string query = $"INSERT INTO Tichete_Departamente (id_tichet, id_departament) " +
                $"VALUES ('{id_tichet}', '{id_departament}')";

            SqlConnection con = _bd.getCon();

            using (SqlCommand com = new SqlCommand(query, con))
            {
                try
                {
                    int result = com.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Datele au fost inserate cu succes.");
                    }
                    else
                    {
                        Console.WriteLine("Inserarea datelor a eșuat.");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine (e.Message);
                }
            }

            _bd.closeCon();
        }

        public void actualizeazaDepartament(int id_tichet, int id_departament)
        {
            string query = $"update td set td.id_departament = '{id_tichet}' from Tichete_Departamente td " +
                $"where td.id_tichet = '{id_departament}'";

            SqlConnection con = _bd.getCon();

            using (SqlCommand com = new SqlCommand(query, con))
            {
                try
                {
                    int result = com.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Datele au fost actualizate cu succes.");
                    }
                    else
                    {
                        Console.WriteLine("Actualizarea datelor a eșuat.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            _bd.closeCon();
        }

        public int getIdDepartament(string departament)
        {
            int _id = -1;

            SqlConnection con = _bd.getCon();
            string query = $"select d.id_departament from Departamente d where d.departament ='{departament}'";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                try
                {
                    _id = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare: " + ex.Message);
                }
            }

            _bd.closeCon();

            return _id;
        }
    }
}