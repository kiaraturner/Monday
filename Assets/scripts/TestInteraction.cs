using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInteraction : MonoBehaviour, IInteractable
{
    #region boolean defintion
    private bool exampleBool;
    public bool ExampleBool;
    #endregion

    public delegate void InteractionDelegate();

    public event InteractionDelegate interactionEvent = delegate { };

    private void OnEnable()
    {
        interactionEvent += TestMethod;
        interactionEvent += TestMethodTwo;
    }

    private void OnDisable()
    {
        interactionEvent -= TestMethodTwo;
        interactionEvent -= TestMethodTwo;
    }


    public void Activate()
    {
        interactionEvent.Invoke();
    }

    private void TestMethod()
    {
        Debug.Log("First method has been executed");
    }

    private void TestMethodTwo()
    {
        Debug.Log("Second method has been exectuted.");
    }
}
