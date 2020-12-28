using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{

    [TextArea(10, 14)] [SerializeField] string storyText; // TextArea() generates a text area to write in and defines it size in brackets

    public string GetStateStory()
    {
        return storyText;
    }

}
