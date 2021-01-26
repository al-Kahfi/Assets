using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Management : MonoBehaviour
{
    public void Scene_Main_Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Exit_Menu()
    {
        Application.Quit();
    }

    public void Scene_Eksterior_Rumah_1()
    {
        SceneManager.LoadScene("Eksterior_Rumah_1");
    }

    public void Scene_Interior_Rumah_1()
    {
        SceneManager.LoadScene("Interior_Rumah_1");
    }


    public void Scene_Eksterior_Rumah_2()
    {
        SceneManager.LoadScene("Eksterior_Rumah_2");
    }

    public void Scene_Interior_Rumah_2()
    {
        SceneManager.LoadScene("Interior_Rumah_2");
    }


    public void Scene_Eksterior_Rumah_3()
    {
        SceneManager.LoadScene("Eksterior_Rumah_3");
    }

    public void Scene_Interior_Rumah_3()
    {
        SceneManager.LoadScene("Interior_Rumah_3");
    }
}
