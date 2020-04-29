using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Unity AI -> Navigation 관련기능 사용시 필요
using UnityEngine.AI;

public class Monster_AI : MonoBehaviour
{
    Rigidbody rb;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
        //회전X
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        // "Player"라는 태그를 가진 물체를 따라간다.
        agent.SetDestination(GameObject.FindWithTag("Player").transform.position);

    }
}
