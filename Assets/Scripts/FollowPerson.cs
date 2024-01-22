using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPerson : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0f, 2f, -5f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;

        Quaternion desiredRotation = Quaternion.Euler(target.eulerAngles.x, target.eulerAngles.y, 0f);

        transform.rotation = desiredRotation;
    }
}
