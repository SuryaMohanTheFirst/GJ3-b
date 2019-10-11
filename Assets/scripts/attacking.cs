using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacking : MonoBehaviour
{
    public string punchInput = "punch1";
    public string kickInput = "kick1";
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
