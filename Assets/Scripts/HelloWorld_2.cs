using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld_2 : MonoBehaviour
{
    [SerializeField]
    private string myName = "Hello World 2";

    private enum actionPropsList { Idle, Run };
    [SerializeField]
    private actionPropsList actionState;
    
    private string actionString = "";


    private void Awake()
    {
        Debug.Log("Awake called!");
    }






    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start called!");

    }

    // Update is called once per frame
    void Update()
    {
        // 可以在這裡根據狀態做邏輯
    }

    private void OnGUI()
    {
        GUI.color = Color.red;
        GUI.Label(new Rect(10, 10, 300, 20), "Hello, my name is " + myName);

        if (actionState == actionPropsList.Idle)
        {
            actionString = "I will " + actionState;
        }
        else if (actionState == actionPropsList.Run)
        {
            actionString = "I will " + actionState;
            GUI.Label(new Rect(10, 30, 300, 20), "I am currently running.");
        }
        else
        {
            actionString = "";
        }
        // 顯示目前狀態字串
        if (!string.IsNullOrEmpty(actionString))
        {
            GUI.Label(new Rect(10, 50, 300, 20), actionString);
        }
    }
}
