using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int Score = 100;

    public static int score2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake(){

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
