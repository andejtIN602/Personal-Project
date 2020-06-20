using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
      
{
    static Animator anim;
    float negZ = -1, negX = -1, posZ = 1, posX =1;
    float maxHealth = 1200;
    float currentCondition;

    void Start()
    {
        anim = GetComponent<Animator>();
        currentCondition = maxHealth;
    }

    
    void Update()
    {
        //Kill player debug//
        if (Input.GetKey("l"))
        {
            anim.SetBool("isDead", true);
        }
        else
        {
            anim.SetBool("isDead", false);
        }

        //Walking Animation conditions//
        if (Input.GetKey("w"))
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("moveZ", posZ);
        }
        else if(Input.GetKey("s"))
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("moveZ", negZ);
        }
        else
        {
            anim.SetFloat("moveZ", 0);
        }


        if (Input.GetKey("a"))
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("moveX", negX);
        }
        else if (Input.GetKey("d"))
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("moveX", posX);
        }
        else
        {
           //anim.SetBool("isWalking", false);
           anim.SetFloat("moveX", 0);
        }
    }
}
