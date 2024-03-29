using UnityEngine;

public class GameManagerBis : Singleton<GameManagerBis>
{
    [HideInInspector] public int numGameOver;
    [HideInInspector] public bool authorizeExit = false;

    [Header("Exit Door")]
    public Animator exitDoorAnimation;

    [Header("Codes")]
    public GameObject finalCode;

    [Header("DEMO")]
    public bool isDemo;
    public GameObject finalDemoCode;
    
    public void GameOver(int number)
    {
        GameManagerBis.Instance.numGameOver = number;
        AudioManager.Instance.PlayBackgroundMusic(false);
        SceneManagerBis.Instance.ChangeScene("Game Over");
    }

    public void OpenExitDoor()
    {
        exitDoorAnimation.SetTrigger("Open Door");
        authorizeExit = true;
    }
}
