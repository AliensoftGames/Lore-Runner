using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform Target;
    public float Offset;
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3(Target.position.x, Target.position.y - Offset, Target.position.z));

    }
}
