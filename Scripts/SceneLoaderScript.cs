using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
public class SceneLoaderScript : MonoBehaviour
{
  public void QuitGame() {
  EditorApplication.isPlaying = false;
  }

  public void goToSettings() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

  public void backToHome() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
  }

  public void startGame() {
    AuthManager.gamesPlayed+=1;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    Time.timeScale = 1f;
  }

  public void endGame() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
  }

  public void goToRegistration() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
  }

  public void RegistrationToHome() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
  }

  public void goToLeaderbaords() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
  }

  public void LeaderboardToHome() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
  }

  public void goToProfile() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
  }

  public void profileToHome() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
  }

  public void profileToStats() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

  public void statsToProfile() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
  }

  public void AdvertisementToGameOver()
  {
    SceneManager.LoadScene(2);
  }

  public void GameOverToHome()
  {
    SceneManager.LoadScene(0);
  }

  public void ProfileToAvatarSelection()
  {
    SceneManager.LoadScene(8);
  }

  public void AvSelectiontoProfile()
  {
    SceneManager.LoadScene(5);
  }

}
