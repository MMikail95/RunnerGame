using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public Rigidbody rb;
    public float move;
    public float speed;
    public float maxX;
    public float minX;
    public GameManager gameManager;










    void Update()
    {
        if (gameManager.isGameStarted)
        {
            Vector3 playerPos = transform.position;
            playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);

            transform.position = playerPos;

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);

            }
        }





        //rigidbody.AddForce(0, 0, 1000f * Time.deltaTime);

    }


    private void FixedUpdate()
    {
        if (gameManager.isGameStarted)
        {
            rb.velocity = new Vector3(0, 0, move * Time.deltaTime);
        }

    }



}





