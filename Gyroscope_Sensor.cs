using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyroscope_Sensor : MonoBehaviour
{
    private bool Gyro_Enabled;
    private Gyroscope Gyro;
    private GameObject Camera_Container;
    private Quaternion Rotation;

    private void Start()
    {
        Camera_Container = new GameObject("Camera Container");
        Camera_Container.transform.position = transform.position;
        transform.SetParent(Camera_Container.transform);
        Gyro_Enabled = Activate_Gyro();
    }

    private bool Activate_Gyro()
    {
        if(SystemInfo.supportsGyroscope)
        {
            Gyro = Input.gyro;
            Gyro.enabled = true;

            Camera_Container.transform.rotation = Quaternion.Euler(90f, 90f, 90f);
            Rotation = new Quaternion(0, 0, 1, 0);

            return true;
        }

        return false;
    }

    private void Update()
    {
        if (Gyro_Enabled)
        {
            transform.localRotation = Gyro.attitude * Rotation;
        }
    }

}
