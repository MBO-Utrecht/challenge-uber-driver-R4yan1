using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSharpt : MonoBehaviour
{
    public float speed = 1.0f;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float throttle = Input.GetAxis("Vertical");
        float steer = Input.GetAxis("Horizontal");
        //Debug.Log(throttle);
       transform.Translate(0,throttle * speed * Time.deltaTime,0); 
       transform.Rotate (0,0,-steer * 100 * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collided with " + col.gameObject.name);
        if(col.gameObject.name == "Pakketje"){
            score = score + 1;
            Destroy(col.gameObject);
        }
    }
}
