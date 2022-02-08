using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExampleScript : MonoBehaviour
{
    public Text  gt;
    PlayerMovement playerMovement;
    bool canWrite = false;
    void Start()
    {
        gt = GetComponent<Text>();
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (canWrite == false)
                canWrite = true;
        }
        if (playerMovement.canMove == false && canWrite)
        {
            foreach (char c in Input.inputString)
            {
                if (c == '\b') // has backspace/delete been pressed?
                {
                    if (gt.text.Length != 0)
                    {
                        gt.text = gt.text.Substring(0, gt.text.Length - 1);
                    }
                }
                else if ((c == '\r') || (c == '\n')) // enter/return
                {
                    //print("r");
                    canWrite = false;
                    print("User entered: " + gt.text);
                    gt.text = null;
                    playerMovement.canMove = true;
                }
                else
                {
                    gt.text += c;
                }
            }
        }
    }
}