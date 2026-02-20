using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIScript : MonoBehaviour
{

    public GameObject ballobj;
    public Slider Sliderobj;
    public TMP_Dropdown dropdownobj;

    public void HideBall(){
      ballobj.SetActive(false);

    }

    public void ShowBall(){
        ballobj.SetActive(true);
    }

    public void ScaleBall(){
        float scaleVal = Sliderobj.value + 1f;
        ballobj.transform.localScale = new Vector3(scaleVal, scaleVal, scaleVal);
    }

    public void ShowDropdownValue(){
        Debug.Log(dropdownobj.value);
    }
}
