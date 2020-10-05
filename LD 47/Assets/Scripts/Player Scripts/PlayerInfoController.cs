using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInfoController : MonoBehaviour {

    //int x = 0; //debugging purpose only
    //public GameObject Slimey;
    // Start is called before the first frame update
    void Start() {

    }
    public void OnTriggerEnter2D(Collider2D other)
    { 
    
    }
    // Update is called once per frame
    void Update() {

        if (PlayerInfo.health <= 0) {
            PlayerInfo.finalTime = gameObject.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>().text;
            SceneManager.LoadScene("GameOver");
        }
        /*if (Debug.isDebugBuild && Input.GetKeyDown(KeyCode.RightShift))
        {
            SceneManagement.LoadRandomLevel();
        }*/
    }
}
