using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text timerText, endText;
    GameMode gameMode;
    private void Start()
    {
        gameMode = FindObjectOfType<GameMode>();
    }
    private void Update()
    {
        //显示倒计时
        int timer = (int)gameMode.timer;
        timerText.text = (timer / 60).ToString("00") + ":" + (timer % 60).ToString("00");
        if (timer <= 10)
            timerText.color = Color.red;

        //显示胜利或失败
        if (gameMode.isWin)
        {
            endText.text = "胜利";
            endText.color = Color.yellow;
        }
        if (gameMode.isFill)
        {
            endText.text = "失败";
            endText.color = Color.black;
        }
    }
}
