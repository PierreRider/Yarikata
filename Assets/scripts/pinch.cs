using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pinch : MonoBehaviour
{

    public UnityEvent previous, next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // CONDITIONS FOR THE gestures
        //hand pinches for next
        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.Hands)){
                next.Invoke();
        }
        if (OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.Hands)){
                previous.Invoke();
        }

        if (Input.GetKeyDown("space"))
        {
            next.Invoke();
            print("Key pressed Space");
        }
    }
}
