using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraObj : MonoBehaviour
{
    [SerializeField]
    private float x, y, z; 
    Character chara;
    Camera cam;
    public bool isSwitch; //镜头切换
    private void Start()
    {
        chara = FindObjectOfType<Character>();
        cam = GetComponent<Camera>();
    }

    private void FixedUpdate()
    {
        FollowCharacter();
        SwitchView();
    }

    void FollowCharacter() //摄像机跟随
    {
        transform.position = chara.transform.position + new Vector3(x, y, z);
    }

    void SwitchView() //切换视野
    {
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, isSwitch ? 40 : 60, 0.2f);
    }
}
