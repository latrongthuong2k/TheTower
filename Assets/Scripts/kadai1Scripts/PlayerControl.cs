using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float posA = 18 ;
    public float posB;
    public float speed = 5;
    
    
    // Start is called before the first frame update
    void Start()
    { 
        // Set posA
        transform.position = new Vector3(posA, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (transform.position.x < posB )
        {
            speed = 0;
        }
    }
}
