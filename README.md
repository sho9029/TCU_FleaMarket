# TCU_FleaMarket

学部の授業で作成

## Herokuへのデプロイ

### 事前準備
・[heroku CLIをインストールしてログインする](https://devcenter.heroku.com/ja/articles/heroku-cli)

・[Docker Desktopをインストール](https://www.docker.com/get-started/)

### デプロイの手順

・Docker Desktopを起動する

・Visual Studioでこのプロジェクトをデプロイ

・ターミナルを開き、デプロイしたディレクトリに移動する

・そのディレクトリに以下の内容を記述した"Dockerfile"を追加する
```
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
ENV ASPNETCORE_Environment=Production
WORKDIR /app
COPY . .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet TCU_FleaMarket.dll
```

・次のコマンドを順に実行する
``` powershell
heroku container:push web -a {ProjectId}
heroku container:release web -a {ProjectId}
```
{ProjectId}には、HerokuでのApp Nameを入力

## 注意点
・SQLiteを使用しているため、デプロイする際にデータベースが初期化される

・Herokuでは、一定時間ごとにSQLiteのデータベースが[初期化される](https://devcenter.heroku.com/ja/articles/sqlite3)

・プロジェクトに含まれる"Dockerfile"はVisual Studioでのデバッグ用のものであり、Herokuへのデプロイには使用しない
