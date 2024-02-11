# Git 

**Remove already existing file in remote repo**
```bash
git rm --cached {filename}
```
***
**Undo commit and keep all files staged**
```bash
git reset --soft HEAD~
```
***
**Undo commit and unstage all files**
```bash
git reset HEAD~
```
***
**Undo the commit and completely remove all changes**
```bash
git reset --hard HEAD~**
```