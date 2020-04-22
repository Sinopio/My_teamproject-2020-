using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner_Move : MonoBehaviour
{
    public float minXpos;
    public float maxXpos;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(speed, 0, 0);

        if (gameObject.transform.position.x < minXpos || gameObject.transform.position.x > maxXpos)
        {
            speed = speed * -1;
        }
        
    }
}
