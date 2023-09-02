using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SPlayer(int sceneID)
    {
        Singleton.Instance.IsPlayerFriend=false;
        Singleton.Instance.IsPlayer1=true;
        SceneManager.LoadScene(sceneID);
    }
    public void TPlayer(int sceneID)
    {
        Singleton.Instance.IsPlayer1=false;
        SceneManager.LoadScene(sceneID);
    }
    public void Friend(int sceneID)
    {
        Singleton.Instance.IsPlayerFriend=true;
        SceneManager.LoadScene(sceneID);
    }
    public void Foe(int sceneID)
    {
        Singleton.Instance.dif2=false;
        Singleton.Instance.dif1=true;
        Singleton.Instance.IsPlayerFriend=false;
        SceneManager.LoadScene(sceneID);
    }
    public void Red(int sceneID)
    {
        Singleton.Instance.colp1=Color.red;
        SceneManager.LoadScene(sceneID);
    }
    public void Blue(int sceneID)
    {
        Singleton.Instance.colp1=Color.blue;
        SceneManager.LoadScene(sceneID);
    }
    public void Green(int sceneID)
    {
        Singleton.Instance.colp1=Color.green;
        SceneManager.LoadScene(sceneID);
    }
    public void Yellow(int sceneID)
    {
        Singleton.Instance.colp1=Color.yellow;
        SceneManager.LoadScene(sceneID);
    }
    public void Easy(int sceneID)
    {
        Singleton.Instance.dif1=true;
        Singleton.Instance.dif2=true;
        SceneManager.LoadScene(sceneID);
    }
    public void Hard(int sceneID)
    {
        Singleton.Instance.dif1=false;
        Singleton.Instance.dif2=true;
        SceneManager.LoadScene(sceneID);
    }
    public void Extreme(int sceneID)
    {
        Singleton.Instance.dif1=false;
        Singleton.Instance.dif2=false;
        SceneManager.LoadScene(sceneID);
    }
    public void Medium(int sceneID)
    {
        Singleton.Instance.dif1=true;
        Singleton.Instance.dif2=false;
        SceneManager.LoadScene(sceneID);
    }
    public void Back(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void BackSpec()
    {
        if(Singleton.Instance.IsPlayer1)
        {SceneManager.LoadScene(1);}
        else
        {
            SceneManager.LoadScene(2);
        }
    }
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void Red2(int sceneID)
    {
        Singleton.Instance.colp2=Color.red;
        SceneManager.LoadScene(sceneID);
    }
    public void Blue2(int sceneID)
    {
        Singleton.Instance.colp2=Color.blue;
        SceneManager.LoadScene(sceneID);
    }
    public void Green2(int sceneID)
    {
        Singleton.Instance.colp2=Color.green;
        SceneManager.LoadScene(sceneID);
    }
    public void Yellow2(int sceneID)
    {
        Singleton.Instance.colp2=Color.yellow;
        SceneManager.LoadScene(sceneID);
    }
    public void Menu(int sceneID)
    {
        Singleton.Instance.dif2=false;
        Singleton.Instance.dif1=true;
        SceneManager.LoadScene(sceneID);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
