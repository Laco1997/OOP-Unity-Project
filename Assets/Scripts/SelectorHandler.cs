using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectorHandler : MenuUIHandler
{
    public void PickedVehicle(RawImage vehicle)
    {
        Button imgBtn = vehicle.GetComponent<Button>();
        ChangeButtonColor(imgBtn);

        MainManager.Instance.pickedVehicle = vehicle.gameObject.tag.ToString();
    }

    void ChangeButtonColor(Button btn)
    {
        ColorBlock colors = btn.colors;
        colors.selectedColor = Color.green;
        btn.colors = colors;
    }
}
