using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System;
using System.IO;
// using Assets;

public class JsonApi : MonoBehaviour
{

    public GuardarDatos guardarDatos;

    private const string API_KEY = "88169749096b61e3b85398905927f53c";

    void Start()
    {
        String jsonResp = TestJson();
        Debug.Log(jsonResp);
    }

    public String TestJson()
    {

        Debug.Log("nombre:" + guardarDatos.nombrePersonaje  + "   puntaje:" + guardarDatos.puntajeJugador);
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Format("https://us-central1-opera-gaming.cloudfunctions.net/app/guardar?nick=" + guardarDatos.nombrePersonaje + "&puntos=" + guardarDatos.puntajeJugador, 1, API_KEY));

        
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = reader.ReadToEnd();
        return jsonResponse;
    }

}
