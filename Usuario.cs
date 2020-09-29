using System;

namespace PR3_SecureUserDatabase
{
    class Usuario
    {
    public string nombre {get; set; }
    public string identificador {get; set; }
    public string clave {get; set;}
    public string autorizacion {get; set; }
    public Usuario (string nombre, string identificador, string clave, string autorizacion){
        this.nombre = nombre;
        this.identificador = identificador;
        this.autorizacion = autorizacion;
        this.clave = clave;

    }
    public string Nombres(){
        return nombre;
    }
    public string Identificador(){
        return identificador;
    }
    public string Clave(){
        return clave;
    }
    public string Autorizacion(){
        return autorizacion;
    }

    }
}
