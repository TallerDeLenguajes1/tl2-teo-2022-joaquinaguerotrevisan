using System;
namespace Tp_Teo_2;

public class Cuenta
{
    // METODOS:
    public abstract float Extraccion(float _Plata, bool _Tipo_Extraccion);
    public abstract void Insercion(float _Plata);

    // ATRIBUTOS:
    public string Nombre;
    public string Apellido;
    public string Dni;
    public float Fondos;

    // CONSTRUCTORES:
    public Cuenta( string _Nombre, string _Apellido, string _Dni, float _Fondos)
    {
        Nombre = _Nombre;
        Apellido = _Apellido;
        Dni = _Dni;
        Fondos = _Fondos;
    }

    public Cuenta()
    {
        Nombre = "Nombre";
        Apellido = "Apellido";
        Dni = "000000000";
        Fondos = 10000;
    }

}

public class Cuenta_Corriente_Dolares : Cuenta
{
    // CONSTRUCTORES:
    public Cuenta_Corriente_Dolares( string _Nombre, string _Apellido, string _Dni,  float _Fondos): base(_Nombre, _Apellido, _Dni, _Fondos);

    public float Extraccion(float _Plata, bool _Tipo_Extraccion)
    {
        if ( (Fondos + 5000) > _Plata && _Plata > 0)
        {
            // Tipo de extraccion: Cajero Automatico.
            if (_Tipo_Extraccion = 0 && _Plata <= 20000) 
            {
                Fondos -= _Plata;
                return _Plata;
            }

            // Tipo de extraccion: Cajero Humano.
            if (_Tipo_Extraccion = 1 && _Plata <= Fondo) 
            {
                Fondos -= _Plata;
                return _Plata;
            }
        }
    }

    public void Insercion(float _Plata)
    {
        if ( _Plata > 0)
        {
            Fondos += _Plata;
        }
    }

}

public class Cuenta_Corriente_Pesos : Cuenta
{
    // CONSTRUCTORES:
    public Cuenta_Corriente_Pesos( string _Nombre, string _Apellido, string _Dni, float _Fondos): base (_Nombre, _Apellido, _Dni, _Fondos);

    public float Extraccion(float _Plata, bool _Tipo_Extraccion)
    {

    }

    public void Insercion(float _Plata)
    {

    }

}

public class Caja_De_Ahorro_Pesos : Cuenta
{
    // CONSTRUCTORES:
    public Caja_De_Ahorro_Pesos( string _Nombre, string _Apellido, string _Dni, float _Fondos): base (_Nombre, _Apellido, _Dni, _Fondos);

    public abstract float Extraccion(float _Plata, bool _Tipo_Extraccion)
    {

    }

    public abstract void Insercion(float _Plata)
    {

    }

}