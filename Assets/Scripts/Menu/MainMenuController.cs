using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(CanvasGroup))]
public class MainMenuController : MonoBehaviour
{
    public float FadeDuration;
    public TextMeshProUGUI Score;
    public CanvasGroup gameUI;

    private CanvasGroup canvasGroup;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        gameUI.gameObject.SetActive(false);
    }

    public void ShowMenu()
    {
        StartCoroutine(UIUtils.CanvasGroupFadeCoroutine(canvasGroup, FadeDuration, UIUtils.Fade.FadeIn));
    }

    public void HideMenu()
    {
        StartCoroutine(UIUtils.CanvasGroupFadeCoroutine(canvasGroup, FadeDuration, UIUtils.Fade.FadeOut));
    }

    public void ShowGame()
    {
        StartCoroutine(UIUtils.CanvasGroupFadeCoroutine(gameUI, FadeDuration, UIUtils.Fade.FadeIn));
    }

    public void HideGame()
    {
        StartCoroutine(UIUtils.CanvasGroupFadeCoroutine(gameUI, FadeDuration, UIUtils.Fade.FadeOut));
    }

    public void OnStartButton()
    {
        HideMenu();
        ShowGame();
    }
}
