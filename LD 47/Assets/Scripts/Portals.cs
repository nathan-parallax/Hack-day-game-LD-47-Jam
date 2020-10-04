using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals : MonoBehaviour
{

    public GameObject Destination;
    public GameObject Player;
    public AudioSource PortalSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInfo.timeSinceLastTP += Time.deltaTime;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (Destination == null) return;

        if (other.gameObject.tag == "Player")
        {
            if (PlayerInfo.timeSinceLastTP > 2) {
                StartCoroutine(Teleport());
                PlayerInfo.timeSinceLastTP = 0;
                PortalSound.Play();
            }
        }
    }

    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(0);
        Player.transform.position = new Vector2(Destination.transform.position.x, Destination.transform.position.y);

        //if we teleport we also get a point, and we change slimed blocks to lava
        PlayerInfo.score++;
    }
}
