using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANIMATE : MonoBehaviour
{
    public Animator anim;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            anim.SetTrigger("IDLE");

        if (Input.GetKeyDown(KeyCode.W))
            anim.SetTrigger("WALK");

        if (Input.GetKeyDown(KeyCode.D))
            anim.SetTrigger("DEATH");
    }
}
