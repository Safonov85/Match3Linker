using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    
    void Start()
    {
        playButton.onClick.AddListener(() => { SceneManager.LoadScene("Game"); });
        exitButton.onClick.AddListener(() => { Application.Quit(); });
    }
}
