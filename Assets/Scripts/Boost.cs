﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boost : MonoBehaviour
{
    public GameObject player;
	public GameObject booster;
	public Animator anim;
	
    // Start is called before the first frame update
    void Start()
    {
		anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.D))
        {
			anim.Play("player_boost");
        }
		
		if (Input.GetKeyUp(KeyCode.D))
		{
            anim.Play("player_boost_idle");
        }
	}
}