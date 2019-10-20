using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogManager : MonoBehaviour
{
    int State;
    GameObject sidePanel;
    Animator anim;

    public GameObject dialogObj;
    public GameObject nameText;
    public GameObject MessageText;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OpenSidePanel()
    {

        if(State < 1)
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
        MessageText.SetActive(false);
    }

    public void showSpecs()
    {
        nameText.SetActive(true);
        MessageText.SetActive(true);
    }


}
