using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BombTip : MonoBehaviour
{
    public TextMeshProUGUI Text;

    private void Awake()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }
}
