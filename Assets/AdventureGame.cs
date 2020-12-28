using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent; // SerializeField makes textcomponent available in Unity engine
    // Start is called before the first frame update
    [SerializeField] State startingState;

    State state;

    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();

         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
