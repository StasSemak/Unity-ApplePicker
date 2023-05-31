using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Button startButton;

    void Start()
    {
        GameObject buttonGO = GameObject.Find("StartButton");
        startButton = buttonGO.GetComponent<Button>();
        startButton.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
