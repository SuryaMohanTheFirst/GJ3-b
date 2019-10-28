using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacking2 : MonoBehaviour
{
    public string punchInput = "punch2";
    public string kickInput = "kick2";
    public Rigidbody myRb;
    public Animator animator;
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    

    void Update()
    {
        punch();
        kick();
    }

    void punch()
    {
        if(Input.GetButtonDown(punchInput))
        animator.SetTrigger("attack_1");
    }
    void kick()
    {
        if (Input.GetButtonDown(kickInput))
            animator.SetTrigger("kick");
    }
}
