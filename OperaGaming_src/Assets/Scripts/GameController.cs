using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public float timeLeft;
    // public int levelsTotal;

    public static int CANTIDAD_PARTIDOS = 7;
    
    public static int levels = CANTIDAD_PARTIDOS;
    public static int levelActual = 1;
    // public static int puntos = 0;
    public int points = 0;
    public int levelConEnemigo;
    int time;
    int respuesta;
    GameObject pregunta;
    GameObject tiempoValor;
    GameObject PuntosVlr;
    GameObject victoryIcon;
    GameObject derrotaIcon;
    GameObject preguntaSpoiler;
    GameObject respuestaSpoiler;
    Boolean finJogo = false;
    System.Random rnd;

    public GameObject plataforma1;
    public GameObject plataforma2;
    public GameObject plataforma3;
    public GameObject plataforma4;
    public GameObject plataforma5;
    public GameObject plataforma6;
    public GameObject plataforma7;
    public GameObject plataforma8;
    public GameObject plataforma9;

    public GuardarDatos guardarDatos;

    GameObject go_Plataformas_container;
    GameObject plataformaResource;
    public GameObject drpato;



    void Start()
    {

        Debug.Log("||||||||||||||||Inicio.|||||||||||||||");
        Debug.Log("partidos restantes: " + levels);
        rnd = new System.Random();

        int posicionRespuesta = rnd.Next(6, 11);

        String name;

        name = "plataforma" + rnd.Next(1, 9);
        plataformaResource = Resources.Load(name, typeof(GameObject)) as GameObject;
        GameObject i2 = Instantiate(plataformaResource, new Vector3(0, 0, 18), Quaternion.identity);
        i2.name = name;
        i2.transform.parent = GameObject.Find("Plataformas").transform;
        i2.transform.Rotate(0, 180, 0);

        name = "plataforma" + rnd.Next(1, 9);
        plataformaResource = Resources.Load(name, typeof(GameObject)) as GameObject;
        GameObject i3 = Instantiate(plataformaResource, new Vector3(0, 0, 36), Quaternion.identity);
        i3.name = name;
        i3.transform.parent = GameObject.Find("Plataformas").transform;
        i3.transform.Rotate(0, 180, 0);

        name = "plataforma" + rnd.Next(1, 9);
        plataformaResource = Resources.Load(name, typeof(GameObject)) as GameObject;
        GameObject i4 = Instantiate(plataformaResource, new Vector3(0, 0, 54), Quaternion.identity);
        i4.name = name;
        i4.transform.parent = GameObject.Find("Plataformas").transform;
        i4.transform.Rotate(0, 180, 0);


        int numero1 = rnd.Next(1, 5);
        int numero2 = rnd.Next(1, 5);
        pregunta.GetComponent<Text>().text = numero1.ToString() + " + " + numero2.ToString();


        respuesta = numero1 + numero2;
        // Debug.Log("respuesta: " + respuesta);


        List<String> plataformasGeneradas = new List<string>();


        name = "plataforma" + rnd.Next(1, 9);
        plataformaResource = Resources.Load(name, typeof(GameObject)) as GameObject;
        GameObject i5 = Instantiate(plataformaResource, new Vector3(22, 0, 0), Quaternion.identity);
        i5.name = name;
        i5.transform.parent = GameObject.Find("Plataformas").transform;
        i5.transform.Rotate(0, 180, 0);
        plataformasGeneradas.Add(name);

        name = "plataforma" + rnd.Next(1, 9);
        plataformaResource = Resources.Load(name, typeof(GameObject)) as GameObject;
        GameObject i6 = Instantiate(plataformaResource, new Vector3(22, 0, 18), Quaternion.identity);
        i6.name = name;
        i6.transform.parent = GameObject.Find("Plataformas").transform;
        i6.transform.Rotate(0, 180, 0);
        plataformasGeneradas.Add(name);

        name = "plataforma" + rnd.Next(1, 9);
        plataformaResource = Resources.Load(name, typeof(GameObject)) as GameObject;
        GameObject i7 = Instantiate(plataformaResource, new Vector3(22, 0, 36), Quaternion.identity);
        i7.name = name;
        i7.transform.parent = GameObject.Find("Plataformas").transform;
        i7.transform.Rotate(0, 180, 0);
        plataformasGeneradas.Add(name);

        name = "plataforma" + rnd.Next(1, 9);
        plataformaResource = Resources.Load(name, typeof(GameObject)) as GameObject;
        GameObject i8 = Instantiate(plataformaResource, new Vector3(22, 0, 54), Quaternion.identity);
        i8.name = name;
        i8.transform.parent = GameObject.Find("Plataformas").transform;
        i8.transform.Rotate(0, 180, 0);
        plataformasGeneradas.Add(name);

        name = "plataforma" + rnd.Next(1, 9);
        plataformaResource = Resources.Load(name, typeof(GameObject)) as GameObject;
        GameObject i9 = Instantiate(plataformaResource, new Vector3(44, 0, 0), Quaternion.identity);
        i9.name = name;
        i9.transform.parent = GameObject.Find("Plataformas").transform;
        i9.transform.Rotate(0, 180, 0);
        plataformasGeneradas.Add(name);

        name = "plataforma" + rnd.Next(1, 9);
        plataformaResource = Resources.Load(name, typeof(GameObject)) as GameObject;
        GameObject i10 = Instantiate(plataformaResource, new Vector3(44, 0, 18), Quaternion.identity);
        i10.name = name;
        i10.transform.parent = GameObject.Find("Plataformas").transform;
        i10.transform.Rotate(0, 180, 0);
        plataformasGeneradas.Add(name);

        name = "plataforma" + rnd.Next(1, 9);
        plataformaResource = Resources.Load(name, typeof(GameObject)) as GameObject;
        GameObject i11 = Instantiate(plataformaResource, new Vector3(44, 0, 36), Quaternion.identity);
        i11.name = name;
        i11.transform.parent = GameObject.Find("Plataformas").transform;
        i11.transform.Rotate(0, 180, 0);
        plataformasGeneradas.Add(name);

        name = "plataforma" + rnd.Next(1, 9);
        plataformaResource = Resources.Load(name, typeof(GameObject)) as GameObject;
        GameObject i12 = Instantiate(plataformaResource, new Vector3(44, 0, 54), Quaternion.identity);
        i12.name = name;
        i12.transform.parent = GameObject.Find("Plataformas").transform;
        i12.transform.Rotate(0, 180, 0);
        plataformasGeneradas.Add(name);


        // Calculo randomico para posicionar la plataforma verdadera/correcta
        System.Random rnd_plat_correcta_x = new System.Random();
        bool result = rnd_plat_correcta_x.Next(100) < 50 ? true : false;

        int xPosCorecta, zPosCorrecta;
        if (result)
        {
            xPosCorecta = 22;
        }
        else
        {
            xPosCorecta = 44;
        }

        int[] AllowedValues = new int[] { 0, 18, 36, 54 };
        System.Random rnd_plat_correcta_z = new System.Random();

        zPosCorrecta = AllowedValues[rnd_plat_correcta_z.Next(AllowedValues.Length)];


        // RESPUESTA
        name = "plataforma" + respuesta;
        plataformaResource = Resources.Load(name, typeof(GameObject)) as GameObject;
        GameObject iRespuesta = Instantiate(plataformaResource, new Vector3(xPosCorecta, 0.1f, zPosCorrecta), Quaternion.identity);
        iRespuesta.name = name;
        iRespuesta.transform.parent = GameObject.Find("Plataformas").transform;
        iRespuesta.transform.Rotate(0, 180, 0);
        iRespuesta.transform.localScale = new Vector3(20.06f, 1.1f, 16.72f);

        // Debug.Log("levelActual:" + levelActual);
        if (levelActual >= levelConEnemigo) {
            Instantiate(drpato, new Vector3(22, 0, 36), Quaternion.identity);
        }

        tiempoValor = GameObject.Find("TiempoValor");
        tiempoValor.GetComponent<Text>().text = timeLeft.ToString();

        PuntosVlr = GameObject.Find("PuntosVlr");
        PuntosVlr.GetComponent<Text>().text = guardarDatos.puntajeJugador.ToString();
        // PuntosVlr.GetComponent<Text>().text = guardarDatos.puntajeJugador.toString();
    

    }

    void Awake()
    {
        victoryIcon = GameObject.Find("VictoryIcon");
        derrotaIcon = GameObject.Find("DerrotaIcon");
        pregunta = GameObject.Find("Pregunta");
    }

    void Update()
    {
        time = (int)timeLeft;
        tiempoValor.GetComponent<Text>().text = time.ToString();

        PuntosVlr = GameObject.Find("PuntosVlr");
        PuntosVlr.GetComponent<Text>().text = guardarDatos.puntajeJugador.ToString();


        if (timeLeft > 0)
            timeLeft -= Time.deltaTime;

        if (timeLeft < 0 && !finJogo)
        {
            Debug.Log("call EndMatch().. ");
            finJogo = true;
            EndMatch();
        }
    }

    public void EndMatch()
    {
        
        levels--;

        // Vence
        if (PlayerController.plataformaActual.Equals("Plat" + respuesta))
        {
            victoryIcon.GetComponent<Image>().enabled = true;
            guardarDatos.puntajeJugador++;
        }
        else
        {
            derrotaIcon.GetComponent<Image>().enabled = true;
        }

        preguntaSpoiler = GameObject.Find("PreguntaSpoiler");
        preguntaSpoiler.GetComponent<Text>().enabled = true;
        preguntaSpoiler.GetComponent<Text>().text = pregunta.GetComponent<Text>().text + " = ";

        respuestaSpoiler = GameObject.Find("RespuestaSpoiler");
        respuestaSpoiler.GetComponent<Text>().enabled = true;
        respuestaSpoiler.GetComponent<Text>().text = respuesta.ToString();

        if (levels > 0)
        {
            Debug.Log("c1");
            StartCoroutine(NextLevel());
        }
        else
        {
            Debug.Log("c2");
            StartCoroutine(GameOver());
        }

        
    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(2.0f);
        levelActual++;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    IEnumerator GameOver()
    {
        Debug.Log("GameOver()");
        yield return new WaitForSeconds(2.0f);

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("GameOver");
    }


    void OnCollisionEnter(Collision objetoQueColidiu)
    {
    }

    private void OnTriggerEnter(Collider other)
    {

        // if (gameObject.CompareTag("Player"))
        // {
        // }

    }



}
