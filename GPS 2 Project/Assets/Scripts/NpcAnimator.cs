using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcAnimator : MonoBehaviour
{
    public Animator animator;

    private string currentstate;

    const string NPC_IDLE = "idle";
    const string NPC_MOVE = "walking";
    const string NPC_CATCH = "catch";

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.Play(NPC_IDLE);
    }

    void ChangeAnimationState(string newState)
    {
        // check if newstate is the same as currentstate
        if (currentstate == newState) return;
        // if false then move to change state
        animator.Play(newState);
        // set currentstate to newstate
        currentstate = newState;
    }
}
