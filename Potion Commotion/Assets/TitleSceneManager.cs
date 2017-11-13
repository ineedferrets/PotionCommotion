using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using InControl;

public class TitleSceneManager : MonoBehaviour {

    int selectedItem;

    public Button[] menuOptions;

    private void Start() {
        menuOptions[0].Select();
        selectedItem = 0;
    }

    // Update is called once per frame
    void Update () {
        if (InputManager.ActiveDevice.LeftStick.Down.WasPressed)
        {
            menuOptions[selectedItem].Se
        }
	}
}
