using System.ComponentModel.DataAnnotations;

namespace crud_blazor_server.Models;

public class Cliente
{
    [Key]
    [Required()]
    public int Id { get; set; }

    [Required(ErrorMessage = "Favor informar o nome!")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "Favor informar o e-mail!")]
    [EmailAddress(ErrorMessage = "Favor informar um e-mail válido!")]
    public string Email { get; set; } = string.Empty;
}