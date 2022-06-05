using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameResult : MonoBehaviour
{
   public Button ResultButton;
    // Start is called before the first frame update
    //UnityからTextMeshProUGUIを参照できるようにする＝TextMeshProUGUI型の変数をpublicで作るようにする
    public TextMeshProUGUI ResultText;

    void Start()
    {
        //結果によって上述で作ったTextにGameResultRaramのisWinを反映させる
        if(GameResultParam.GetIsWinResult())
        {
            ResultText.text = "you win!";
        }
        else{
            ResultText.text = "you lose!";
        }

        ResultButton.onClick.RemoveAllListeners();

        ResultButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Start");
        });
    }

}
