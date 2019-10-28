using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public string punchInput = "punch1";
    public GameObject hitcollider;
    public float cooldown = 2f;
        void Start()
    {
      //  hitcollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        weaponenable();
    }
    void weaponenable()
    {
        if (Input.GetButtonDown(punchInput))
           
        hitcollider.SetActive(true);
        StartCoroutine(DisableWeaponCollider());
    }

   private IEnumerator DisableWeaponCollider()
    {
        hitcollider.SetActive(false);
        yield return new WaitForSeconds(cooldown);

    }
}
