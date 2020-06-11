using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour {
  /*  public Button Level01Button, Level02Button, Level03Button, Level04Button, Level05Button, Level06Button;
    void Start()
    {
        Level01Button.interactable = true;
        Level02Button.interactable = false;
        Level03Button.interactable = false;
        Level04Button.interactable = false;
        Level05Button.interactable = false;
        Level06Button.interactable = false;

    }
    public void LevelMan(int n)
    {
        switch (n)
        {
            case 1:
                Level02Button.interactable = true;
                break;
            case 2:
                Level03Button.interactable = true;
                break;
            case 3:
                Level04Button.interactable = true;
                break;
            case 4:
                Level05Button.interactable = true;
                break;
            case 5:
                Level06Button.interactable = true;
                break;
            case 6:
                Level06Button.interactable = true;
                break;
        }
    }*/
    public void GetInput(string answer)
    {
        if(answer=="HANDBOOK")
        {
            SceneManager.LoadScene(1);
       //     Level02Button.interactable = true;
        }
            
        else if(answer == "BSCITDEPARTMENT")
        {
            SceneManager.LoadScene(2);
         //   Level03Button.interactable = true;

        }
           
        else if (answer == "MONALISA")
        {
            SceneManager.LoadScene(3);
           // Level04Button.interactable = true;
        }
            
        else if (answer == "WELLNESSCENTRE")
        {
            SceneManager.LoadScene(4);
           // Level05Button.interactable = true;
        }
            
        else if (answer == "AWARDS")
        {
            SceneManager.LoadScene(5);
           // Level06Button.interactable = true;
        }
            
        else if (answer == "REFERENCELIBRARY")
        {
            SceneManager.LoadScene(6);
        }
            
        
    }
}
