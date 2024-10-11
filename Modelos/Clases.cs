public enum Tipo_Entidad{
    Serie = 'S',
    Pelicula = 'P',
    Libro = 'L'
}

public class Serie_Libro_Pelicula{
    public int Id {get; set;}
    public string Nombre {get; set;} = "";
    public Tipo_Entidad Tipo {get; set;} = Tipo_Entidad.Serie;
    public string Pais {get; set;} = "";
    public string Idioma {get; set;} = "";
    public string? Foto {get; set;}
    public string Resumen {get; set;} = "";

    public List<Personaje> Personajes {get; set;} = new List<Personaje>();

}

public class Personaje{
    public int Id {get; set;}
    public string Nombre {get; set;} = "";
    public string Apodo {get; set;} = "";
    public string Raza {get; set;} = "";
    public string? Foto {get; set;}
    public int Edad {get; set;} = 0;
    public string Poder_caracteristico {get; set;} = "";

    public int Serie_Libro_Pelicula_Id {get; set;}
    public Serie_Libro_Pelicula Serie_Libro_Pelicula {get; set;} = null;

}