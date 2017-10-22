using System;
using System.ComponentModel.DataAnnotations;

namespace ContaLuz.Models
{
	public class ContaViewModel
	{
		public int Id { get; set; }
        
		[Required(ErrorMessage = "Campo data leitura é obrigatório")]
		[DataType(DataType.Date, ErrorMessage = "O formato está inválido")]     
		public DateTime DateLeitura { get; set; }
        
		[Required(ErrorMessage = "Campo Número de Leitura é obrigatório")]
		[DataType(DataType.Text, ErrorMessage = "O formato está inválido")]     
		public int NumLeitura { get; set; }

		[Required(ErrorMessage = "Campo Kw Gasto é obrigatório")]    
		[DataType(DataType.Text, ErrorMessage = "O formato está inválido")]     
		public int KwGasto { get; set; }

		[Required(ErrorMessage = "Campo valor é obrigatório")]
		[DataType(DataType.Text, ErrorMessage = "O formato está inválido")]     
		public Decimal ValorPagar { get; set; } 

		[Required(ErrorMessage = "Campo data de pagamento é obrigatório")]
		[DataType(DataType.Date, ErrorMessage = "O formato está inválido")]     
		public DateTime DataPagamento { get; set; }

		[Required(ErrorMessage = "Campo média de consumo é obrigatório")]
		[DataType(DataType.Text, ErrorMessage = "O formato está inválido")]  
		public Decimal MediaConsumo { get; set; }

	}
}