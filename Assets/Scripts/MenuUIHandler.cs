using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] RawImage vehicleSelector;

    public void NewStart()
    {
        SceneManager.LoadScene(1);
    }

    public void PickVehicle()
    {
        Button imgBtn = vehicleSelector.GetComponent<Button>();
        ColorBlock colors = imgBtn.colors;
        colors.selectedColor = Color.green;
        imgBtn.colors = colors;
    }
}
