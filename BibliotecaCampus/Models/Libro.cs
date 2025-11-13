using System;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaCampus.Models
{
    public enum CategoriaLibro
    {
        Seleccione = 0,
        Programacion,
        Redes,
        BaseDeDatos,
        IA,
        Otro
    }

    public class Libro
    {
        public int Id { get; set; } // Id interno para una lista (Este no necesita entrada del usuario)

        [Required(ErrorMessage = "El titulo es obligatorio.")]
        [MinLength(3, ErrorMessage = "El titulo debe tener al menos 3 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio.")]
        [MinLength(3, ErrorMessage = "El autor debe tener al menos 3 caracteres.")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "La categoria es obligatoria.")]
        [EnumDataType(typeof(CategoriaLibro), ErrorMessage = "Categoria invalida.")]
        public CategoriaLibro Categoria { get; set; }

        [Required(ErrorMessage = "El año de publicacion es obligatorio.")]
        [Range(1900,3000, ErrorMessage = "El año debe estar entre 1900 y el año actual.")]
        public int AñoPublicacion { get; set; }

        [Required(ErrorMessage = "El numero de paginas es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El numero de paginas debe ser mayor a 0.")]
        public int NumeroPaginas { get; set; }

        [Required(ErrorMessage = "El codigo interno es obligatorio.")]
        [RegularExpression(@"^LIB-\d{3}$", ErrorMessage = "El código debe tener el formato LIB-### (ej. LIB-001).")]
        public string CodigoInterno { get; set; }

        [Required(ErrorMessage = "Debe indicar si el libro esta disponible")]
        public bool Disponible { get; set; }
    }
}

