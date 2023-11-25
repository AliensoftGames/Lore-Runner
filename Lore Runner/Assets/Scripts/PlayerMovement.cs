using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float TurningSpeed;
    public GameObject PlayerMesh;
    public Camera Playercam;
    public float JumpForce = 0;
    bool IsJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float Offset = 0;
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
        if (Input.GetButtonDown("Jump") && IsJumping)
        {
            PlayerMesh.GetComponent<Rigidbody>().AddForce(Vector3.up * JumpForce * 100 * Time.deltaTime, ForceMode.Impulse);
            
        }
        Offset = Mathf.Clamp(Offset, -5, 5);
        PlayerMesh.transform.position = Vector3.Lerp(PlayerMesh.transform.position, new Vector3(Offset, PlayerMesh.transform.position.y, PlayerMesh.transform.position.z), TurningSpeed * Time.deltaTime * 100);
        Playercam.transform.position = Vector3.Lerp(Playercam.transform.position, new Vector3(Offset, Playercam.transform.position.y, Playercam.transform.position.z), TurningSpeed * Time.deltaTime * 100);
    }
    void OnCollisionEnter(Collision collision)
    {
        PlayerMesh.GetComponent<Rigidbody>().velocity = Vector3.zero;
        IsJumping = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        IsJumping = false;
    }
}
