using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Animation : MonoBehaviour
{

    Animator animator;

    private float HorizontalMove;
    private float VerticallMove;

    public bool isAttack;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimationUpdate();
    }

    void AnimationUpdate()
    {
        HorizontalMove = Input.GetAxis("Horizontal");
        VerticallMove = Input.GetAxis("Vertical");

        animator.SetBool("run", true);


        if (isAttack) animator.SetBool("attack", true);
        if (!isAttack) animator.SetBool("attack", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isAttack = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isAttack = false;
        }
    }
}
