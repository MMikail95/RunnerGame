using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIManager : MonoBehaviour

{


    [SerializeField] private GameObject _startPanel;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _hudPanel;

    public void StartGame()
    {
        _startPanel.SetActive(false);
        _hudPanel.SetActive(true);
    }

    public void EndGame(bool isWin)
    {
        _hudPanel.SetActive(false);
        if (isWin)
        {

            _winPanel.SetActive(true);
        }
        else
        {
            _losePanel.SetActive(true);
            //SceneManager.LoadScene("Game");
        }


    }

}
