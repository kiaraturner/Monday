using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    public delegate void MenuButtonAction();

    [Tooltip("The default colour of the button.")]
    [SerializeField] private Color defaultColor;
    [Tooltip("The colour of the button when selected")]
    [SerializeField] private Color selectedColour;
    [Tooltip("The colour of the button when the mouse is over it")]
    [SerializeField] private Color highlightedColour;
    [SerializeField] private UnityEvent onActivate;


    private bool mouseOver = false;
    private Image image;
    //menu instance

    public event MenuButtonAction ActivateEvent;
    public event MenuButtonAction SelectEvent;

    private void Awake()
    {
        TryGetComponent(out image);
        //Try get menu instance reference
        {

        }

    }
        private void Start()
        {
            image.color = defaultColor;
        }


    private void Update()
    {
        if (mouseOver = true && Input.GetButtonDown("Fire1") == true)
        {
            //it the selected button for the mebu is this button
            //Activate();
            //else
            //Select();
        }
    }
    

    /// <summary>
    /// Use this method to invoke the selection event for the button.
    /// </summary>


    public void Select()
    {
        SelectEvent.Invoke();
    }

    /// <summary>
    /// Use this method to invoke the Activate event for the button.
    /// </summary>

    public void Activate()
    {
        ActivateEvent.Invoke();
    }

}
