namespace EmprestimoLivros.Models
{
    public class EmprestimosModel
    {

        public int Id { get; set; } 

        public string Receptor { get;  set; }

        public string Fornecedor { get; set; }

        public string livroEmprestado { get; set; }

        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;    
    }
}
