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
        AnimationCall = UnityEngine.Random.Range((int)1, (int)(3 + 1));
        if (AnimationCall == 1)
        {
            animator.Play("Cesspool1Anim");
        }
        if (AnimationCall == 2)
        {
            animator.Play("Cesspool2Anim");
        }
        if (AnimationCall == 3)
        {
            animator.Play("Cesspool3Anim");
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
