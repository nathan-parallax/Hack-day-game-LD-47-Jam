using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class KeyboardDesperate : MonoBehaviour
{
    SceneManagement self;
    
    // Start is called before the first frame update
    void Start()
    {
        self = GameObject.FindGameObjectWithTag("SceneM").GetComponent<SceneManagement>();

    }

    // Update is called once per frame
    void Update()
    {
        //Script place = gameObject.GetComponent<SceneManagement>();

        if (Input.GetKeyDown(KeyCode.J))
            {
           self.LoadRandomLevel();
            Destroy(self);
        }
        if (Input.GetKeyDown(KeyCode.K))
            {
           self.LoadCredits();
            Destroy(self);
        }
        if (Input.GetKeyDown(KeyCode.L))
            {
           self.QuitApp();
            Destroy(self);
        }

    }
}

