using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HotbarButtonController : MonoBehaviour
{
    public int Id;
    private Animator anim;
    public string itemName;
    public TextMeshProUGUI itemText;
    public Image selectedItem;
    private bool selected = false;
    public Sprite icon;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (selected) 
        {
            selectedItem.sprite = icon;
            itemText.text = itemName;

        
        }
    }

    public void Selected()
    {
        selected = true;
        WheelHotbarController.weaponID = Id;
    }

    public void DesSelected()
    {
        selected = false;
        WheelHotbarController.weaponID = 0;
    }

    public void HoverEnter()
    {
        anim.SetBool("Hover", true);
        itemText.text = itemName;
    }
    public void HoverExit()
    {
        anim.SetBool("Hover", false);
        itemText.text = "";
    }
}
