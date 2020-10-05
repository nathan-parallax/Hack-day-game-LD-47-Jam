using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponentInParent<Text>().text = $"Game Over\nLevel Name: {PlayerInfo.levelTitle}\nScore: {PlayerInfo.score}\nESC to Exit";
        if(Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit(0);
        }
    }
}
