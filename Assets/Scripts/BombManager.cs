using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombManager : MonoBehaviour
{
    [SerializeField]
    private GameObject BombPrefab;
    [SerializeField]
    private Vector3 position;

    private GameObject currentBombObj;
    private Bomb currentBomb;
    private GameController gameController;
    

    private void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    public void NewBomb()
    {
        gameController.points++;
        if (currentBomb != null)
        {
            currentBomb.OnWin -= NewBomb;
            currentBomb.OnLoose -= Loose;
            DestroyImmediate(currentBombObj);
        }
        currentBombObj = Instantiate(BombPrefab, position, Quaternion.identity);
        currentBomb = currentBombObj.GetComponent<Bomb>();
        currentBomb.OnWin += NewBomb;
        currentBomb.OnLoose += Loose;
    }

    private void Loose()
    {
        Destroy(currentBombObj);
        gameController.EndGame();
    }
}
