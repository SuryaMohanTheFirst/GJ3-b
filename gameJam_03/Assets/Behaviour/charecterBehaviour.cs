using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charecterBehaviour :StateMachineBehaviour
{
    public float horizontalForce;
    public float verticalForce;
    protected fighter fighter;
  override public void OnStateEnter (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (fighter == null)
        {
            fighter = animator.gameObject.GetComponent<fighter>();

        }
        fighter.body.AddRelativeForce(new Vector3(0, verticalForce, 0));

    }
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        fighter.body.AddRelativeForce(new Vector3(horizontalForce, 0, horizontalForce));
    }
   
}
