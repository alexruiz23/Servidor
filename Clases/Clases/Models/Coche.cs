namespace Clases.Models
{
	public class Coche
	{
		public string modelo { get; set; }

		public string matricula { get; set; }
		public string marca { get; set; }

		public int año { get; set; }
		public List<Dueño> dueños { get; set; }
		public string img { get; set; }

	}
}
