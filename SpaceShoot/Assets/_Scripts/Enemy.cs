using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Enemy : MonoBehaviour
{
    public float speed = 10f; // 10m/s
    public float fireRate = 0.3f; // 3 shots per second (unused for now)
    public float health = 10; // hit points
    public int score = 100; // points earned for destroying this

    public Vector3 pos
    {
        get { return this.transform.position; } 
        set { this.transform.position = value; }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public virtual void Move()
    {
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime;
        pos = tempPos;
    }

}
