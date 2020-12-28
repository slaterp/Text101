using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{

    [TextArea(10, 14)] [SerializeField] string storyText; // TextArea() generates a text area to write in and defines it size in brackets

    [SerializeField] State[] nextStates; // Serializing makes this editable in GUI. Eg. you can go to the starting states component and edit the nextStates array directly from there :)

    public string GetStateStory()
    {
        return storyText;
    }
    
    public State[] GetNextStates()
    {
        return nextStates;
    }

}
