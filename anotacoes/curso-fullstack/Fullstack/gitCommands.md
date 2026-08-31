Os comandos git para o PowerShell listados aqui:
```shell
git init #IMPORTANT
git config --list
git config --global --list
git config --local --list
git config --global user.name "Alexandre Moreira"
git config --global user.email "alexandre.moreiramarques@gmail.com"
git config --local user.name "Alexandre Moreira"
git config --local user.email "alexandre.moreiramarques@gmail.com"
git add .
git commit -m "Add to the remote repository"
git branch -M main
git remote add origin https://github.com/Alekson2308/repositorio.git
git push -u origin main
====================================================================
git config --global --unset-all user.name
git config --global --unset-all user.email
git config --global --unset-all credential.helper
```

