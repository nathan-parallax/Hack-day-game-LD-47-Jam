using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CessPoolAnimator : MonoBehaviour
{
    public int AnimationCall;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //AnimationCall = System.Random.Range (1, 4);
        if (1 < AnimationCall && AnimationCall < 2)
        {
            animator.Play("Cesspool1Anim");
        }
        if (2 < AnimationCall && AnimationCall < 3)
        {
            animator.Play("Cesspool2Anim");
        }
        if (3 < AnimationCall && AnimationCall < 4)
        {
            animator.Play("Cesspool3Anim");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
