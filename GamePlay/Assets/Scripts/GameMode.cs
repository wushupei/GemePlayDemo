using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMode : MonoBehaviour
{
    public bool isWin, isFill;
    public float timer;
    private void Update()
    {
        //倒计时
        if (timer > 0)
            timer -= Time.deltaTime;
        else
            isFill = true;
    }

    public void ResetGame() //重置游戏
    {
        SceneManager.LoadScene("Scene");
    }
}
