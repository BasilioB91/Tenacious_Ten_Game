﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {


    public LevelManager levelManager;   //creates empty level manager of type level manager

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>(); //finds any object in the scene that has level manager in it
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            levelManager.RespawnPlayer();
        }
    }
}
