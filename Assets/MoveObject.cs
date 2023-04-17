using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private Vector3 pos;
    private float movementspeed = 5f;
    public GameObject Point1;

    

    void Start()
    {


    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
             pos = new Vector3(Random.Range(-5, 5), Random.Range(4, -4), 0f);//new random point generated
              Point1.transform.position = pos;// gameObject position change to new random position
             transform.up = pos - transform.position;// while transfer timing , also Game Object rotate the direction.
           // GetRandomPosOffScreen();
           //

        }
        transform.position = Vector3.Lerp(transform.position, Point1.transform.position, movementspeed * Time.deltaTime);

    }
    /*private Vector3 GetRandomPosOffScreen()
        {

            float x = Random.Range(-0.2f, 0.2f);
            float y = Random.Range(-0.2f, 0.2f);
            x += Mathf.Sign(x);
            y += Mathf.Sign(y);
            Vector3 randomPoint = new(x, y);

            randomPoint.z = 10f; // set this to whatever you want the distance of the point from the camera to be. Default for a 2D game would be 10.
            Vector3 worldPoint = Camera.main.ViewportToWorldPoint(randomPoint);

            return worldPoint;
        }*/
}