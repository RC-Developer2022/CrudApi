using System.ComponentModel.DataAnnotations;

namespace BackendCrud.Entities
{
    public class Pessoa
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
            Id = Guid.NewGuid();
        }
    }
}
