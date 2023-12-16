using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Declaring the speed and referencing another script
    private float speed;
    private PlayerControls catControls;
    private float bound = -52;

    // Start is called before the first frame update
    void Start()
    {
        //Getting the components from referred script called Playercontrols
        catControls = GameObject.Find("Cat").GetComponent<PlayerControls>();

    }

    // Update is called once per frame
    void Update()
    {
        //When game is not over 
        if(catControls.gameOver == false) 
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        
        //If gameobject with bin tag is past the bound limit, destroy bin
        if(transform.position.x < bound && gameObject.CompareTag("bin"))
        {
            Destroy(gameObject);
        }
    }
}
