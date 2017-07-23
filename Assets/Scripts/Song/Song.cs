﻿namespace SongUtility
{
  public class Song
  {
    int songId; // 曲ID
    string title; // 曲タイトル
    string artist; // アーティスト名
    DanceScore danceScore; // 採点
    Movie movie; // 動画

    public Song(int id)
    {
      danceScore = new DanceScore();
      movie = new Movie();
      songId = id;

      // 仮実装、本来ならサーバにデータを取りに行く
      switch (id)
      {
        case 1:
          title = "曲名1";
          artist = "アーティスト1";
          break;

        case 2:
          title = "曲名2";
          artist = "アーティスト2";
          break;

        case 3:
          title = "曲名3";
          artist = "アーティスト3";
          break;
      }
    }
  }
}