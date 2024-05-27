using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public TMP_Text PlayerNameInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void StartGame(string sceneName)
    {
        PlayerPrefs.SetString("CurrentPlayerName", PlayerNameInput.text);
        SceneManager.LoadScene(sceneName);
    }
}
