using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileAvatarManage : MonoBehaviour
{

    public Image avatar;
    public CharacterDatabase characterDB;
    
    private void UpdateCharacter()
    {
        Character character = characterDB.GetCharacter(CharacterManager.selectedOption);
        avatar.sprite = character.characterSprite;
    }
    void Start()
    {
        UpdateCharacter();
    }

}
