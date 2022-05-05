using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteBehaviour : MonoBehaviour
{

    public Transform movePoint;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, movePoint.position) >= 0f)
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoint.position, speed * Time.deltaTime);
        }
    }
}
