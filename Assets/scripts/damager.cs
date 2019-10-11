using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damager : MonoBehaviour
{
    public GameObject otherplayer;
    public float knockback ;
    public Rigidbody myrb;
    public PlayerController y;

     void Start()
    {
        myrb = GetComponent<Rigidbody>();
        y = GetComponent<PlayerController>();
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "damager")
        {
            Debug.Log("hit");
          //  otherplayer.PlayerController.Takingdamage = true;
        }
    }
}
