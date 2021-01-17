using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GuardarDatos", menuName = "Bd")]

public class GuardarDatos : ScriptableObject
{
    //Hace referencia al nombre del personaje
    public string nombrePersonaje;

    //0 = ninguno seleccionado
    //1 = hombre
    //2 = mujer
    public int numeroPersonaje;

    //Esto da a conoser el puntaje
    public int puntajeJugador;
}
