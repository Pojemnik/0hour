using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField]
    private Button button1;
    [SerializeField]
    private Button button2;
    [SerializeField]
    private Button button3;
    [SerializeField]
    private Button button4;
    [SerializeField]
    private Button button5;
    [SerializeField]
    private Button button6;

    private string[] passwords = { "123456", "542166", "435241" };
    private string password;
    private string input;

    private void Start()
    {
        password = passwords[Random.Range(0, passwords.Length)];
        print(password);
        button1.OnClicked += () => OnButtonClicked("1");
        button2.OnClicked += () => OnButtonClicked("2");
        button3.OnClicked += () => OnButtonClicked("3");
        button4.OnClicked += () => OnButtonClicked("4");
        button5.OnClicked += () => OnButtonClicked("5");
        button6.OnClicked += () => OnButtonClicked("6");
    }

    private void OnButtonClicked(string index)
    {
        input += index;
        if(input.Length == password.Length)
        {
            if(input == password)
            {
                print("ok");
            }
            else
            {
                print("nie ok");
            }
        }
    }
}
