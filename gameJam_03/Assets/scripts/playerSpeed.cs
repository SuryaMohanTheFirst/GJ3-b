using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpeed : MonoBehaviour
{
    Transform player;
    float a;
    public PlayerController p1;
    public float big, medium, small;
    public float smallJump, MediumJump, bigJump;

    
    void Start()
    {
        player = GetComponent<Transform>();
       

    }

    
    void Update()
    {
        speedcontrol();
      
    }


    void speedcontrol()
    {
        a = transform.localScale.x;
        if (a <= .5)
        {
            p1.Speed = small;
            p1.JumpSpeed = smallJump;
        }

        if (a == 1.5)
        {
            p1.Speed = medium;
            p1.JumpSpeed = MediumJump;
        }
        if (a >= 2.5)
        {
            p1.Speed = big;
            p1.JumpSpeed = bigJump;
        }
    }
}
