using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playername : MonoBehaviour
{
    public string nameOfPlayer;
    public string saveName;

    public Text inputText;
    public Text loadedName;

    // Start is called before the first frame update
    void Start()
    {
        nameOfPlayer = PlayerPrefs.GetString("name", "none");
        loadedName.text = nameOfPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
    }
}
