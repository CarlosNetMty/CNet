using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

using AutoMapper;

namespace CNet.PoC
{
    class Item { public string Name { get; set; } }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Staring");
            Console.ReadLine();

            Mapper.CreateMap<SqlDataReader, Item>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(source => source["LName"]));


            string connectionString = "data source=devdb5.maintenancenet.net\\dev;initial catalog=MnetReportUP;User=mn; Password=3int3ll3kt!";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand() 
            { 
                Connection = connection,
                CommandType = System.Data.CommandType.Text,
                CommandText = "SELECT TOP 10 * FROM tblUsers"
            };

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            List<Item> result = new List<Item>();

            while (reader.Read()) 
            { 
                result.Add(Mapper.Map<Item>(reader));
            }

            //DataSet dataSet = new DataSet();
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //adapter.Fill(dataSet);
        }
    }
}
