using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class stateMachineScript : MonoBehaviour
{

    public Animator[] animations;
    int state = 0 ;

    public void Next(){
            
             animations[state].StartPlayback();
            state++;

            if (state > animations.Length){
                
                state = 0;
                
            }
            
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
