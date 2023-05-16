using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropDownScript : MonoBehaviour
{

    public TMP_Text TextBox;
    // Start is called before the first frame update
    void Start()
    {
      var dropdown = transform.GetComponent<TMP_Dropdown>();

        List<string> items = new List<string>();
        items.Add("Coins collected");
        items.Add("Games played");
        items.Add("Times elapsed");

        foreach(var item in items) {
          dropdown.options.Add(new TMP_Dropdown.OptionData() {text = item});
        }

        dropdown.onValueChanged.AddListener(delegate {
          DropdownItemSelected(dropdown);
        });
    }

    void DropdownItemSelected(TMP_Dropdown dropdown) {
      int index = dropdown.value;

      TextBox.text = dropdown.options[index].text;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
