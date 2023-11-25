using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float TurningSpeed;
    public GameObject PlayerMesh;
    public Camera Playercam;
    public float JumpForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float Offset = 0;
    bool CanJump = false;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.A))
        {
            Offset -= 5;
        }
        else if(Input.GetKeyUp(KeyCode.D))
        {
            Offset += 5;
        }
        if (Input.GetButtonDown("Jump") && CanJump)
        {
            PlayerMesh.GetComponent<Rigidbody>().velocity = Vector3.up * JumpForce;
            CanJump = false;
        }
        Offset = Mathf.Clamp(Offset, -5, 5);
        if(PlayerMesh.GetComponent<Rigidbody>().velocity.y > 0)
        {
            PlayerMesh.GetComponent<Rigidbody>().velocity -= new Vector3(0, 0.01f, 0);
        }
        PlayerMesh.transform.localPosition = new Vector3(Mathf.Lerp(PlayerMesh.transform.localPosition.x, Offset, TurningSpeed * Time.deltaTime * 100), PlayerMesh.transform.localPosition.y, PlayerMesh.transform.localPosition.z);
        Playercam.transform.position = Vector3.Lerp(Playercam.transform.position, new Vector3(Offset, Playercam.transform.position.y, Playercam.transform.position.z), TurningSpeed * Time.deltaTime * 100);
    }
    private void OnCollisionEnter(Collision collision)
    {
        CanJump = true;
    }
}
