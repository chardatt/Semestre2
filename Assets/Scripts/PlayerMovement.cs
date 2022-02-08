using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    GameObject cameraCinemachine;
    CharacterController cc;
    public int speed = 5;
    public bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        cameraCinemachine = GameObject.FindObjectOfType<CinemachineVirtualCamera>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(canMove);
        if (canMove)
        {
            Vector3 direction = Vector3.zero;

            direction = Input.GetAxis("Horizontal") * cameraCinemachine.transform.right + Input.GetAxis("Vertical") * cameraCinemachine.transform.forward;
            direction.y = 0;
            direction.Normalize();
            Debug.DrawRay(transform.position, direction, Color.white, 10);
            transform.LookAt(direction);
            transform.eulerAngles = new Vector3(0, transform.rotation.y, 0);
            cc.Move(direction * Time.deltaTime * speed);
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (canMove)
                canMove = false;
        }
    }
}
