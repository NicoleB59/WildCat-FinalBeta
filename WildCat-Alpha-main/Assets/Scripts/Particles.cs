
using UnityEngine;
using UnityEngine.SceneManagement;

public class Particles : MonoBehaviour
{
    public GameObject particleF;
    public GameObject particleE;


    // Start is called before the first frame update
    void Start()
    {

    }

    void PowerUp()
    {
        Instantiate(particleF, transform.position, particleF.transform.rotation);
    }

    void Explosion()
    {
        Instantiate(particleE, transform.position, particleF.transform.rotation);
    }

    // When the player hits the trash , detroy it, update score, and generate explosion
    private void OnCollisionEnter(Collision collision)
    {

        //If cat hits bin, cat gets destroyed, makes an explosion 
        if (collision.gameObject.CompareTag("bin"))
        {
            Destroy(gameObject);
            Explosion();

        }
        //If cat collects fish coin, fish coin gets destroyed, makes an explosion
        else if (collision.gameObject.CompareTag("fish"))
        {
            Destroy(collision.gameObject);
            PowerUp();
        }

        //If cat gets hit by trash, cat gets destroyed, makes a explosion
        else if (collision.gameObject.CompareTag("trash"))
        {
            Destroy(gameObject);
            Explosion();
        }
    }
}
