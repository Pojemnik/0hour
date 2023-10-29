using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public int time = 30;
    public TextMeshProUGUI Timer;
    public MainMenuController MainMenu;
    public int points = -1;
    BombManager bombManager;

    public void StartGame()
    {
        bombManager = FindObjectOfType<BombManager>();
        points = -1;
        MainMenu.OnStartGame();
        StartCoroutine(TimerLoop());
        bombManager.NewBomb();
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
        StopAllCoroutines();
        MainMenu.OnEndGame(points);
    }
}
