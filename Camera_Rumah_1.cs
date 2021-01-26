using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Rumah_1 : MonoBehaviour
{
    public float y_1 = 1.7f;
    public float y_2 = 6.7f;
    public float y_3 = 11.7f;

    // floor 1
    public void Ruang_1_1()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(0, y_1, 0);
    }

    public void Ruang_1_2()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(5, y_1, 0);
    }

    public void Ruang_1_3()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(0, y_1, 5);
    }

    public void Ruang_1_4()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(10, y_1, 0);
    }

    public void Ruang_1_5()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(0, y_1, 10);
    }

    // floor 2
    public void Ruang_2_1()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(0, y_2, 0);
    }

    public void Ruang_2_2()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(5, y_2, 0);
    }

    public void Ruang_2_3()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(0, y_2, 5);
    }

    public void Ruang_2_4()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(10, y_2, 0);
    }

    public void Ruang_2_5()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(0, y_2, 10);
    }

}
