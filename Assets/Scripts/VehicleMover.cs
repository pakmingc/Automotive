using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMover : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10.0f;
    [SerializeField]
    private float turnSpeed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        // 可初始化內容
    }

    // Update is called once per frame
    void Update()
    {
        // 前後移動
        float move = 0f;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            move = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            move = -1f;
        }
        transform.Translate(Vector3.forward * move * moveSpeed * Time.deltaTime);

        // 左右轉彎
        float turn = 0f;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            turn = -1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            turn = 1f;
        }
        transform.Rotate(Vector3.up, turn * turnSpeed * Time.deltaTime);
    }
}
