using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuNavigation : MonoBehaviour
{
    public Button[] buttons;  // Assign the 4 buttons in order
    private int currentIndex = 0;

    void Start()
    {
        SelectButton(currentIndex);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (currentIndex == 2) currentIndex = 0;
            else if (currentIndex == 3) currentIndex = 1;
            SelectButton(currentIndex);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (currentIndex == 0) currentIndex = 2;
            else if (currentIndex == 1) currentIndex = 3;
            SelectButton(currentIndex);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentIndex == 1) currentIndex = 0;
            else if (currentIndex == 3) currentIndex = 2;
            SelectButton(currentIndex);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentIndex == 0) currentIndex = 1;
            else if (currentIndex == 2) currentIndex = 3;
            SelectButton(currentIndex);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            buttons[currentIndex].onClick.Invoke();
        }
    }

    void SelectButton(int index)
    {
        EventSystem.current.SetSelectedGameObject(buttons[index].gameObject);
    }
}