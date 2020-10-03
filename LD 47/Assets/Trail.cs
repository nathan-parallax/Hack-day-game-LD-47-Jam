/**************************************************************************************
 * Idea derived from http://www.cloudywatergames.com/2018/05/01/unity-2d-sprite-trail/
 * Created      10/3/20 2:30a by Dillon Buchanan
 * Last Edit    10/3/20 3:00a by Dillon Buchanan
 *************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
       
    public SpriteRenderer mLeadingSprite;
    public GameObject mTrailObject;

    //these will control how often a sprite for the trail spawn
    public float mTrailSpawnInterval;
    private float mSpawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        mSpawnTimer += Time.deltaTime;

        if(mSpawnTimer >= mTrailSpawnInterval) { //if enough time has passed to warrant another spawn

            GameObject trail = GameObject.Instantiate(mTrailObject);
            trail.transform.SetParent(transform);

            TrailObject tObj = trail.GetComponent<TrailObject>();

            tObj.Initiate(mLeadingSprite.sprite, transform.position, this);

            //set timer back to 0
            mSpawnTimer = 0;

        }

    }
}
