using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTrap : MonoBehaviour
{
    public float speed;
    public int startPoint;
    public Transform[] points;
    [SerializeField] private int transformIndex;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[startPoint].position; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position,points[transformIndex].position)<0.1f)
        {
            transformIndex++;

            if(transformIndex==points.Length)
            {
                transformIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position , points[transformIndex].position,speed*Time.deltaTime);
    }
}
