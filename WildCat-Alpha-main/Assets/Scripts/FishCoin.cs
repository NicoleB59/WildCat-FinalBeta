using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCoin : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        //When fish collides with object with tag, score is added by 1
        if(other.gameObject.tag == "Cat")
        {
            ScoreBoard.score += 1;
        }
    }
}
