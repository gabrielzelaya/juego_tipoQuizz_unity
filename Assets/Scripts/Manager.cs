using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public GameObject[] Levels;
    public GameObject ResetScreen,End; 

    int currentLevel;


    public void wrongAnswer()
    {
        ResetScreen.SetActive(true);
    }

    public void ResetGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        
    }









    public void correctAnswer()
    {
        if(currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }
        else
        {
            End.SetActive(true);
            Levels[currentLevel].SetActive(false);
        }
    }




}
