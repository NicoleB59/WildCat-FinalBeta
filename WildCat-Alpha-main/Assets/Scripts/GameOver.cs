using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    //Loads gameover scene
    public void scene_Gameover(string menu)
    {
        SceneManager.LoadScene(menu);
    }
}
