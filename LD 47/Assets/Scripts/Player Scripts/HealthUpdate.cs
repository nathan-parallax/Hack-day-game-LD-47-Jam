﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthUpdate : MonoBehaviour
{
    int lastHealth;
    int maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        lastHealth = PlayerInfo.health;
        maxHealth = lastHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInfo.health != lastHealth) {
            GetComponentInParent<Slider>().value = (100/maxHealth) * PlayerInfo.health;
            lastHealth = PlayerInfo.health;
        }
    }

}
