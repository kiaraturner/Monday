using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
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
    private MenuNavigation instance;

    public event MenuButtonAction ActivateEvent = delegate { };
    public event MenuButtonAction SelectEvent = delegate { };

    private void Awake()
    {
        TryGetComponent(out image);
        //Try get menu instance reference
        transform.parent.TryGetComponent(out instance);
    }

    private void Start()
    {
        image.color = defaultColor;
    }


    private void Update()
    {
        if (mouseOver = true && Input.GetButtonDown("Fire1") == true)
        {
            //it the selected button for the menu is this button
            if (instance.SelectedButton == this)
            {
                Activate();
            }
            else
            {
                Select();
            }
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

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse enterd");
        mouseOver = true;
        if (instance.SelectedButton != this)
        {
            image.color = highlightedColour;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouseOver = false;
        if (image.color == highlightedColour && this != instance.SelectedButton)
        {
            image.color = defaultColor;
        }
    }

    private void OnActivate()
    {
        onActivate.Invoke();
    }

    private void OnSelect()
    {
        if (instans.SelectedButtom != null)
        {
            instance.SelectedButton.imaghe.color = instance.SelectedButtom.defaultColor;
        }
        instance.SelectedButton = this;
        image.color = selectedColour; selectedColour;
    }

    private void OnEnable()

    {
        ActivateEvent += OnActivate;
        SelectEvent += OnSelect;
    }

    private void OnDisable()

    {
        ActivateEvent -= OnActivate;
        SelectEvent -= OnSelect;
    }


}
