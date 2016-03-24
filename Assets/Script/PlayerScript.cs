using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public float playerSpeed;   // tốc độ ban đầu
    public float acceleration;  // gia tốc
    Animator anim;
    Rigidbody rigid;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        AutoMove();
        if (Input.GetButtonDown("Fire1"))
        {
            rigid.AddForce(0, 500, 0);
        }
    }

    void AutoMove()
    {
        playerSpeed = playerSpeed * acceleration;
        transform.Translate(0, 0, playerSpeed * Time.deltaTime);
    }

    void Jump()
    {

    }
}
