using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCan : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;

    public bool created = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (object1.transform.position.z > -7.5 && !created)
        {
            // Create object2 at the location of object2
            Instantiate(object2, object2.transform.position, object2.transform.rotation);
            created = true;
            // Print the location of object 2
        }
    }
}