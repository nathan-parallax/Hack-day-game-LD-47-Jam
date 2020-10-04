using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FloorController : MonoBehaviour
{
    public GameObject Player;
    public GameObject SpawnPortal;

    private int lastScore;
    
    // Start is called before the first frame update
    void Start()
    {
        lastScore = PlayerInfo.score;
        if(tag == "Lava") {
            GetComponent<MeshRenderer>().material.color = Color.clear;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(lastScore < PlayerInfo.score) { //if we have scored since last frame
            if(tag == "SlimedFloor") {
                tag = "Lava";
                GetComponent<BoxCollider2D>().isTrigger = true;
                GetComponent<MeshRenderer>().material.color = Color.clear;
            }
            lastScore = PlayerInfo.score;
        }
    }

    public void OnTriggerEnter2D(Collider2D other) {
        
        if (other.gameObject.tag == "Player") {
            
            if(tag == "Lava") {
                if (PlayerInfo.timeSinceLastTP > 2) {
                    PlayerInfo.health--;
                    StartCoroutine(Teleport());
                    PlayerInfo.timeSinceLastTP = 0;
                }
            }
            if(tag == "Floor") {
                tag = "SlimedFloor";
                GetComponent<MeshRenderer>().material.color = Color.red;
            }

        }
    }

    IEnumerator Teleport() {
        yield return new WaitForSeconds(0);
        Player.transform.position = new Vector2(SpawnPortal.transform.position.x, SpawnPortal.transform.position.y);
    }
}
