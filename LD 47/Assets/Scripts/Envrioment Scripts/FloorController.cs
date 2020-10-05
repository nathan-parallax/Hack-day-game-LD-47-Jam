using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class FloorController : MonoBehaviour
{
    public GameObject Player;
    public GameObject SpawnPortal;
    public Material Tile1;
    public Material Tile2;
    //public Material Tile3;
    public GameObject CessPool;
    public AudioSource DeathSound;

    //public GameObject TileParent;
    private Transform Parent;
    

    private int lastScore;

    
    // Start is called before the first frame update
    void Start()
    {
        Parent = GetComponent<Transform>(); 
        lastScore = PlayerInfo.score;
        if(tag == "Lava") {
            //GetComponent<MeshRenderer>().material.color = Color.clear;
            //GetComponent<MeshRenderer>().sharedMaterial = Tile3;
            
            GameObject CessPooll = Instantiate(CessPool, Parent);
            //CessPooll.transform.parent = transform;
            //CessPooll.transform.z = -1;

            // CessPool.transform.parent = TileParent;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Transform Parent = transform.position;
        if (lastScore < PlayerInfo.score) { //if we have scored since last frame
            if(tag == "SlimedFloor") {
                tag = "Lava";
                GetComponent<BoxCollider2D>().isTrigger = true;
                //GetComponent<MeshRenderer>().material.color = Color.clear;
                //GetComponent<MeshRenderer>().sharedMaterial = Tile3;

                GameObject CessPooll = Instantiate(CessPool, Parent);
                //CessPooll.transform.parent = transform;
                //CessPooll.transform.z = -1;

                // CessPool.transform.parent = TileParent;
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
                    DeathSound.Play();
                    PlayerInfo.timeSinceLastTP = 0;
                }
            }
            if(tag == "Floor") {
                tag = "SlimedFloor";
                //GetComponent<MeshRenderer>().material.color = Color.red;
                GetComponent<MeshRenderer>().sharedMaterial = Tile2;
            }

        }
    }

    IEnumerator Teleport() {
        yield return new WaitForSeconds(0);
        Player.transform.position = new Vector2(SpawnPortal.transform.position.x, SpawnPortal.transform.position.y);
    }
}
