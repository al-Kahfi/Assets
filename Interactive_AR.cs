using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Interactive_AR : MonoBehaviour
{
    public float Scaling_Speed = 0.03f;
    public float Rotation_Speed = 70.0f;

    bool Repeat_Scale_Up = false;
    bool Repeat_Scale_Down = false;

    bool Repeat_Rotate_Up = false;
    bool Repeat_Rotate_Down = false;
    bool Repeat_Rotate_Left = false;
    bool Repeat_Rotate_Right = false;

    void Update()
    {
        if (Repeat_Scale_Up)
        {
            Scale_Up_Button();
        }

        if (Repeat_Scale_Down)
        {
            Scale_Down_Button();
        }


        if (Repeat_Rotate_Up)
        {
            Rotation_Up_Button();
        }

        if (Repeat_Rotate_Down)
        {
            Rotation_Down_Button();
        }

        if (Repeat_Rotate_Left)
        {
            Rotation_Left_Button();
        }

        if (Repeat_Rotate_Right)
        {
            Rotation_Right_Button();
        }

    }


        public void Scale_Up_Button()
        {
            GameObject.FindWithTag("Model").transform.localScale += new Vector3(Scaling_Speed, Scaling_Speed, Scaling_Speed);
        }
        public void Scale_Up_Button_Repeat()
        {
            Repeat_Scale_Up = true;
        }
        public void Scale_Up_Button_Off()
        {
            Repeat_Scale_Up = false;
        }

        public void Scale_Down_Button()
        {
            GameObject.FindWithTag("Model").transform.localScale += new Vector3(-Scaling_Speed, -Scaling_Speed, -Scaling_Speed);
        }
        public void Scale_Down_Button_Repeat()
        {
            Repeat_Scale_Down = true;
        }
        public void Scale_Down_Button_Off()
        {
            Repeat_Scale_Down = false;
        }


        public void Rotation_Up_Button()
        {
            GameObject.FindWithTag("Model").transform.Rotate(Rotation_Speed * Time.deltaTime, 0, 0);
        }
        public void Rotation_Up_Button_Repeat()
        {
            Repeat_Rotate_Up = true;
        }
        public void Rotation_Up_Button_Off()
        {
            Repeat_Rotate_Up = false;
        }

        public void Rotation_Down_Button()
        {
            GameObject.FindWithTag("Model").transform.Rotate(-Rotation_Speed * Time.deltaTime, 0, 0);
        }
        public void Rotation_Down_Button_Repeat()
        {
            Repeat_Rotate_Down = true;
        }
        public void Rotation_Down_Button_Off()
        {
            Repeat_Rotate_Down = false;
        }

        public void Rotation_Left_Button()
        {
            GameObject.FindWithTag("Model").transform.Rotate(0, Rotation_Speed * Time.deltaTime, 0);
        }
        public void Rotation_Left_Button_Repeat()
        {
            Repeat_Rotate_Left = true;
        }
        public void Rotation_Left_Button_Off()
        {
            Repeat_Rotate_Left = false;
        }

        public void Rotation_Right_Button()
        {
            GameObject.FindWithTag("Model").transform.Rotate(0, -Rotation_Speed * Time.deltaTime, 0);
        }
        public void Rotation_Right_Button_Repeat()
        {
            Repeat_Rotate_Right = true;
        }
        public void Rotation_Right_Button_Off()
        {
            Repeat_Rotate_Right = false;
        }
}
