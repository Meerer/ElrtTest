using UnityEngine;
using System.Collections;
using System;

public class movementTestOnline : MonoBehaviour
{
    public Vector3 targetPos = Vector2.zero;
    public float speed = 1.5f;
    void Start()
    {
        targetPos = this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPos.z = 0;

        }
        moveOnTarget();
    }
    public void moveOnTarget()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, targetPos, speed * Time.deltaTime);
    }

}
