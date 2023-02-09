using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;

public class puntajejugador : MonoBehaviour
{
    public InputField textoNombre;
    public static string nombreJugador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enviar(){
        nombreJugador = textoNombre.text;
        enviarPorPost();
        
    }

    public void enviarPorPost(){
        Usuario usuario = new Usuario();
        RestClient.Post("https://dinocoding-77ff9-default-rtdb.firebaseio.com/.json", usuario);

        
    }
}
