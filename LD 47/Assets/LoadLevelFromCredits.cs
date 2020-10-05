using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelFromCredits : MonoBehaviour
{
    public GameObject self;
    public int CountUp = 0;
    public AudioSource audjj;
    // Start is called before the first frame update
    void Start()
    {
        CountUp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        CountUp++;
        //GetComponent<Text>().text = CountUp;
        if (CountUp == 7000)
        {
            
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene("Main Menu");
            Destroy(self);
        }
        if (CountUp == 10000)
        {
            //SceneManager.LoadScene("Main Menu");
            //Application.LoadLevel(0);
        }
    }
}


