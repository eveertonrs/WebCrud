using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage ="Este campo é de preenchimento obrigatório")]
        [DisplayName("Nome")]

        public string FullName { get; set; }
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Matricula")]

        public int EmpCode { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Cargo")]

        public int Postions { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Localização")]

        public int OfficeLocation { get; set; }

    }
}
