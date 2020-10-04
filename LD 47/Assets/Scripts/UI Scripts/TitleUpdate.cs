using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        //add logic here to detect what level we got and set the correpsonding title
        PlayerInfo.levelTitle = "Default Title";
        GetComponentInParent<Text>().text = PlayerInfo.levelTitle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
