using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    //Declaring Variable
    public float speed;
    private Vector3 StartP;

    // Start is called before the first frame update
    void Start()
    {
        //Default start position
        StartP = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if background moves left by repeating its width, move it back to the starting position
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < -224)
        {
            transform.position = StartP;
        }
    }
}
