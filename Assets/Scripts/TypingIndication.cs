using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypingIndication : MonoBehaviour
{
    public GameObject dialogueImage;
    public bool playerIn = false;
    public bool on = false;
    public void On()
    {
        
    }

    public void Off()
    {

    }

    public void IndicationOfDialogue()
    {
        dialogueImage.SetActive(true);
        playerIn = true;
    }

    public void IndicationOfDialogueOff()
    {
        dialogueImage.SetActive(false);
        playerIn = false;
    }
}
