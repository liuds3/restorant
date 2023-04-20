using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

using Org.Ktu.Isk.P175B602.Autonuoma.Models;


namespace Org.Ktu.Isk.P175B602.Autonuoma.Repositories
{
	public class MeniuRepo
	{
		public static List<Meniu> List()
		{
			var menius = new List<Meniu>();

			string query = $@"SELECT * FROM `{Config.TblPrefix}meniu` ORDER BY id ASC";
			var dt = Sql.Query(query);

			foreach( DataRow item in dt )
			{
				menius.Add(new Meniu
				{
					Id = Convert.ToInt32(item["id"]),
					fk_maistopavadinimas = Convert.ToString(item["maistopavadinimas"]),
					fk_gerimopavadinimas = Convert.ToString(item["gerimopavadinimas"]),
					Kaina = Convert.ToInt32(item["kaina"])
				});
			}

			return menius;
		}

		public static Meniu Find(int id)
		{
			var Menius = new Meniu();

			var query = $@"SELECT * FROM `{Config.TblPrefix}meniu` WHERE id=?id";
			var dt = 
				Sql.Query(query, args => {
					args.Add("?id", MySqlDbType.Int32).Value = id;
				});

			foreach( DataRow item in dt )
			{
				Menius.Id = Convert.ToInt32(item["id"]);
				Menius.fk_maistopavadinimas = Convert.ToString(item["maistopavadinimas"]);
				Menius.fk_gerimopavadinimas = Convert.ToString(item["gerimopavadinimas"]);
				Menius.Kaina = Convert.ToInt32(item["kaina"]);
			}

			return Menius;
		}
		public static void Update(Meniu Meniu)
		{			
			var query = 
				$@"UPDATE `{Config.TblPrefix}meniu` 
				SET 
					maistopavadinimas=?maistopavadinimas,
					gerimopavadinimas=?gerimopavadinimas,
					kaina=?kaina
				WHERE 
					id=?id";

			Sql.Update(query, args => {
				args.Add("?id", MySqlDbType.VarChar).Value = Meniu.Id;
				args.Add("?maistopavadinimas", MySqlDbType.VarChar).Value = Meniu.fk_maistopavadinimas;
				args.Add("?gerimopavadinimas", MySqlDbType.VarChar).Value = Meniu.fk_gerimopavadinimas;
				args.Add("?kaina", MySqlDbType.VarChar).Value = Meniu.Kaina;
			});							
		}

		public static void Insert(Meniu Meniu)
		{			
				var query =
				$@"INSERT INTO `{Config.TblPrefix}meniu`
				(
					id,
                    maistopavadinimas,
					gerimopavadinimas,
					kaina
				)
				VALUES(
					?id,
					?maistopavadinimas,
					?gerimopavadinimas,
					?kaina
				)";

			Sql.Insert(query, args => {
				args.Add("?id", MySqlDbType.VarChar).Value = Meniu.Id;
				args.Add("?maistopavadinimas", MySqlDbType.VarChar).Value = Meniu.fk_maistopavadinimas;
				args.Add("?gerimopavadinimas", MySqlDbType.VarChar).Value = Meniu.fk_gerimopavadinimas;
				args.Add("?kaina", MySqlDbType.VarChar).Value = Meniu.Kaina;
			});
		}

		public static void Delete(int id)
		{			
			var query = $@"DELETE FROM `{Config.TblPrefix}meniu` where id=?id";
			Sql.Delete(query, args => {
				args.Add("?id", MySqlDbType.Int32).Value = id;
			});			
		}
	}
}