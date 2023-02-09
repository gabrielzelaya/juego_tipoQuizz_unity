using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class highscore : MonoBehaviour
{

    public float Score;
    public float Highscore;

     public Text scoretext;
     public Text Highscoretext;

     public void AddScore()
     {
         Score++;
     }

      //Start is called before the first frame update
     void Start(){
        
    }

     // Update is called once per frame
     void Update(){
         scoretext.text = Score.ToString();
        
     }
 }
