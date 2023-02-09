using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarScore : MonoBehaviour
{
    public Text SCORE;
    // Start is called before the first frame update
    void Start()
    {
        SCORE.text = GameController.score2.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


