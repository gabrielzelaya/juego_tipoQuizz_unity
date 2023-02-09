using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Controlaaador : MonoBehaviour
{
    public int index;
    // Se llama al inicio antes de la primera actualizacion del cuadro
    void Start()
    {
        
    }

    public void cambiar(){
        SceneManager.LoadScene(index);
    }

    // La actualizacion se llama una vez por cuadro
    void Update()
    {
        
    }
}
