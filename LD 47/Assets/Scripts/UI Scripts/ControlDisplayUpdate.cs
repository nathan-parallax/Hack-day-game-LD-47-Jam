using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlDisplayUpdate : MonoBehaviour
{
    bool on;
    Color defaultCol;

    // Start is called before the first frame update
    void Start()
    {
        on = true;
        defaultCol = GetComponentInParent<Text>().color;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)) {
            if(on) {
                GetComponentInParent<Text>().color = Color.clear;
                on = false;
            }
            else {
                GetComponentInParent<Text>().color = defaultCol;
                on = true;
            }
        }
    }
}
