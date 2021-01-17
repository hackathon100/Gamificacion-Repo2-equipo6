using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorMenuIncio : MonoBehaviour
{
    public GuardarDatos guardarDatos;
    public Text inputField;
    public int numeroCambioEscena;

    private int numeroJugador;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FuncionGuardarDatos()
    {
        if (inputField.text != "" && numeroJugador != 0)
        {
            guardarDatos.nombrePersonaje = inputField.text;
            guardarDatos.numeroPersonaje = numeroJugador;
            Debug.Log("a1:" + numeroCambioEscena);
            SceneManager.LoadScene(numeroCambioEscena);
            Debug.Log("Si");
        }
        else if (inputField.text == "" && numeroJugador == 0)
        {
            Debug.Log("No");
        }
    }

    public void SelecionPersonaje(int numeropersonaje)
    {
        numeroJugador = numeropersonaje;
    }
}
