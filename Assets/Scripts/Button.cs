using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Button : MonoBehaviour
{
    public event System.Action OnClicked;

    private void OnMouseDown()
    {
        OnClicked?.Invoke();
    }
}
