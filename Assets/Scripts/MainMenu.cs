using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject pauseMenu;
    private bool ActiveMenu;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            ActiveMenu = !ActiveMenu;
            pauseMenu.SetActive(ActiveMenu);
        }
    }
    public void startGame() {
        SceneManager.LoadScene(1);
    }

    public void exitOptionMenu(GameObject go) {
        go.SetActive(false);
    }

    public void activeOptionMenu(GameObject go) {
        go.SetActive(true);
    }

}
