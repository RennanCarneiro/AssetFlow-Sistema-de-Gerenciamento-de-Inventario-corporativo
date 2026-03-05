using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AssetFlow.Api.Models;
public class Asset
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; [Required]
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; } [Range(0, double.MaxValue)]
    public DateTime AcquisitionDate { get; set; } = DateTime.Now;
    public string Status { get; set; } = "Available"; // Disponível, Em Uso, Manutenção
}