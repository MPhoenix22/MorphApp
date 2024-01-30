using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image backdrop;
    public Button selectImagesButton;
    public Button approveCreatureButton;
    public Button applyTransformationButton;
    public Button applyFormFeaturesButton;
    public Button exitButton;

    private void Start()
    {
        // Set UI menu backdrop
        backdrop.sprite = Resources.Load<Sprite>("PhoenixSkyBackdrop");

        // Set UI menu items text
        selectImagesButton.GetComponentInChildren<Text>().text = "Select Images";
        approveCreatureButton.GetComponentInChildren<Text>().text = "Approve Creature image via Biometrics";
        applyTransformationButton.GetComponentInChildren<Text>().text = "Apply Transformation to Creature";
        applyFormFeaturesButton.GetComponentInChildren<Text>().text = "Apply Form Features";
        exitButton.GetComponentInChildren<Text>().text = "Exit";

        // Add button click listeners
        selectImagesButton.onClick.AddListener(OnSelectImagesButtonClick);
        approveCreatureButton.onClick.AddListener(OnApproveCreatureButtonClick);
        applyTransformationButton.onClick.AddListener(OnApplyTransformationButtonClick);
        applyFormFeaturesButton.onClick.AddListener(OnApplyFormFeaturesButtonClick);
        exitButton.onClick.AddListener(OnExitButtonClick);
    }

    private void OnSelectImagesButtonClick()
    {
        // Handle Select Images button click
        Debug.Log("Select Images button clicked");
        // Add your code for handling the logic related to selecting images here
    }

    private void OnApproveCreatureButtonClick()
    {
        // Handle Approve Creature button click
        Debug.Log("Approve Creature button clicked");
        // Add your code for handling the logic related to approving creature image via biometrics here
    }

    private void OnApplyTransformationButtonClick()
    {
        // Handle Apply Transformation button click
        Debug.Log("Apply Transformation button clicked");
        // Add your code for handling the logic related to applying transformation to creature here
    }

    private void OnApplyFormFeaturesButtonClick()
    {
        // Handle Apply Form Features button click
        Debug.Log("Apply Form Features button clicked");
        // Add your code for handling the logic related to applying form features here
    }

    private void OnExitButtonClick()
    {
        // Handle Exit button click
        Debug.Log("Exit button clicked");
        // Add your code for handling the logic related to exiting the app here
    }
}
