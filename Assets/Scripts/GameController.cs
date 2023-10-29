using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public int time = 30;
    public TextMeshProUGUI Timer;
    public MainMenuController MainMenu;

    public void StartGame()
    {
        MainMenu.OnStartGame();
        StartCoroutine(TimerLoop());
    }

    IEnumerator TimerLoop()
    {
        int time = this.time;
        Timer.text = time.ToString();
        while (time > 0)
        {
            yield return new WaitForSeconds(1);
            time--;
            Timer.text = time.ToString();
        }
        EndGame();
    }

    public void EndGame()
    {
        MainMenu.OnEndGame(0);
    }
}
