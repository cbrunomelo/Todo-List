using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mvc.Models;

public class CreateTodoViewModels
{
    

    [DisplayName("Titulo")]
    [Required(ErrorMessage = "Campo Obrigatório")]
    public string Title { get; set; }

}