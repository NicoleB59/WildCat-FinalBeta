
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    //This method changes the scene. 
    public void scene_changer(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
