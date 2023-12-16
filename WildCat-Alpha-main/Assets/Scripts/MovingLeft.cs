using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLeft : MonoBehaviour
{
    public float speed;
    private PlayerControls catControls;
    private float bound = -90;

    // Start is called before the first frame update
    void Start()
    {
        catControls = GameObject.Find("Cat").GetComponent<PlayerControls>();
    }
    // Update is called once per frame
    void Update()
    {
        //if the game is not over the cat should move to the left continuously
        if (!catControls.gameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }
        //if object goes off the screen that is not the background, destroy it
        else if (transform.position.x < bound && gameObject.CompareTag("bin"))
        {
            Destroy(gameObject);
        }
        //if object goes off the screen that is not the background, destroy it
        else if (transform.position.x < bound && gameObject.CompareTag("trash"))
        {
            Destroy(gameObject);
        }
    }
}
