using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    public void GameOPver()
    {
        gameOverText.gameObject.SetActive(true);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(!gameObject.CompareTag("Player"))
        {
            GameOver.Gameover();
        }
    }
}
