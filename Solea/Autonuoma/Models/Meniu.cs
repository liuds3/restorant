using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Org.Ktu.Isk.P175B602.Autonuoma.Models
{
	/// <summary>
	/// Model of 'Modelis' entity.
	/// </summary>
	public class Meniu
	{

        [DisplayName("Id")]
		public int Id { get; set; }

		[DisplayName("MaistoPavadinimas")]
		public string fk_maistopavadinimas { get; set; }

		[DisplayName("GerimoPavadinimas")]
		public string fk_gerimopavadinimas { get; set; }

		[DisplayName("kaina")]
		public int Kaina { get; set; }
	}
}