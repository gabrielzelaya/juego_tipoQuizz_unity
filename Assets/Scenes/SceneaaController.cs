using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneaaController : MonoBehaviour
{
    public int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void cambiar(){
        SceneManager.LoadScene(index);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
