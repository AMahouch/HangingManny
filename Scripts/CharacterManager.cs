using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CharacterManager : MonoBehaviour
{

    public CharacterDatabase characterDB;

    public SpriteRenderer artworkSprite;
    public static int selectedOption = 0;

    public int getSpriteIndex()
    {
        return selectedOption;
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateCharacter(selectedOption);
        if(!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
    }

//check if you can access this from player script
   /* public  Sprite getSelectedSprite()
    {
        return artworkSprite.sprite;
    }
*/
    public void NextOption()
    {
        selectedOption++;
        if(selectedOption >= characterDB.CharacterCount)
        {
            selectedOption = 0;
        }
        UpdateCharacter(selectedOption);
        Save();
    }
    public void BackOption()
    {
        selectedOption--;
        if(selectedOption < 0)
        {
            selectedOption = characterDB.CharacterCount - 1;
        }
        UpdateCharacter(selectedOption);
        Save();
    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;

    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
        Debug.Log(selectedOption);
    }
    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
        Debug.Log(selectedOption);
    }

}
// //Delete this later
//     public void SceneChange()
//     {
//         SceneManager.LoadScene(7);
//     }
// }
    