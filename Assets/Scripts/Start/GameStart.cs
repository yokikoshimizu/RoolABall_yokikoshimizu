using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public Button StartButton;
    // Start is called before the first frame update
    private void Start()
    {
        StartButton.onClick.RemoveAllListeners();

        StartButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MainGame");
        });
    }

 
}
