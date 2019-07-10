using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character : MonoBehaviour
{
    Rigidbody rig;
    [SerializeField]
    private float speed, jumpForce;
    bool isGround;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }
    public void Move(float x, float z) //移动
    {
        rig.AddForce(new Vector3(x, 0, z) * speed);
        rig.velocity = Vector3.ClampMagnitude(rig.velocity, speed); //速度限制
    }
    public void Jump() //跳跃
    {
        if (isGround)
            rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
    }

    private void OnCollisionEnter(Collision collision) //开始碰撞
    {
        isGround = true;
        if (collision.transform.CompareTag("End"))
            FindObjectOfType<GameMode>().isWin = true;
    }
    private void OnCollisionExit(Collision collision) //结束碰撞
    {
        isGround = false;
    }

}
