using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    public float BGSpeed;
    public float acceleration;

    public bool isMove;             // đặt điều kiện move cho map chỉ khi nhân vật còn sống, nếu nv chết map sẽ dừng lại
    public static Move Instance;
    void Start()
    { 
        Instance = this;
        isMove = true;
    }

    void Update()
    {
        if (isMove==true)
        {
            transform.Translate(0, 0, BGSpeed * acceleration * Time.deltaTime);
        }
    }

    public void IncreaseAcceleration()
    {
        acceleration += 0.1f;
    }
   
}
