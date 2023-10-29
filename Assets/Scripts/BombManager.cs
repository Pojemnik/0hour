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

    private void Start()
    {
        NewBomb();
    }

    private void NewBomb()
    {
        if(currentBomb != null)
        {
            currentBomb.OnWin -= NewBomb;
            currentBomb.OnLoose -= Loose;
            Destroy(currentBombObj);
        }
        currentBombObj = Instantiate(BombPrefab, position, Quaternion.identity);
        currentBomb = currentBombObj.GetComponent<Bomb>();
        currentBomb.OnWin += NewBomb;
        currentBomb.OnLoose += Loose;
    }

    private void Loose()
    {
        print("Lost");
    }
}
