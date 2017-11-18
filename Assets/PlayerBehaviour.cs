﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    bool hasCollided = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        keyboardBehaviour();
    }

    public bool GetHasCollided()
    {
        return hasCollided;
    }


    void keyboardBehaviour()
    {
        Vector3 v = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector2 playerPos = v;
        Collider2D hitCollider = Physics2D.OverlapPoint(playerPos);

        if (hitCollider)
        {
            if (hitCollider.gameObject.transform.tag.Equals("Enemy"))
                if(Input.GetKeyDown("up"))
                    {
                        Debug.Log("hit");
                        Destroy(hitCollider.gameObject);
                    }
        }
    }
        
}

