using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Org.Ktu.Isk.P175B602.Autonuoma.Models;

namespace Org.Ktu.Isk.P175B602.Autonuoma.ViewModels
{
	/// <summary>
	/// Model of 'Modelis' entity used in creation and editing forms.
	/// </summary>
	public class MeniuEditVM
	{
		/// <summary>
		/// Entity data
		/// </summary>
		public class MeniuM
		{

		[DisplayName("Id")]
		public int Id { get; set; }

		[DisplayName("MaistoPavadinimas")]
		public string fk_maistopavadinimas { get; set; }

		[DisplayName("GerimoPavadinimas")]
		public string fk_gerimopavadinimas { get; set; }

		[DisplayName("Kaina")]
		public int Kaina { get; set; }

		}
		/// <summary>
		/// Entity view.
		/// </summary>
		public MeniuM Meniu { get; set; } = new MeniuM();
		public User user {get; set;}

	}
}