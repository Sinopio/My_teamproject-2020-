using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager_Scripts : MonoBehaviour
{
    public InputField Name_Input;
    public InputField PassWord_Input;

    bool ID;
    bool PW;

    // Start is called before the first frame update
    void Start()
    {
        ID = false;
        PW = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void D_Slime()
    {
        Destroy(GameObject.FindWithTag("Slime"));
    }

    public void D_Turtle()
    {
        Destroy(GameObject.FindWithTag("Turtle"));
    }

   public void Check_ID()
    {
        if(Name_Input.text == "TeamProject")
        {
            Debug.Log("ID가 일치합니다.");
            ID = true;
        }

        if (Name_Input.text != "TeamProject")
        {
            Debug.Log("ID가 일치하지 않습니다..");
            ID = false;
        }
    }

    public void Check_PW()
    {
        if (PassWord_Input.text == "1234")
        {
            Debug.Log("PW가 일치합니다.");
            PW = true;
        }

        if (PassWord_Input.text != "1234")
        {
            Debug.Log("PW가 일치하지 않습니다..");
            PW = false;
        }
    }

    public void Next_Scene()
    {

        if(ID && PW)
        {
            Debug.Log("ID, PW가 일치하여 메인씬으로 이동합니다.");
            SceneManager.LoadScene(1);
        }
    }
}
