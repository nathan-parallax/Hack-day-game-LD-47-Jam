/**************************************************************************************
 * Idea derived from http://www.cloudywatergames.com/2018/05/01/unity-2d-sprite-trail/
 * Created      10/3/20 2:30a by Dillon Buchanan
 * Last Edit    10/3/20 3:00a by Dillon Buchanan
 *************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailObject : MonoBehaviour
{
    public SpriteRenderer mRenderer;
    public Color mColor;

    private bool mbInUse;
    private Vector2 mPosition;
    private Trail mSpawner;

    // Start is called before the first frame update
    void Start()
    {
        //don't enable at start
        mRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (mbInUse) {
            transform.position = mPosition;

            mRenderer.color = mColor;

        }

        }

    public void Initiate(Sprite sprite, Vector2 position, Trail trail) {

        mRenderer.sprite = sprite;
        mRenderer.enabled = true;
        mPosition = position;
        mSpawner = trail;
        mbInUse = true;

    }

}
