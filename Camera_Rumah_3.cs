using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Rumah_3 : MonoBehaviour
{
    public float y_Dapur= 1.6f;
    public float y_Kamar1 = 6.6f;
    public float y_Kamar2 = 11.6f;
    public float y_Kamar3 = 16.6f;
    public float y_Tamu = 21.6f;


    // floor 1
    public void Ruang_Dapur()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(-2, y_Dapur, 6.2f);
    }

    public void Ruang_Kamar1()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(-2.1f, y_Kamar1, 3.4f);
    }

    public void Ruang_Kamar2()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(-7, y_Kamar2, 2.5f);
    }

    public void Ruang_Kamar3()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(-7, y_Kamar3, 6);
    }

    public void Ruang_KamarMandi()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(0, 0, 10);
    }

    public void Ruang_Tamu()
    {
        var player = GameObject.Find("Camera Container");
        player.transform.position = new Vector3(-4.5f, y_Tamu, 6.7f);
    }

}
