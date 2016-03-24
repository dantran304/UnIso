using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    Animator anim;
    Rigidbody rigid;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rigid.AddForce(0, 250, 0);
            anim.SetTrigger("jump");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("StartGame");
            anim.SetTrigger("run");
        }

        if (Input.GetButtonDown("Fire3"))
        {
            Debug.Log("Tang toc do");
            Move.Instance.IncreaseAcceleration();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            Debug.Log("Truot");
            Move.Instance.IncreaseAcceleration();
        }
    }

    void Jump()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Trap")
        {
            Debug.Log("Cham vao chuong ngai vat");
            anim.SetTrigger("crack");
            Move.Instance.isMove = false;
        }
    }
}
