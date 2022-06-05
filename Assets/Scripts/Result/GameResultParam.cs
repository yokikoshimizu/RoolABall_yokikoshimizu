using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameResultParam
{
    // Start is called before the first frame update
    private static bool isWin;

    public static void Init()
    {
        isWin = false;
    }
    public static bool GetIsWinResult()
    {
        return isWin;
    }
    public static void IsWinResult()
    {
        isWin = true;
    }
    // Update is called once per frame
    public static void IsLoseResult()
    {
        isWin = false;
    }
}
