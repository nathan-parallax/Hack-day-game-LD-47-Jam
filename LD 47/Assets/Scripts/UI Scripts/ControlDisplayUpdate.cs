using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlDisplayUpdate : MonoBehaviour
{
    bool on;
    public GameObject Key1;
    public GameObject Key2;
    public GameObject Key3;
    public GameObject Key4;
    public GameObject Key5;
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
                Key1.SetActive(on);
                Key2.SetActive(on);
                Key3.SetActive(on);
                Key4.SetActive(on);
                Key5.SetActive(on);
               }
            else {
                GetComponentInParent<Text>().color = defaultCol;
                on = true;
                Key1.SetActive(on);
                Key2.SetActive(on);
                Key3.SetActive(on);
                Key4.SetActive(on);
                Key5.SetActive(on);
            }
        }
    }
}
