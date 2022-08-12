using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollison : MonoBehaviour
{
    [SerializeField] private float _scaleFactor;
    public PlayerScript playerScript;
    public Score score;
    public Rigidbody rb;
    public UIManager uiManager;
    public GameManager gameManager;



    private void OnTriggerEnter(Collider other)
    {


        Debug.Log("on trigger enter");

        if (other.CompareTag("Collectables"))
        {


            if (GetComponent<Renderer>().material.color == other.GetComponent<Renderer>().material.color)
            {
                Debug.Log("Ayni renk");
                score.AddScore(1);
                transform.localScale += Vector3.one * _scaleFactor;
                Destroy(other.gameObject);
            }
            if (GetComponent<Renderer>().material.color != other.GetComponent<Renderer>().material.color)
            {
                Debug.Log("farkli renk");
                GetComponent<Renderer>().material.color = other.GetComponent<Renderer>().material.color;
                score.DeleteScore(0);
                transform.localScale = Vector3.one;

            }



        }



    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Obstacles"))
        {
            transform.position = new Vector3(0, 0, 0);
            gameManager.EndGame(false);
        }

        if (collision.gameObject.name == ("Ender"))
        {

            gameManager.NextGame();
           
        }
    }
        
        
       
    

}