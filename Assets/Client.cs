using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
   // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            IRifle rifle = new BasicRifle();
            Debug.Log("Basic Accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("s"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(rifle);
            Debug.Log("With Scope: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("d"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(new WithStabilizer(rifle));
            Debug.Log("With Scope and Stabilizer: " + rifle.GetAccuracy());
        }
        if (Input.GetKeyDown("f"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithStock(new WithScope(new WithStabilizer(rifle)));
            Debug.Log("With Scope, Stabilizer and Stock: " + rifle.GetAccuracy());
        }
        if (Input.GetKeyDown("g"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithLaser(new WithStock(new WithScope(new WithStabilizer(rifle))));
            Debug.Log("With Scope, Stabilizer, Stock, and Laser: " + rifle.GetAccuracy());
        }
    }
}
