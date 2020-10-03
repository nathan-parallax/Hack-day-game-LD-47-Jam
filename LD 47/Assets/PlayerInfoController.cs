using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class PlayerInfoController : MonoBehaviour
{

    int x = 0; //debugging purpose only

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(x % 60 == 0) { //edit logic for collision on exit portal

            PlayerInfo.score++;

        }

        if(x % 240 == 0) { //edit logic for damage collision

            PlayerInfo.health--;

            if(PlayerInfo.health <= 0) {
                PlayerInfo.gameOver = true;
            }

        }
        x++;
    }
}
