using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeyController : MonoBehaviour
{
    public BoxCollider2D TopBox;
    public BoxCollider2D BottomBox;
    public BoxCollider2D LeftBox;
    public BoxCollider2D RightBox;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }
  /*  public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {

            if (tag == "Lava")
            {
                if (PlayerInfo.timeSinceLastTP > 2)
                {
                    PlayerInfo.health--;
                    StartCoroutine(Teleport());
                    PlayerInfo.timeSinceLastTP = 0;
                }
            }
            if (tag == "Floor")
            {
                tag = "SlimedFloor";
                //GetComponent<MeshRenderer>().material.color = Color.red;
                GetComponent<MeshRenderer>().sharedMaterial = Tile2;
            }

        }
    }*/
    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    { 
    
    }
}
