using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class stateMachineScript : MonoBehaviour
{

    public Animator[] animations;
    int state = 0 ;

    public void Next(){
        if (animations[state] != null)
            animations[state].gameObject.SetActive(false);

        state++;
            
        if (state > animations.Length){
                
            state = 0;
                
        }

        if (animations[state] != null)
        {

            animations[state].gameObject.SetActive(true);
            //animations[state].StartPlayback();
            //animations[state].Play("1");
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
