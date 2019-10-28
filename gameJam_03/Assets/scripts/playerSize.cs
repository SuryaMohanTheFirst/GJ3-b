using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSize : MonoBehaviour
{
    public float x = 1f;
    bool increase = true;
    bool decrease = true;
    

    public string increasesize = "increase1";
    public string decreasesize = "decrease1";
    Rigidbody myRb;
    Animator animator;


    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

  
    
    void Update()
    {
        growShrinkConditions();
        grow();
        shrink();

    }

    // growing the player
    void grow()
    {

        if (Input.GetButtonDown(increasesize))
        {
            if (increase == true)
            {
                transform.localScale += new Vector3(x, x, x);

            }           

        }
    }

    // shrinking the player
    void shrink()
    {

        if (Input.GetButtonDown(decreasesize))
        {
            if (decrease == true)
            {
                transform.localScale -= new Vector3(x, x, x);
            }
           
        }
    }

   //bool that is disabled once the player reaches max or min size
    void growShrinkConditions()
    {
        float a, b, c;
        a = transform.localScale.x;
        b = transform.localScale.y;
        c = transform.localScale.z;

        if (a <= .5 && b <= .5 && c <= .5)
        {
            decrease = false;
        }
        else
        {
            decrease = true;
        }

        if (a >= 2.5 && b >= 2.5 && c >= 2.5)
        {
            increase = false;
        }
        else
        {
            increase = true;
        }
    }

}
