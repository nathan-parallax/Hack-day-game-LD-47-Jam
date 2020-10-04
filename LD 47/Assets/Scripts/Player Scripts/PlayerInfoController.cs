using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class PlayerInfoController : MonoBehaviour {

    int x = 0; //debugging purpose only

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (PlayerInfo.health <= 0) {
            //logic for game over
        }

    }
}
