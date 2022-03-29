using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInterationToo : MonoBehaviour, IInteractable
{
    public TestInteraction interaction;

    private void Start()
    {
        interaction.interactionEvent += TestMethodThree;
    }

    public void Activate()
    {
        Debug.Log("The interaction is currently turned on:" + interaction.ExampleBool);
        interaction.Activate();
    }

    private void TestMethodThree()
    {
        Debug.Log("Test method three has been exectuted,");
    }

}
