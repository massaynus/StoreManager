﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Collections.ObjectModel;

namespace Store_Manager
{
    public class Statistics
    {
        public static double PriceSum;
        static int TotalItemsSold;
        static int[] ItemsPerMonth = new int[12];

        static OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Store.accdb");
        static List<string> Products = new List<string>();
        static List<double> Prices = new List<double>();

        public static void GetData()
        {
            connection.Open( );
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT Nom, Prix  FROM  Products", connection);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Products.Add(reader[0].ToString());
                Prices.Add(double.Parse(reader[1].ToString()));
            }
            connection.Close( );
        }

        public static void OnBuy(string Pr)
        {
            GetData();
            int index = 0;
            foreach(string P in Products)
            {
                if (Pr == P)
                    break;
                else
                    index++;
            }
            PriceSum += Prices[index];

            TotalItemsSold++;
            ItemsPerMonth[MonthNum() + 1]++;
        }

        public static void CancelBuy( string Pr)
        {
            GetData();
            int index = 0;
            foreach (string P in Products)
            {
                if (Pr == P)
                    break;
                else
                    index++;
            }
            PriceSum -= Prices[index];
        }

        public static int MonthNum( )
        {
            int Month = DateTime.Today.Month;
            return Month;
        }

        public void VendorStats( ) { }
        public void MonthlyStatsHandler( ) { }
        public void Logger( string Str ) {        }
        
    }
}
