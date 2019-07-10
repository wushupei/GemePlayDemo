using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Character chara;
    GameMode gameMode;
    CameraObj cam;
    private void Start()
    {
        chara = FindObjectOfType<Character>();
        gameMode = FindObjectOfType<GameMode>();
        cam = FindObjectOfType<CameraObj>();
    }
    private void FixedUpdate()
    {
        //重置游戏
        if (Input.GetKeyDown(KeyCode.P)) 
            gameMode.ResetGame();
        //游戏结束不能控制角色
        if (gameMode.isFill || gameMode.isWin)
            return;
        //移动
        chara.Move(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //跳跃
        if (Input.GetKeyDown(KeyCode.Space))
            chara.Jump();
        //缩放视野
        if (Input.GetKeyDown(KeyCode.Q))
            cam.isSwitch = !cam.isSwitch;
    }
}
