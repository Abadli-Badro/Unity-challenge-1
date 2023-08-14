using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public static bool gameover = false;
    private void Update()
    {
        if (!gameover)
        {
            if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(new Vector3(0, 0, MoveSpeed * Time.deltaTime));
            if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(new Vector3(0, 0, MoveSpeed * -Time.deltaTime));
            if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(new Vector3(-MoveSpeed * Time.deltaTime, 0, 0));
            if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(new Vector3(MoveSpeed * Time.deltaTime, 0, 0));
        }
    }
}
