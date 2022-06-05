using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public enum GameProgressStates
    {
        GameStart = 0,
        GameMain,
        GameResult
    }
   
    private GameProgressStates gameProgressStates = GameProgressStates.GameStart;

    public void SetGameProgressState(GameProgressStates gameProgressState)
    {
        gameProgressStates = gameProgressState;
    }

    public GameProgressStates GetGameProgressState()
    {
        return gameProgressStates;
    }
}
