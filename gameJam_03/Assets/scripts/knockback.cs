using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour
{
    public float knockbackForce = 100f;
    public float weaponKnockBack = 1000f;

   
    Rigidbody myrb;
    // Start is called before the first frame update
    void Start()
    {
        myrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            myrb.AddForce(other.transform.forward*knockbackForce);
        }

        if (other.gameObject.tag == "damager")
        {
            myrb.AddForce(other.transform.forward * weaponKnockBack);

        }
        if (other.gameObject.tag == "damager_2")
        {
            myrb.AddForce(other.transform.forward * weaponKnockBack);

        }
    }

  
}
