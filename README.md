# TCU_FleaMarket

## Herokuへのデプロイ

### 事前準備
・事前にheroku CLIでログインしておく

・Docker Desktopをインストール

### デプロイの手順

・Docker Desktopを起動する

・VisualStudioでこのプロジェクトをデプロイ

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

## 注意点
・SQLiteを使用しているため、デプロイする際にデータベースが初期化される

・Herokuでは、一定時間ごとにSQLiteのデータベースが[初期化される](https://devcenter.heroku.com/ja/articles/sqlite3)
