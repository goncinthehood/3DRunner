using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAnimation : MonoBehaviour
{
    public float speed = 1f;
    public float strength = 2.5f;
    public float randomOffSet;
    void Start()
    {
        randomOffSet = Random.Range(-2.5f, 2.5f);
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Sin(Time.time * speed +randomOffSet) * strength;
        transform.position = pos;
    }
}
