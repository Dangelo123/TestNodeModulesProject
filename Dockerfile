FROM microsoft/dotnet:2.1.0-aspnetcore-runtime

RUN apt-get update
RUN apt-get -y install curl gnupg
RUN apt-get install -y git
RUN curl -sL https://deb.nodesource.com/setup_12.x  | bash -
RUN apt-get -y install nodejs
RUN npm install
RUN npm install lodash --save


WORKDIR /app
EXPOSE 80
COPY . .
ENTRYPOINT ["dotnet", "Ole.FaturaOnline.WebApi.dll"]


