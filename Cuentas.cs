using System;
namespace Tp_Teo_2;

public class Cuenta
{
    // METODOS:
    public float Extraccion(float _Plata, bool _Tipo_Extraccion, int _Tipo_Cuenta);
    public void Insercion(float _Plata, int _Tipo_Cuenta);

    // ATRIBUTOS:
    public string Nombre;
    public string Apellido;
    public string Dni;
    public int Tipo_Cuenta;
    public float Fondos;

    // CONSTRUCTORES
    public Cuenta( string _Nombre, string _Apellido, string _Dni, int _Tipo_Cuenta, float _Fondos)
    {
        Nombre = _Nombre;
        Apellido = _Apellido;
        Dni = _Dni;
        Tipo_Cuenta = _Tipo_Cuenta;
        Fondos = _Fondos;
    }

    public Cuenta()
    {
        Nombre = "Nombre";
        Apellido = "Apellido";
        Dni = "000000000";
        Tipo_Cuenta = 0;
        Fondos = 10000;
    }

    // METODOS:
    public Extraccion(float _Plata, bool _Tipo_Extraccion, int _Tipo_Cuenta)
    {

    }

    public void Insercion(float _Plata, int _Tipo_Cuenta)
    {
        
    }
}