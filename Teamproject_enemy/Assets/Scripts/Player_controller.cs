using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public float speed;
    public float runspeed;
    public float rotaespeed;

    Animator animator;
    private float HorizontalMove;
    private float VerticallMove;
    private bool isRun;
    private bool isPickup;

    void Start()
    {
        animator = GetComponent<Animator>();
        isRun = false;
        isPickup = false;
    }

    // Update is called once per frame
    void Update()
    {
        my_Pickup();
        my_Translation();
        AnimationUpdate();
    }

    void my_Translation()
    {
        HorizontalMove = Input.GetAxis("Horizontal");
        VerticallMove = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(new Vector3(HorizontalMove, 0, VerticallMove) * runspeed * Time.deltaTime);
            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * rotaespeed);
            isRun = true;
        }
        else
        {
            isRun = false;
            transform.Translate(new Vector3(HorizontalMove, 0, VerticallMove) * speed * Time.deltaTime);
            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * rotaespeed);
        }


    }



    void AnimationUpdate()
    {
        if (HorizontalMove == 0 && VerticallMove == 0)
        {
            animator.SetBool("walk", false);
            animator.SetBool("run", false);
            animator.SetBool("pickup", false);
        }
        else
        {
            if (isRun)
            {
                animator.SetBool("walk", false);
                animator.SetBool("run", true);
            }
            if (!isRun)
            {
                animator.SetBool("walk", true);
                animator.SetBool("run", false);
            }
        }

        if (isPickup)
        {
            animator.SetBool("pickup", true);
        }

    }


    void my_Pickup()
    {
        if (Input.GetKey(KeyCode.F))
        {
            isPickup = true;
        }
        else isPickup = false;
    }
}
