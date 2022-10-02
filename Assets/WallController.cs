using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeToPlayer;
    private float velocityZ;

    private float dist;
    public GameObject floor;
    void Start()
    {
        dist = floor.transform.localScale.z;
        print(dist);
        velocityZ = dist / (timeToPlayer * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.0f, 0.0f, -0.2f);
        if (transform.position.z < 50) {
            transform.position = new Vector3(transform.position.x, transform.position.y, 250);
            print("hello beany");
        }
    }
}
