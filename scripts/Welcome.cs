using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Chapter1{
public class Welcome: MonoBehaviour
{

    private string myMessage = "Welcome";
    private Text Textwelcome;
    public GameObject canvasWelcome;

    // Start is called before the first frame update
    void Start()
    {
        SetInitalReferences();
        MyWelcomeMessage();
    }

    void SetInitalReferences()
    {
        Textwelcome = GameObject.Find("Textwelcome").GetComponent<Text>();
    
}


    void MyWelcomeMessage()
    {
        if(Textwelcome != null)
        {
             Textwelcome.text = myMessage;    
        }


        else
        {
            Debug.LogWarning("WelcomeText not assinged.");
        }

        
        Invoke("DisableCanvas",4.5f);
    }

    void DisableCanvas(){
        canvasWelcome.SetActive(false);
    }
       
    

   

}

}