using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationControl : MonoBehaviour
{

    private string currentstate;

    const string PLAYER_IDLE = "idle";
    const string PLAYER_MOVE = "walking";
    const string PLAYER_SEARCH = "searching";

    public Animator animator;



     void Start()
    {

        animator = GetComponent<Animator>();
        animator.Play("idle");

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
