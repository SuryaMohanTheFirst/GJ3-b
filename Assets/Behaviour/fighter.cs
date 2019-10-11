using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fighter : MonoBehaviour

 {
    public enum PlayerType
    {
        P1,p2
    };

    public static float MaxHealth = 100f;
    public float health = MaxHealth;

    public string fighterName;

    public Rigidbody myRb;
    public Animator animator;

    public fighter oponent;
    public PlayerType player;

    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

    }

    public void UpdatePlayerInput()
    {
        //movement inputs//
        if(Input.GetAxis("Horizontal") > .1 )
        {
            animator.SetBool("run", true);
        }
        else
        { animator.SetBool("run", false); }

        if (Input.GetAxis("Vertical") > .1)
        {
            animator.SetBool("run", true);
        }
        else
        { animator.SetBool("run", false); }

        // Jump//
        if (Input.GetKeyDown("joystick button 0"))
        {
            animator.SetBool("jump", true);
        }
        else
        { animator.SetBool("jump", false); }

        // punch //
        if (Input.GetKeyDown("joystick button 2"))
        {
            animator.SetTrigger("punch");
        }
        // kick//
        if (Input.GetKeyDown("joystick button 3"))
        {
            animator.SetTrigger("kick");
        }
        

    }



    void Update()
    {
        if (player == PlayerType.P1)
        {
            UpdatePlayerInput();
        }

        animator.SetFloat("health", healthPercent);

        if (oponent != null)
        {
            animator.SetFloat("oponent_health", oponent.healthPercent);
        }

        else
         {
            animator.SetFloat("oponent_health", 1);
         }

        

    }

    public float healthPercent
    {
        get
         {
        return health / MaxHealth;
         }

    } 
    public Rigidbody body {
        get
        {
            return this.myRb;
        }

    }

}
