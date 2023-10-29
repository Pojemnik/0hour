using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuController : MonoBehaviour
{
    public float FadeDuration;
    public TextMeshProUGUI Score;
    public CanvasGroup gameUI;

    public CanvasGroup mainMenuUI;

    private void Awake()
    {
        gameUI.gameObject.SetActive(false);
    }

    public void ShowMenu()
    {
        StartCoroutine(UIUtils.CanvasGroupFadeCoroutine(mainMenuUI, FadeDuration, UIUtils.Fade.FadeIn));
    }

    public void HideMenu()
    {
        StartCoroutine(UIUtils.CanvasGroupFadeCoroutine(mainMenuUI, FadeDuration, UIUtils.Fade.FadeOut));
    }

    public void ShowGame()
    {
        StartCoroutine(UIUtils.CanvasGroupFadeCoroutine(gameUI, FadeDuration, UIUtils.Fade.FadeIn));
    }

    public void HideGame()
    {
        StartCoroutine(UIUtils.CanvasGroupFadeCoroutine(gameUI, FadeDuration, UIUtils.Fade.FadeOut));
    }

    public void OnStartGame()
    {
        HideMenu();
        ShowGame();
    }

    public void OnEndGame(int score)
    {
        HideGame();
        ShowMenu();

        Score.text = $"Score: {score}";
    }
}
