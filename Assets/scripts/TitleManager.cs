using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    int State;
    GameObject sidePanel;
    Animator anim;

    public GameObject sobre;
    public GameObject comoJogar;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OpenSidePanel()
    {

        if(State < 1)
        {
            State++;
            sobre.SetActive(true);
            comoJogar.SetActive(false);
        }
        else
        {
            State = 0;
            sobre.SetActive(false);

        }
        anim.SetInteger("State", State);
    }

    public void OpenSidePanel2()
    {
        if (State < 1)
        {
            State++;
            comoJogar.SetActive(true);
            sobre.SetActive(false);
        }
        else
        {
            State = 0;
            
            comoJogar.SetActive(false);
        }
        anim.SetInteger("State", State);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("fase 1");
    }


}
