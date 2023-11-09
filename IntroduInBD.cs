﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.Common;
using System.Data.Linq;

namespace ATM_Tiketing
{
    internal class IntroduInBD
    {
        //BazaDate _bd = BazaDate.GetInstance();
        TicketingSystemDBDataContext db = new TicketingSystemDBDataContext();

        public void insereazaUtilizator(string nume, string prenume, string mail, string nr_tel, string parola)
        {
            /*string query = $"INSERT INTO Utilizatori (nume, prenume, mail, nr_tel, parola) VALUES ('{nume}', " +
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

            _bd.closeCon();*/

            Utilizatori _utilizator = new Utilizatori();
            _utilizator.nume = nume;
            _utilizator.prenume = prenume;
            _utilizator.mail = mail;
            _utilizator.nr_tel = nr_tel;
            _utilizator.parola = parola;
            _utilizator.tip = 0;

            db.Utilizatoris.InsertOnSubmit( _utilizator );
            db.SubmitChanges();
            Console.WriteLine("Inserare Utilizator");
        }

        public bool verificaUtilizator(string mail, string parola)
        {
            bool rezultatVerificare = false;

            /*SqlConnection con = _bd.getCon();
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

            _bd.closeCon();*/
            /*
            List<Utilizatori> _utilizatori = new List<Utilizatori>();
            _utilizatori = db.Utilizatoris.ToList();

            foreach(Utilizatori i in _utilizatori)
                if( i.mail == mail  && i.parola == parola)
                {
                    rezultatVerificare = true;
                    break;
                }
            */

            //db.VerificaUtilizator(mail, parola);

            bool? rezultatRef = false;

            try
            {
                db.VerificaUtilizator(mail, parola, ref rezultatRef); 
                rezultatVerificare = rezultatRef.GetValueOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return rezultatVerificare;
        }

        public bool verificaDisponibilitateCont(string mail)
        {
            //bool rezultatVerificare = false;

            /*SqlConnection con = _bd.getCon();
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

            _bd.closeCon();*/

            //return rezultatVerificare;
            return db.Utilizatoris.Any(u => u.mail == mail);
        }

        //TODO de atribuit un departament tichetului 
        public void insereazaTichet(string mail, string subiect, string descriere, string departamet)
        {
            string _data_curenta = DateTime.Now.ToString("yyyy-MM-dd");
            int? _id_utilizator = db.Utilizatoris.FirstOrDefault(u => u.mail == mail)?.id_utilizator;
            int _prioritate = 0;
            int _stare = 0;
            int? _id_departament = db.Departamentes.FirstOrDefault(d => d.departament == departamet)?.id_departament;

            Tichete _tichet = new Tichete();
            _tichet.id_utilizator = (int)_id_utilizator;
            _tichet.id_departament = (int)_id_departament;
            _tichet.subiect = subiect;
            _tichet.descriere = descriere;
            _tichet.prioritate = _prioritate;
            _tichet.stare = _stare;
            _tichet.data_tichet = DateTime.Parse(_data_curenta);

            db.Tichetes.InsertOnSubmit(_tichet);
            db.SubmitChanges();


            Console.WriteLine("Inserare Tichet");

            /*string query = $"INSERT INTO Tichete (id_utilizator, descriere, prioritate, stare, data_tichet) VALUES (" +
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
            //insereazaTichete_Departament();**///
        }

        

        public void actualizeazaDepartament(int id_tichet, int id_departament)
        {
            /*string query = $"update td set td.id_departament = '{id_tichet}' from Tichete_Departamente td " +
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

            _bd.closeCon();*/
        }

    }
}