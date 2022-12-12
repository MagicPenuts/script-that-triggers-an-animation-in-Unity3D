using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    // The Animator component attached to the game object.
    public Animator animator;

    // The name of the trigger parameter in the Animator component.
    public string triggerName = "Attack";

    // A reference to the target game object.
    public GameObject target;

    // The maximum distance at which the target can be attacked.
    public float attackRange = 5f;

    // Update is called once per frame.
    void Update()
    {
        // Check if the target is within range.
        bool targetInRange = Vector3.Distance(transform.position, target.transform.position) <= attackRange;

        // If the target is within range, set the trigger parameter to start the animation.
        if (targetInRange)
        {
            animator.SetTrigger(triggerName);
        }
        // Otherwise, reset the trigger parameter to stop the animation.
        else
        {
            animator.ResetTrigger(triggerName);
        }
    }
}