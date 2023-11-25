using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float TurningSpeed;
    public GameObject PlayerMesh;
    public Camera Playercam;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int Offset = 0;
    // Update is called once per frame
    void Update()
    {
        int axis = (int)Input.GetAxis("Horizontal");
        if(axis == 1)
        {
            Offset = 5;
        }
        else if(axis == -1)
        {
            Offset = -5;
        }
        else
        {
            Offset = 0;
        }
        PlayerMesh.transform.position = Vector3.Lerp(PlayerMesh.transform.position, new Vector3(Offset, PlayerMesh.transform.position.y, PlayerMesh.transform.position.z), TurningSpeed * Time.deltaTime * 100);
        Playercam.transform.position = Vector3.Lerp(Playercam.transform.position, new Vector3(Offset, Playercam.transform.position.y, Playercam.transform.position.z), TurningSpeed * Time.deltaTime * 100);
    }
}
