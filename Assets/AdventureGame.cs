using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent; // SerializeField makes textcomponent available in Unity engine
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "hello world";

         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
