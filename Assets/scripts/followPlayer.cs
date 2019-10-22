using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;        


    private Vector3 offset;            

    
    void Start()
    {
       
        offset = transform.position - player.transform.position;
    }

   
    void LateUpdate()
    {
        
        transform.position = player.transform.position + offset;
        transform.localScale = player.transform.localScale;
        transform.rotation = player.transform.rotation;
    }
}