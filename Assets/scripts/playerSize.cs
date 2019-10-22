using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSize : MonoBehaviour
{
    public float x;
    

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
        grow();
        shrink();

    }

    void grow()
    {

        if (Input.GetButtonDown(increasesize))
        {
            transform.localScale += new Vector3(x, x, x);

        }
    }

    void shrink()
    {

        if (Input.GetButtonDown(decreasesize))
        {
            transform.localScale -= new Vector3(x, x, x);

        }
    }
}
