using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogManager : MonoBehaviour
{
    int State;
    GameObject sidePanel;
    Animator anim;

    public GameObject dialogObj;
    public GameObject nameText;
    public GameObject messageText;

    public GameObject nameTextInput;
    public GameObject messageTextInput;

    string nextName ="vv", nextMessage = "bb";

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OpenSidePanel()
    {

        if (State < 1)
        {
            State++; 
        }
        else
        {
            State = 0;
            dialogObj.SetActive(true);
        }
        anim.SetInteger("State", State);
    }

    public void hideDialog()
    {
        dialogObj.SetActive(false);
    }

    public void showDialog()
    {
        dialogObj.SetActive(true);
    }

    public void hideSpecs()
    {
        nameText.SetActive(false);
        messageText.SetActive(false);
    }

    public void showSpecs()//string _name, string _message)
    {
        //nameText.GetComponent<TextMeshProUGUI>().text = _name.ToString();
        // messageText.GetComponent<TextMeshProUGUI>().text = _name.ToString();

        nameText.GetComponent<TextMeshProUGUI>().text = nextName.ToString();
        messageText.GetComponent<TextMeshProUGUI>().text = nextMessage.ToString();

        nameText.SetActive(true);
        messageText.SetActive(true);
    }

    public void nextDialog(string _name, string _message)
    {
        nextName = _name.ToString();
        nextMessage = _name.ToString();
    }

    public void nextDialogInput()
    {
        nextName = nameTextInput.GetComponent<TextMeshProUGUI>().text.ToString();
        //nextMessage = messageTextInput.GetComponent<TextMeshProUGUI>().text.ToString();

        nextName = "dfsdfsfsd";
    }

}   
