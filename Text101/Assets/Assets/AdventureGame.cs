using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State StartingState;

    State state;

    void Start()
    {
       state = StartingState;
       textComponent.text = state.GetStateStory();
    }

    void Update() 
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
            Debug.Log("Pressed 1");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
            Debug.Log("Pressed 2");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
            Debug.Log("Pressed 3");
        }
        textComponent.text = state.GetStateStory();
    }
}
