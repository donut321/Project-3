using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleFlight : MonoBehaviour
{
	public GameObject drone;
    public float speed = 1.0f;
	public int frames = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	   // Move forward on x axis
		drone.transform.Translate(Vector3.left * speed * Time.deltaTime);
		if (frames == 1000)
        {
            drone.transform.Rotate(0, 180, 0);
            frames = 0;
        }
		frames++;
    }
}
