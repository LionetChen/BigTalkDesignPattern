# Commands used
Create directory bigtalk-designpattern

`dotnet new sln -o bigtalk-designpattern`

Create SimpleFactoryPattern project and add it to solution

```powershell
dotnet new classlib -o SimpleFactoryPattern
dotnet sln add ./SimpleFactoryPattern/SimpleFactoryPattern.csproj
```

Add unit testing
dotnet new mstest -o BigTalkDesignPattern.Tests
```powershell
dotnet new classlib -o BigTalkDesignPattern.Tests
dotnet sln add ./BigTalkDesignPattern.Tests/BigTalkDesignPattern.Tests.csproj
```
Add library reference to the test project

`dotnet add ./BigTalkDesignPattern.Tests/BigTalkDesignPattern.Tests.csproj reference ./SimpleFactoryPattern/SimpleFactoryPattern.csproj`

To show tests result with test method name and without noise

`dotnet test -v quiet --nologo -l:"console;verbosity=normal" .\BigTalkDesignPattern.Tests\`

# To compile and run the code:

```
cd src
dotnet build
dotnet test
```

Make sure no error is found before committing.

# To create repo
```
git init
git add .
git commit
git remote add origin https://github.com/LionetChen/BigTalkDesignPattern
git pull --set-upstream origin main
git push
```