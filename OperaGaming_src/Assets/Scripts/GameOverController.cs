using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{

    public int numeroCambioEscena;

    public GuardarDatos guardarDatos;
    // public Text puntosText;
    public GameObject go_puntosText;

    void Start() {
        go_puntosText.GetComponent<Text>().text = guardarDatos.puntajeJugador + " PUNTOS";
    }

    void Update() {
         if (Input.GetKey(KeyCode.Return))  
            CargarMenuPrincipal();
    }
    

    public void CargarMenuPrincipal()
    {
        Debug.Log("GameOver volver al inicio");
        GameController.levels = GameController.CANTIDAD_PARTIDOS;
        GameController.levelActual = 1;
        
        guardarDatos.puntajeJugador = 0;
        guardarDatos.nombrePersonaje = "";
        guardarDatos.numeroPersonaje = 0;
       
        SceneManager.LoadScene(numeroCambioEscena);
    }

    
        



    // public void Start {
    //     // go_puntosText = GameObject.Find("Puntos");
    //     // go_puntosText.GetComponent<Text>().text = guardarDatos.puntajeJugador;

    //     // puntosText.text = guardarDatos.puntajeJugador.toString() + " PUNTOS";

    //     // go_puntosText.GetComponent<Text>.text = guardarDatos.puntajeJugador.toString() + " PUNTOS";

    // }

}
