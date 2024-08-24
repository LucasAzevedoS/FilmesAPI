using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateFilmeDto
{

    [Required(ErrorMessage = "O titulo do filme ehh obrigatorio")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O titulo do genero ehh obrigatorio")]
    [StringLength(50, ErrorMessage = "O tamanho do genero nao pode exceder 50 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duracao deve ter no minimo 70 e no maximo 600 minutos")]
    public int Duracao { get; set; }

    [Required]
    [MaxLength(50, ErrorMessage = "O nome do diretor nao pode exceder 50 caracteres")]
    public string Diretor { get; set; }

}
