using System.Collections;
using System.Collections.Generic;
using System.Timers;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class PlayerMovement : MonoBehaviour
{
    public float TurningSpeed;
    public GameObject PlayerMesh;
    public Camera Playercam;
    public float JumpForce;
    public float DistBetweenFingers = 0f;
    public float DistBetweenFingersY = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float Offset = 0;
    bool CanJump = false;
    Vector2 StartPos;
    Vector2 EndPos;
    // Update is called once per frame
    void Update()
    {
        float DistanceOfPointsX = 0f;
        float DistanceOfPointsY = 0f;
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            StartPos = Input.GetTouch(0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            EndPos = Input.GetTouch(0).position;
            DistanceOfPointsX = StartPos.normalized.x - EndPos.normalized.x;
            DistanceOfPointsY = StartPos.y - EndPos.y; 
            Debug.Log(StartPos);
            Debug.Log(EndPos);
        }

        if (DistanceOfPointsY < DistBetweenFingersY * -1 && CanJump)
        {
            PlayerMesh.GetComponent<Rigidbody>().velocity = Vector3.up * JumpForce;
            CanJump = false;
            DistanceOfPointsX = 0f;
        }
        if (DistanceOfPointsX < DistBetweenFingers * -1)
        {
            Offset += 5;
        }
        if(DistanceOfPointsX > DistBetweenFingers)
        {
            Offset -= 5;
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
