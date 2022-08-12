
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{

    public UIManager uiManager;
    public bool isGameStarted;
    public bool isGameHasEnded;
    public void StartGame()
    {
        isGameStarted = true;
        uiManager.StartGame();
    }

    public void EndGame(bool isWin)
    {
        isGameStarted = false;
        uiManager.EndGame(isWin);

    }

    public void NextLevel()
    {
        isGameHasEnded = true;
        uiManager.EndGame(true);
    }

    public void NextGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }




}
