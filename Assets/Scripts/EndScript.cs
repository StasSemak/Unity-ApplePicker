using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScript : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Button startButton;
    public Text screenText;

    void Start()
    {
        GameObject buttonGO = GameObject.Find("StartButton");
        startButton = buttonGO.GetComponent<Button>();
        startButton.onClick.AddListener(StartGame);

        GameObject textGO = GameObject.Find("ScreenText");
        screenText = textGO.GetComponent<Text>();
        screenText.text += Score.score.ToString();
    }

    void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
