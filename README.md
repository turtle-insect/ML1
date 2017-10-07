# 概要
3DS マリオ＆ルイージRPG1 DXのセーブデータ編集Tool

# ソフト
https://www.nintendo.co.jp/3ds/brmj/

# 実行に必要
* Windows マシン
* .NET Framework 4.5の導入
* セーブデータの吸い出し
* セーブデータの書き戻し

# Build環境
* Windows 10(64bit)
* Visual Studio 2017

# 編集時の手順
* saveDataを吸い出す
   * 結果、以下が取得可能
      * ML1_000.sav
      * ML1_001.sav(ML1_002.sav)
* ML1_001.sav(ML1_002.sav)を読み込む
* 任意の編集を行う
* ML1_001.sav(ML1_002.sav)を書き出す
* saveDataを書き戻す
