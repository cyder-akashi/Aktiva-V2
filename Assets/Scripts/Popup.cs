﻿﻿using UnityEngine;
using UnityEngine.UI;
using SongUtility;
using UserInputs;

public class Popup : MonoBehaviour
{
  public GameObject addSongPopup;
  GameObject popup;
  AddSong addSong;

  void Start ()
  {
    addSong = (AddSong)UserInputManager.GetUserInput(UserInputCode.AddSong);
    addSong.OnValueChanged += OnAddSongValueChanged;
  }

  // 曲追加時のポップアップ
  void OnAddSongValueChanged(object sender, UserInputEventArgs e)
  {
    Clear();
    popup = Instantiate(
              addSongPopup,
              transform.position,
              Quaternion.identity
            );
    popup.transform.SetParent(transform);

    Song song = addSong.GetData(0);

    Text songTitle = popup.transform.Find("SongTitle").gameObject.GetComponent<Text>();
    songTitle.text = song.title;
    Text artistName = popup.transform.Find("ArtistName").gameObject.GetComponent<Text>();
    artistName.text = song.artist;
  }

  // 出ているポップアップの削除
  void Clear()
  {
    if (popup != null)
    {
      Destroy(popup);
    }
  }
}