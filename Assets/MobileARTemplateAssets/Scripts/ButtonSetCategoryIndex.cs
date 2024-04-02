using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonSetCategoryIndex : MonoBehaviour
{
    Button thisButton;

    [SerializeField]
    string sceneName;


    private void Awake()
    {
        thisButton = GetComponent<Button>();

        thisButton.onClick.AddListener(() =>
        {
            SceneManager.LoadSceneAsync(sceneName);
            MainMenuManager.IsNotFirstTime = true;
        });
    }
}
