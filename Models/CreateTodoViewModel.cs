using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mvc.Models;

public class CreateTodoViewModels
{
    

    [DisplayName("Titulo")]
    [Required(ErrorMessage = "Campo Obrigatório")]
    public string Title { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [DisplayName("Última atualização")]
    public DateTime LastUpdate { get; set; } = DateTime.Now;
}